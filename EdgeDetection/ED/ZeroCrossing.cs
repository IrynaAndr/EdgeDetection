using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace EdgeDetection.ED
{
    internal class ZeroCrossing
    {
        
        public static Bitmap DetectZeroCrossings(Bitmap laplacianResult)
        {
            int width = laplacianResult.Width;
            int height = laplacianResult.Height;

            Bitmap zeroCrossingImage = new Bitmap(width, height);
            BitmapData laplacianData = laplacianResult.LockBits(new Rectangle(0, 0, width, height),
                                                                ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            BitmapData zeroCrossingData = zeroCrossingImage.LockBits(new Rectangle(0, 0, width, height),
                                                                     ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            int bytes = laplacianData.Stride * height;
            byte[] laplacianBuffer = new byte[bytes];
            byte[] zeroCrossingBuffer = new byte[bytes];

            Marshal.Copy(laplacianData.Scan0, laplacianBuffer, 0, bytes);
            laplacianResult.UnlockBits(laplacianData);

            for (int y = 1; y < height - 1; y++)
            {
                for (int x = 1; x < width - 1; x++)
                {
                    int byteOffset = y * laplacianData.Stride + x * 3;

                    bool isZeroCrossing = IsZeroCrossing(laplacianBuffer, laplacianData.Stride, byteOffset);
                    byte value = isZeroCrossing ? (byte)255 : (byte)0;

                    zeroCrossingBuffer[byteOffset] = value;
                    zeroCrossingBuffer[byteOffset + 1] = value;
                    zeroCrossingBuffer[byteOffset + 2] = value;
                }
            }

            Marshal.Copy(zeroCrossingBuffer, 0, zeroCrossingData.Scan0, bytes);
            zeroCrossingImage.UnlockBits(zeroCrossingData);

            return zeroCrossingImage;
        }

        private static bool IsZeroCrossing(byte[] buffer, int stride, int offset)
        {
            int[] neighbors = new int[]
            {
        buffer[offset - stride - 3], buffer[offset - stride], buffer[offset - stride + 3],
        buffer[offset - 3], buffer[offset + 3],
        buffer[offset + stride - 3], buffer[offset + stride], buffer[offset + stride + 3]
            };

            int center = buffer[offset];

            foreach (int neighbor in neighbors)
            {
                if ((center > 0 && neighbor < 0) || (center < 0 && neighbor > 0))
                {
                    return true;
                }
            }

            return false;
        }


    }
}
