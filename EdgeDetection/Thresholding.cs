﻿using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EdgeDetection
{
    internal class Thresholding
    {
        
        public static Bitmap VariableThresholdingLocalProperties(Bitmap image, double a, double b)
        {
            int w = image.Width;
            int h = image.Height;

            BitmapData imageData = image.LockBits(
                new Rectangle(0, 0, w, h),
                ImageLockMode.ReadWrite,
                PixelFormat.Format24bppRgb);

            int bytes = imageData.Stride * imageData.Height;
            byte[] buffer = new byte[bytes];
            byte[] result = new byte[bytes];

            Marshal.Copy(imageData.Scan0, buffer, 0, bytes);
            // Get global mean (average intensity)
            double mg = CalculateGlobalMean(buffer, bytes);
            for (int i = 0; i < bytes; i += 3)
            {
                int intensity = buffer[i];

                // Calculate local mean and standard deviation
                double localMean = CalculateLocalMean(buffer, imageData.Stride, i, w, h);
                double localStdDev = CalculateLocalStandardDeviation(buffer, imageData.Stride, i, localMean, w, h);

                double threshold = a * localStdDev + b * mg;

                for (int c = 0; c < 3; c++)
                {
                    result[i + c] = (byte)((intensity > threshold) ? 255 : 0);
                }
            }

            // Copy result back to image data
            Marshal.Copy(result, 0, imageData.Scan0, bytes);
            image.UnlockBits(imageData);

            return image;
        }

        private static double CalculateGlobalMean(byte[] buffer, int bytes)
        {
            double sum = 0;
            for (int i = 0; i < bytes; i += 3)
            {
                sum += buffer[i];
            }
            return sum / (bytes / 3); // Calculate mean (average intensity)
        }

        private static double CalculateLocalMean(byte[] buffer, int stride, int position, int width, int height)
        {
            double sum = 0;
            int count = 0;

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    int x = (position % stride / 3) + j;
                    int y = (position / stride) + i;

                    // Check if (x, y) is within image bounds
                    if (x >= 0 && x < width && y >= 0 && y < height)
                    {
                        int nposition = y * stride + x * 3;
                        sum += buffer[nposition];
                        count++;
                    }
                }
            }

            return (count > 0) ? sum / count : 0; // Calculate local mean (average intensity in a valid 3x3 neighborhood)
        }

        private static double CalculateLocalStandardDeviation(byte[] buffer, int stride, int position, double localMean, int width, int height)
        {
            double sum = 0;
            int count = 0;

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    int x = (position % stride / 3) + j;
                    int y = (position / stride) + i;

                    // Check if (x, y) is within image bounds
                    if (x >= 0 && x < width && y >= 0 && y < height)
                    {
                        int nposition = y * stride + x * 3;
                        sum += Math.Pow(buffer[nposition] - localMean, 2);
                        count++;
                    }
                }
            }

            // Calculate local standard deviation (based on local mean and valid neighboring pixels)
            return (count > 0) ? Math.Sqrt(sum / count) : 0;
        }




        public static Bitmap GlobalThresholding( Bitmap image)
        {
            int w = image.Width;
            int h = image.Height;

            BitmapData image_data = image.LockBits(
                new Rectangle(0, 0, w, h),
                ImageLockMode.ReadOnly,
                PixelFormat.Format24bppRgb);

            int bytes = image_data.Stride * image_data.Height;
            byte[] buffer = new byte[bytes];
            byte[] result = new byte[bytes];

            Marshal.Copy(image_data.Scan0, buffer, 0, bytes);
            image.UnlockBits(image_data);

            //Getting threshold intensity value
            int[] converted = buffer.Select(x => (int)x).ToArray();
            int init = converted.Sum() / bytes;
            int delta = 1;

            while (delta > 0)
            {
                int[] histogram = new int[256];
                for (int i = 0; i < bytes; i += 3)
                {
                    //int index = Math.Min(buffer[i], 255);
                    histogram[buffer[i]]++;
                }

                int mean1 = 0;
                int mean2 = 0;
                int sum1 = 0;
                int sum2 = 0;

                for (int i = 0; i < 255; i++)
                {
                    if (i <= init)
                    {
                        mean1 += histogram[i] * i;
                        sum1 += histogram[i];
                    }
                    else
                    {
                        mean2 += histogram[i] * i;
                        sum2 += histogram[i];
                    }
                }

                mean1 /= sum1;
                mean2 /= sum2;
                delta = init;
                init = (mean1 + mean2) / 2;
                delta = Math.Abs(delta - init);
            }

            //Thresholding
            for (int i = 0; i < bytes; i++)
            {
                result[i] = (byte)(buffer[i] >= init ? 255 : 0);
            }

            Bitmap res_img = new Bitmap(w, h);
            BitmapData res_data = res_img.LockBits(
                new Rectangle(0, 0, w, h),
                ImageLockMode.WriteOnly,
                PixelFormat.Format24bppRgb);
            Marshal.Copy(result, 0, res_data.Scan0, bytes);
            res_img.UnlockBits(res_data);

            return res_img;
        }

        public static Bitmap GlobalThresholding(Bitmap image, int threshold)
        {
            // Check if threshold is within valid range (0 to 255)
            threshold = Math.Max(0, Math.Min(255, threshold));

            int width = image.Width;
            int height = image.Height;

            BitmapData imageData = image.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite,
                PixelFormat.Format24bppRgb);

            int bytesPerPixel = 3; // 24bpp RGB format (3 bytes per pixel)
            int stride = imageData.Stride;
            int imageSize = stride * height;

            byte[] buffer = new byte[imageSize];
            byte[] resultBuffer = new byte[imageSize];

            Marshal.Copy(imageData.Scan0, buffer, 0, imageSize);

            for (int i = 0; i < imageSize; i += bytesPerPixel)
            {
                int intensity = (buffer[i] + buffer[i + 1] + buffer[i + 2]) / 3;

                byte newValue = (intensity > threshold) ? (byte)255 : (byte)0;

                resultBuffer[i] = newValue; // Red
                resultBuffer[i + 1] = newValue; // Green
                resultBuffer[i + 2] = newValue; // Blue
            }

            Marshal.Copy(resultBuffer, 0, imageData.Scan0, imageSize);

            image.UnlockBits(imageData);

            return image;
        }

        public static int[] CalculateBrightnessHistogram(Bitmap image)
        {
            //  brightness levels (0 to 255)
            int[] histogram = new int[256];
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixelColor = image.GetPixel(x, y);

                    int brightness = (int)(0.299 * pixelColor.R + 0.587 * pixelColor.G + 0.114 * pixelColor.B);

                    histogram[brightness]++;
                }
            }
            return histogram;
        }

        public static double[] CalculateInterClassVariance(Bitmap image)
        {
            Bitmap grayImage = image;
            if (Flags.imageIsGrey == false)
            {
                grayImage = preprocessing.ConvertToGrayscale(image);
            }
             
            // Step 2: Compute histogram
            int[] histogram = new int[256];
            for (int y = 0; y < grayImage.Height; y++)
            {
                for (int x = 0; x < grayImage.Width; x++)
                {
                    int pixelValue = grayImage.GetPixel(x, y).R;
                    histogram[pixelValue]++;
                }
            }

            // Step 3: Calculate inter-class variance for each threshold
            double[] interClassVariance = new double[256];
            int totalPixels = grayImage.Width * grayImage.Height;
            for (int t = 0; t < 256; t++)
            {
                double weightBackground = 0;
                double sumBackground = 0;
                double weightForeground = 0;
                double sumForeground = 0;

                for (int i = 0; i <= t; i++)
                {
                    weightBackground += histogram[i];
                    sumBackground += i * histogram[i];
                }

                for (int i = t + 1; i < 256; i++)
                {
                    weightForeground += histogram[i];
                    sumForeground += i * histogram[i];
                }

                double meanBackground = weightBackground > 0 ? sumBackground / weightBackground : 0;
                double meanForeground = weightForeground > 0 ? sumForeground / weightForeground : 0;

                weightBackground /= totalPixels;
                weightForeground /= totalPixels;

                double meanTotal = meanBackground * weightBackground + meanForeground * weightForeground;

                interClassVariance[t] = weightBackground * Math.Pow(meanBackground - meanTotal, 2) + weightForeground * Math.Pow(meanForeground - meanTotal, 2);
            }

            return interClassVariance;
        }

        public static Bitmap DoubleThresholding(Bitmap Image, double lowThreshold, double highThreshold)
        {
            int width = Image.Width;
            int height = Image.Height;

            Bitmap thresholdedImage = new Bitmap(width, height);

            BitmapData suppressedData = Image.LockBits(new Rectangle(0, 0, width, height),
                                                                 ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            BitmapData thresholdedData = thresholdedImage.LockBits(new Rectangle(0, 0, width, height),
                                                                   ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            int bytes = suppressedData.Stride * height;
            byte[] suppressedBuffer = new byte[bytes];
            byte[] thresholdedBuffer = new byte[bytes];

            Marshal.Copy(suppressedData.Scan0, suppressedBuffer, 0, bytes);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int byteOffset = y * suppressedData.Stride + x * 3;
                    double magnitude = suppressedBuffer[byteOffset];  // Assume single channel after suppression

                    if (magnitude >= highThreshold)
                    {
                        thresholdedBuffer[byteOffset] = 255;       // Strong edge
                        thresholdedBuffer[byteOffset + 1] = 255;
                        thresholdedBuffer[byteOffset + 2] = 255;
                    }
                    else if (magnitude >= lowThreshold)
                    {
                        thresholdedBuffer[byteOffset] = 128;       // Weak edge
                        thresholdedBuffer[byteOffset + 1] = 128;
                        thresholdedBuffer[byteOffset + 2] = 128;
                    }
                    else
                    {
                        thresholdedBuffer[byteOffset] = 0;         // Non-edge
                        thresholdedBuffer[byteOffset + 1] = 0;
                        thresholdedBuffer[byteOffset + 2] = 0;
                    }
                }
            }

            Marshal.Copy(thresholdedBuffer, 0, thresholdedData.Scan0, bytes);
            Image.UnlockBits(suppressedData);
            thresholdedImage.UnlockBits(thresholdedData);

            return thresholdedImage;
        }


        

    }
}
