using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Accord.Imaging.Filters;
using Accord.Statistics.Kernels;
using Accord.Imaging;
using Accord;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace EdgeDetection
{
    internal class preprocessing
    {

        public static Bitmap ConvertToGrayscale(Bitmap original)
        {
            Bitmap grayscale = new Bitmap(original.Width, original.Height);

            using (Graphics g = Graphics.FromImage(grayscale))
            {
                ColorMatrix colorMatrix = new ColorMatrix(
                    new float[][]
                    {
                    new float[] {0.3f, 0.3f, 0.3f, 0, 0}, //r
                    new float[] {0.59f, 0.59f, 0.59f, 0, 0}, //g
                    new float[] {0.11f, 0.11f, 0.11f, 0, 0}, //b
                    new float[] {0, 0, 0, 1, 0}, //alpha
                    new float[] {0, 0, 0, 0, 1} //an additional translation term
                    });

                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(colorMatrix);

                g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height),
                            0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);
            }
            Flags.imageIsGrey = true;
            return grayscale;
        }

        /*
        public static Bitmap ConvertToGrayscale(Bitmap image)
        {
            Bitmap grayImage = new Bitmap(image.Width, image.Height);
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color originalColor = image.GetPixel(x, y);
                    int grayValue = (int)(originalColor.R * 0.3 + originalColor.G * 0.59 + originalColor.B * 0.11);
                    Color grayColor = Color.FromArgb(grayValue, grayValue, grayValue);
                    grayImage.SetPixel(x, y, grayColor);
                }
            }
            Flags.imageIsGrey = true;
            return grayImage;
        }
        */

        public static Bitmap Erode(Bitmap image, int kernelSize )
        {
            Bitmap resultBitmap = new Bitmap(image.Width, image.Height);

            for (int y = kernelSize / 2; y < image.Height - kernelSize / 2; y++)
            {
                for (int x = kernelSize / 2; x < image.Width - kernelSize / 2; x++)
                {
                    int minIntensity = 255;

                    for (int ky = -kernelSize / 2; ky <= kernelSize / 2; ky++)
                    {
                        for (int kx = -kernelSize / 2; kx <= kernelSize / 2; kx++)
                        {
                            Color neighborColor = image.GetPixel(x + kx, y + ky);
                            int intensity = neighborColor.R; // Assuming grayscale, so R=G=B

                            if (intensity < minIntensity)
                            {
                                minIntensity = intensity;
                            }
                        }
                    }

                    resultBitmap.SetPixel(x, y, Color.FromArgb(minIntensity, minIntensity, minIntensity));
                }
            }

            return resultBitmap;
        }

        public static Bitmap Dilate(Bitmap image, int kernelSize)
        {
            Bitmap resultBitmap = new Bitmap(image.Width, image.Height);

            for (int y = kernelSize / 2; y < image.Height - kernelSize / 2; y++)
            {
                for (int x = kernelSize / 2; x < image.Width - kernelSize / 2; x++)
                {
                    int maxIntensity = 0;

                    for (int ky = -kernelSize / 2; ky <= kernelSize / 2; ky++)
                    {
                        for (int kx = -kernelSize / 2; kx <= kernelSize / 2; kx++)
                        {
                            Color neighborColor = image.GetPixel(x + kx, y + ky);
                            int intensity = neighborColor.R; // Assuming grayscale, so R=G=B

                            if (intensity > maxIntensity)
                            {
                                maxIntensity = intensity;
                            }
                        }
                    }

                    resultBitmap.SetPixel(x, y, Color.FromArgb(maxIntensity, maxIntensity, maxIntensity));
                }
            }

            return resultBitmap;
        }


        //accord library
        public static Bitmap ThinningFromLibrary(Bitmap image)
        {
            Bitmap grayImage = AForge.Imaging.Filters.Grayscale.CommonAlgorithms.BT709.Apply(image);
            Bitmap convertedImage = AForge.Imaging.Image.Clone(grayImage, PixelFormat.Format8bppIndexed);
            AForge.Imaging.Image.SetGrayscalePalette(convertedImage);

            ZhangSuenSkeletonization filter = new ZhangSuenSkeletonization();
            filter.ApplyInPlace(convertedImage);

            return convertedImage;
        }
        ///
        public static Bitmap Thinning(Bitmap sourceBitmap)
        {
            // Convert the image to a binary array
            bool[,] binaryImage = ConvertToBinaryArray(sourceBitmap);

            bool pixelsRemoved;
            do
            {
                pixelsRemoved = false;

                // First sub-iteration
                for (int y = 1; y < sourceBitmap.Height - 1; y++)
                {
                    for (int x = 1; x < sourceBitmap.Width - 1; x++)
                    {
                        if (binaryImage[y, x] && ShouldRemoveFirstSubIteration(binaryImage, x, y))
                        {
                            binaryImage[y, x] = false;
                            pixelsRemoved = true;
                        }
                    }
                }

                // Second sub-iteration
                for (int y = 1; y < sourceBitmap.Height - 1; y++)
                {
                    for (int x = 1; x < sourceBitmap.Width - 1; x++)
                    {
                        if (binaryImage[y, x] && ShouldRemoveSecondSubIteration(binaryImage, x, y))
                        {
                            binaryImage[y, x] = false;
                            pixelsRemoved = true;
                        }
                    }
                }

            } while (pixelsRemoved);

            // Convert the binary array back to a bitmap
            return ConvertToBitmap(binaryImage, sourceBitmap.Width, sourceBitmap.Height);
        }

        private static bool ShouldRemoveFirstSubIteration(bool[,] image, int x, int y)
        {
            int neighborCount = CountNeighbors(image, x, y);
            int transitions = CountTransitions(image, x, y);

            bool condition1 = (neighborCount >= 2 && neighborCount <= 6);
            bool condition2 = (transitions == 1);
            bool condition3 = !(image[y - 1, x] && image[y, x + 1] && image[y + 1, x]);
            bool condition4 = !(image[y, x + 1] && image[y + 1, x] && image[y, x - 1]);

            return condition1 && condition2 && condition3 && condition4;
        }

        private static bool ShouldRemoveSecondSubIteration(bool[,] image, int x, int y)
        {
            int neighborCount = CountNeighbors(image, x, y);
            int transitions = CountTransitions(image, x, y);

            bool condition1 = (neighborCount >= 2 && neighborCount <= 6);
            bool condition2 = (transitions == 1);
            bool condition3 = !(image[y - 1, x] && image[y, x + 1] && image[y, x - 1]);
            bool condition4 = !(image[y - 1, x] && image[y + 1, x] && image[y, x - 1]);

            return condition1 && condition2 && condition3 && condition4;
        }

        private static int CountNeighbors(bool[,] image, int x, int y)
        {
            int count = 0;

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (i == 0 && j == 0) continue;
                    if (image[y + i, x + j]) count++;
                }
            }

            return count;
        }

        private static int CountTransitions(bool[,] image, int x, int y)
        {
            int count = 0;

            bool[] neighbors = new bool[8];
            neighbors[0] = image[y - 1, x];
            neighbors[1] = image[y - 1, x + 1];
            neighbors[2] = image[y, x + 1];
            neighbors[3] = image[y + 1, x + 1];
            neighbors[4] = image[y + 1, x];
            neighbors[5] = image[y + 1, x - 1];
            neighbors[6] = image[y, x - 1];
            neighbors[7] = image[y - 1, x - 1];

            for (int i = 0; i < 8; i++)
            {
                if (!neighbors[i] && neighbors[(i + 1) % 8])
                {
                    count++;
                }
            }

            return count;
        }

        private static bool[,] ConvertToBinaryArray(Bitmap sourceBitmap)
        {
            int width = sourceBitmap.Width;
            int height = sourceBitmap.Height;
            bool[,] binaryImage = new bool[height, width];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixelColor = sourceBitmap.GetPixel(x, y);
                    binaryImage[y, x] = pixelColor.R == 255;
                }
            }

            return binaryImage;
        }

        private static Bitmap ConvertToBitmap(bool[,] binaryImage, int width, int height)
        {
            Bitmap resultBitmap = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color color = binaryImage[y, x] ? Color.White : Color.Black;
                    resultBitmap.SetPixel(x, y, color);
                }
            }

            return resultBitmap;
        }
        ////// end of ZhangSuen supplementary functions

        public static Bitmap DetectHarrisCorners(Bitmap image)
        {
            //convert to greyscale if not already
            Grayscale grayscaleFilter = new Grayscale(0.2125, 0.7154, 0.0721);
            Bitmap grayImage = grayscaleFilter.Apply(image);

            HarrisCornersDetector harrisDetector = new HarrisCornersDetector( 0.04f,  5);
            List<IntPoint> corners = harrisDetector.ProcessImage(grayImage);

            using (Graphics g = Graphics.FromImage(image))
            {
                foreach (IntPoint corner in corners)
                {
                    g.FillEllipse(Brushes.Red, corner.X - 3, corner.Y - 3, 6, 6);
                }
            }
            return image;
        }

       

    }
}
