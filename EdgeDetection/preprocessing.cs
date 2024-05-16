using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EdgeDetection
{
    internal class preprocessing
    {

        /*
        public static double[,] CreateGaussianKernel(int length, double sigma)
        {
            double[,] kernel = new double[length, length];
            double sum = 0.0;
            int radius = length / 2;
            double s = 2.0 * sigma * sigma;

            for (int x = -radius; x <= radius; x++)
            {
                for (int y = -radius; y <= radius; y++)
                {
                    double r = Math.Sqrt(x * x + y * y);
                    kernel[x + radius, y + radius] = (Math.Exp(-(r * r) / s)) / (Math.PI * s);
                    sum += kernel[x + radius, y + radius];
                }
            }

            // Normalize the kernel
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    kernel[i, j] /= sum;
                }
            }

            return kernel;
        }

        public static Bitmap ApplyGaussianFilter(Bitmap sourceBitmap, double[,] kernel)
        {
            BitmapData sourceData = sourceBitmap.LockBits(new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height),
                                                          ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

            int bytesPerPixel = Image.GetPixelFormatSize(sourceBitmap.PixelFormat) / 8;
            int byteCount = sourceData.Stride * sourceBitmap.Height;
            byte[] pixelBuffer = new byte[byteCount];
            byte[] resultBuffer = new byte[byteCount];

            IntPtr sourceScan0 = sourceData.Scan0;
            Marshal.Copy(sourceScan0, pixelBuffer, 0, byteCount);
            sourceBitmap.UnlockBits(sourceData);

            int filterOffset = (kernel.GetLength(0) - 1) / 2;
            int calcOffset = 0;
            double blue = 0.0, green = 0.0, red = 0.0;

            for (int offsetY = filterOffset; offsetY < sourceBitmap.Height - filterOffset; offsetY++)
            {
                for (int offsetX = filterOffset; offsetX < sourceBitmap.Width - filterOffset; offsetX++)
                {
                    blue = 0;
                    green = 0;
                    red = 0;

                    int byteOffset = offsetY * sourceData.Stride + offsetX * bytesPerPixel;

                    for (int filterY = -filterOffset; filterY <= filterOffset; filterY++)
                    {
                        for (int filterX = -filterOffset; filterX <= filterOffset; filterX++)
                        {
                            calcOffset = byteOffset + (filterX * bytesPerPixel) + (filterY * sourceData.Stride);

                            blue += (double)(pixelBuffer[calcOffset]) * kernel[filterY + filterOffset, filterX + filterOffset];
                            green += (double)(pixelBuffer[calcOffset + 1]) * kernel[filterY + filterOffset, filterX + filterOffset];
                            red += (double)(pixelBuffer[calcOffset + 2]) * kernel[filterY + filterOffset, filterX + filterOffset];
                        }
                    }

                    resultBuffer[byteOffset] = ClipByte(blue);
                    resultBuffer[byteOffset + 1] = ClipByte(green);
                    resultBuffer[byteOffset + 2] = ClipByte(red);
                }
            }

            Bitmap resultBitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height);
            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0, resultBitmap.Width, resultBitmap.Height),
                                                          ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            IntPtr resultScan0 = resultData.Scan0;
            Marshal.Copy(resultBuffer, 0, resultScan0, resultBuffer.Length);
            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }

        private static byte ClipByte(double color)
        {
            return (byte)(color > 255 ? 255 : (color < 0 ? 0 : color));
        }
        */

    }
}
