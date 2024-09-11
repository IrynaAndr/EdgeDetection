using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EdgeDetection.ED
{
    internal class CannyED
    {
        public static (Bitmap gradientMagnitude, Bitmap gradientOrientation) ComputeGradients(Bitmap image)
        {
            if (!Flags.imageIsGrey)
            {
                image = preprocessing.ConvertToGrayscale(image);
            }
            int width = image.Width;
            int height = image.Height;

            Bitmap gradientMagnitude = new Bitmap(width, height);
            Bitmap gradientOrientation = new Bitmap(width, height);

            BitmapData grayData = image.LockBits(new Rectangle(0, 0, width, height),
                                                     ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            BitmapData magnitudeData = gradientMagnitude.LockBits(new Rectangle(0, 0, width, height),
                                                                  ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
            BitmapData orientationData = gradientOrientation.LockBits(new Rectangle(0, 0, width, height),
                                                                      ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            int bytes = grayData.Stride * height;
            byte[] grayBuffer = new byte[bytes];
            byte[] magnitudeBuffer = new byte[bytes];
            byte[] orientationBuffer = new byte[bytes];

            Marshal.Copy(grayData.Scan0, grayBuffer, 0, bytes);
            image.UnlockBits(grayData);


            for (int y = 1; y < height - 1; y++)
            {
                for (int x = 1; x < width - 1; x++)
                {
                    double gx = 0.0, gy = 0.0;

                    int byteOffset = y * grayData.Stride + x * 3;

                    for (int filterY = -1; filterY <= 1; filterY++)
                    {
                        for (int filterX = -1; filterX <= 1; filterX++)
                        {
                            int calcOffset = byteOffset + (filterX * 3) + (filterY * grayData.Stride);

                            gx += grayBuffer[calcOffset] * KernelConvolution.sobelX[filterY + 1, filterX + 1];
                            gy += grayBuffer[calcOffset] * KernelConvolution.sobelY[filterY + 1, filterX + 1];
                        }
                    }

                    double magnitude = Math.Sqrt(gx * gx + gy * gy);
                    double orientation = Math.Atan2(gy, gx) * (180.0 / Math.PI);

                    magnitudeBuffer[byteOffset] = ClipByte(magnitude);
                    magnitudeBuffer[byteOffset + 1] = ClipByte(magnitude);
                    magnitudeBuffer[byteOffset + 2] = ClipByte(magnitude);

                    orientationBuffer[byteOffset] = ClipByte(orientation);
                    orientationBuffer[byteOffset + 1] = ClipByte(orientation);
                    orientationBuffer[byteOffset + 2] = ClipByte(orientation);
                }
            }


            Marshal.Copy(magnitudeBuffer, 0, magnitudeData.Scan0, bytes);
            Marshal.Copy(orientationBuffer, 0, orientationData.Scan0, bytes);

            gradientMagnitude.UnlockBits(magnitudeData);
            gradientOrientation.UnlockBits(orientationData);

            return (gradientMagnitude, gradientOrientation);
        }

        private static byte ClipByte(double value)
        {
            return (byte)(Math.Max(0, Math.Min(255, value)));
        }

        public static Bitmap NonMaximumSuppression(Bitmap gradientMagnitude, Bitmap gradientOrientation)
        {
            int width = gradientMagnitude.Width;
            int height = gradientMagnitude.Height;

            Bitmap suppressedImage = new Bitmap(width, height);

            BitmapData magnitudeData = gradientMagnitude.LockBits(new Rectangle(0, 0, width, height),
                                                                  ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            BitmapData orientationData = gradientOrientation.LockBits(new Rectangle(0, 0, width, height),
                                                                      ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            BitmapData suppressedData = suppressedImage.LockBits(new Rectangle(0, 0, width, height),
                                                                 ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            int bytes = magnitudeData.Stride * height;
            byte[] magnitudeBuffer = new byte[bytes];
            byte[] orientationBuffer = new byte[bytes];
            byte[] suppressedBuffer = new byte[bytes];

            Marshal.Copy(magnitudeData.Scan0, magnitudeBuffer, 0, bytes);
            Marshal.Copy(orientationData.Scan0, orientationBuffer, 0, bytes);

            for (int y = 1; y < height - 1; y++)
            {
                for (int x = 1; x < width - 1; x++)
                {
                    int byteOffset = y * magnitudeData.Stride + x * 3;

                    double angle = orientationBuffer[byteOffset];
                    double mag = magnitudeBuffer[byteOffset];

                    double mag1 = 0;
                    double mag2 = 0;

                    // Determine neighboring pixels along the gradient direction
                    if ((angle >= 0 && angle < 22.5) || (angle >= 157.5 && angle <= 180))
                    {
                        mag1 = magnitudeBuffer[byteOffset - 3]; // Left pixel
                        mag2 = magnitudeBuffer[byteOffset + 3]; // Right pixel
                    }
                    else if (angle >= 22.5 && angle < 67.5)
                    {
                        mag1 = magnitudeBuffer[byteOffset - magnitudeData.Stride - 3]; // Top-left pixel
                        mag2 = magnitudeBuffer[byteOffset + magnitudeData.Stride + 3]; // Bottom-right pixel
                    }
                    else if (angle >= 67.5 && angle < 112.5)
                    {
                        mag1 = magnitudeBuffer[byteOffset - magnitudeData.Stride]; // Top pixel
                        mag2 = magnitudeBuffer[byteOffset + magnitudeData.Stride]; // Bottom pixel
                    }
                    else if (angle >= 112.5 && angle < 157.5)
                    {
                        mag1 = magnitudeBuffer[byteOffset - magnitudeData.Stride + 3]; // Top-right pixel
                        mag2 = magnitudeBuffer[byteOffset + magnitudeData.Stride - 3]; // Bottom-left pixel
                    }

                    if (mag >= mag1 && mag >= mag2)
                    {
                        suppressedBuffer[byteOffset] = magnitudeBuffer[byteOffset];
                        suppressedBuffer[byteOffset + 1] = magnitudeBuffer[byteOffset + 1];
                        suppressedBuffer[byteOffset + 2] = magnitudeBuffer[byteOffset + 2];
                    }
                    else
                    {
                        suppressedBuffer[byteOffset] = 0;
                        suppressedBuffer[byteOffset + 1] = 0;
                        suppressedBuffer[byteOffset + 2] = 0;
                    }
                }
            }

            Marshal.Copy(suppressedBuffer, 0, suppressedData.Scan0, bytes);
            suppressedImage.UnlockBits(suppressedData);
            gradientMagnitude.UnlockBits(magnitudeData);
            gradientOrientation.UnlockBits(orientationData);

            return suppressedImage;
        }

        public static Bitmap EdgeTrackingByHysteresis(Bitmap thresholdedImage, double lowThreshold, double highThreshold)
        {
            int width = thresholdedImage.Width;
            int height = thresholdedImage.Height;

            Bitmap hysteresisImage = new Bitmap(width, height);

            BitmapData thresholdedData = thresholdedImage.LockBits(new Rectangle(0, 0, width, height),
                                                                   ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            BitmapData hysteresisData = hysteresisImage.LockBits(new Rectangle(0, 0, width, height),
                                                                 ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            int bytes = thresholdedData.Stride * height;
            byte[] inputImageBuffer = new byte[bytes];
            byte[] hysteresisBuffer = new byte[bytes];

            Marshal.Copy(thresholdedData.Scan0, inputImageBuffer, 0, bytes);

            for (int y = 1; y < height - 1; y++)
            {
                for (int x = 1; x < width - 1; x++)
                {
                    int byteOffset = y * thresholdedData.Stride + x * 3;
                    byte pixelValue = inputImageBuffer[byteOffset];

                    if (pixelValue >= highThreshold)
                    {
                        hysteresisBuffer[byteOffset] = 255;
                        hysteresisBuffer[byteOffset + 1] = 255;
                        hysteresisBuffer[byteOffset + 2] = 255;
                        TrackEdges(inputImageBuffer, hysteresisBuffer, thresholdedData.Stride, x, y, width, height, lowThreshold);
                    }
                    else if (pixelValue < lowThreshold)
                    {
                        hysteresisBuffer[byteOffset] = 0;
                        hysteresisBuffer[byteOffset + 1] = 0;
                        hysteresisBuffer[byteOffset + 2] = 0;
                    }
                }
            }

            Marshal.Copy(hysteresisBuffer, 0, hysteresisData.Scan0, bytes);
            thresholdedImage.UnlockBits(thresholdedData);
            hysteresisImage.UnlockBits(hysteresisData);

            return hysteresisImage;
        }

        private static void TrackEdges(byte[] thresholdedBuffer, byte[] hysteresisBuffer, int stride, int x, int y, int width, int height, double lowThreshold)
        {
            int[] dx = { -1, 0, 1, -1, 1, -1, 0, 1 };
            int[] dy = { -1, -1, -1, 0, 0, 1, 1, 1 };

            int stackSize = width * height;
            Stack<(int, int)> stack = new Stack<(int, int)>(stackSize);
            stack.Push((x, y));

            while (stack.Count > 0)
            {
                (int currentX, int currentY) = stack.Pop();

                for (int i = 0; i < 8; i++)
                {
                    int newX = currentX + dx[i];
                    int newY = currentY + dy[i];

                    if (newX >= 0 && newX < width && newY >= 0 && newY < height)
                    {
                        int byteOffset = newY * stride + newX * 3;
                        if (thresholdedBuffer[byteOffset] >= lowThreshold && thresholdedBuffer[byteOffset] < 255)
                        {
                            thresholdedBuffer[byteOffset] = 255;
                            hysteresisBuffer[byteOffset] = 255;
                            hysteresisBuffer[byteOffset + 1] = 255;
                            hysteresisBuffer[byteOffset + 2] = 255;
                            stack.Push((newX, newY));
                        }
                    }
                }
            }
        }



    }
}

