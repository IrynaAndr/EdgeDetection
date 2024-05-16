using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdgeDetection
{
    internal class extraFunctions
    {

        public static void UpdateElementVisibility(Control element, bool isVisible)
        {
            element.Visible = isVisible;
        }

        public static Bitmap DeepCopyBitmap(Bitmap source)
        {
            Bitmap copy = new Bitmap(source.Width, source.Height, source.PixelFormat);

            // Lock the source bitmap data
            BitmapData sourceData = source.LockBits(
                new Rectangle(0, 0, source.Width, source.Height),
                ImageLockMode.ReadOnly, source.PixelFormat);

            // Lock the copy bitmap data
            BitmapData copyData = copy.LockBits(
                new Rectangle(0, 0, copy.Width, copy.Height),
                ImageLockMode.WriteOnly, copy.PixelFormat);

            IntPtr sourceScan0 = sourceData.Scan0;
            IntPtr copyScan0 = copyData.Scan0;
            int imageSize = Math.Abs(sourceData.Stride) * source.Height;
            byte[] imageData = new byte[imageSize];
            Marshal.Copy(sourceScan0, imageData, 0, imageSize);
            Marshal.Copy(imageData, 0, copyScan0, imageSize);

            // Unlock the source and copy bitmap data
            source.UnlockBits(sourceData);
            copy.UnlockBits(copyData);

            return copy;
        }

        public static int FindMaxElementPoistion(double[] array)
        {
            double max = array[0];
            int res = 0;
            for (int i =0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    res = i;
                }
            }
            return res;
        }




    }
}
