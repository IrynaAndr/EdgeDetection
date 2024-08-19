using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace EdgeDetection
{
    internal class KernelConvolution
    {

        public static double[,] sobelX = new double[3, 3]
        {
            { -1, 0, 1 },
            { -2, 0, 2 },
            { -1, 0, 1 }
        };

        public static double[,] sobelY = new double[3, 3]
        {
            { -1, -2, -1 },
            {  0,  0,  0 },
            {  1,  2,  1 }
        };

        // Prewitt kernels
        public static double[,] prewittX = new double[3, 3]
        {
            { -1, 0, 1 },
            { -1, 0, 1 },
            { -1, 0, 1 }
        };

        public static double[,] prewittY = new double[3, 3]
        {
            { -1, -1, -1 },
            {  0,  0,  0 },
            {  1,  1,  1 }
        };

        //Scharr kernels:
        public static double[,] ScharrX = new double[3, 3]
        {
            { 3, 0, -3 },
            { 10, 0, -10},
            { 3, 0, -3 }
        };

        public static double[,] ScharrY = new double[3, 3]
        {
            { 3, 10, 3 },
            {  0,  0,  0 },
            {  -3,  -10,  -3 }
        };
        //RobertCross kernels:
        public static double[,] RobertCrossX = new double[2, 2]
        {
            { 1, 0},
            { 0, -1 }
        };

        public static double[,] RobertCrossY = new double[2, 2]
        {
             { 0, 1},
            { -1, 0 }
        };

        public static double[,] sobelX5x5 = new double[5, 5]
        {
            { -1, -2, 0, 2, 1 },
            { -4, -8, 0, 8, 4 },
            { -6, -12, 0, 12, 6 },
            { -4, -8, 0, 8, 4 },
            { -1, -2, 0, 2, 1 }
        };

        public static double[,] sobelY5x5 = new double[5, 5]
        {
            { -1, -4, -6, -4, -1 },
            { -2, -8, -12, -8, -2 },
            { 0, 0, 0, 0, 0 },
            { 2, 8, 12, 8, 2 },
            { 1, 4, 6, 4, 1 }
        };

        public static Bitmap ApplyDoubleConvolutionFilter(Bitmap sourceBitmap, double[,] xKernel, double[,] yKernel)
        {
            int width = sourceBitmap.Width;
            int height = sourceBitmap.Height;
            int kernelWidth = xKernel.GetLength(1);
            int kernelHeight = xKernel.GetLength(0);
            int kernelOffset = kernelWidth / 2;

            BitmapData sourceData = sourceBitmap.LockBits(new Rectangle(0, 0, width, height),
                                                          ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            byte[] pixelBuffer = new byte[sourceData.Stride * height];
            byte[] resultBuffer = new byte[sourceData.Stride * height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);
            sourceBitmap.UnlockBits(sourceData);

            for (int y = kernelOffset; y < height - kernelOffset; y++)
            {
                for (int x = kernelOffset; x < width - kernelOffset; x++)
                {
                    double blueX = 0.0, greenX = 0.0, redX = 0.0;
                    double blueY = 0.0, greenY = 0.0, redY = 0.0;

                    int byteOffset = y * sourceData.Stride + x * 3;

                    for (int filterY = -kernelOffset; filterY <= kernelOffset; filterY++)
                    {
                        for (int filterX = -kernelOffset; filterX <= kernelOffset; filterX++)
                        {
                            int calcOffset = byteOffset + (filterX * 3) + (filterY * sourceData.Stride);

                            blueX += pixelBuffer[calcOffset] * xKernel[filterY + kernelOffset, filterX + kernelOffset];
                            greenX += pixelBuffer[calcOffset + 1] * xKernel[filterY + kernelOffset, filterX + kernelOffset];
                            redX += pixelBuffer[calcOffset + 2] * xKernel[filterY + kernelOffset, filterX + kernelOffset];

                            blueY += pixelBuffer[calcOffset] * yKernel[filterY + kernelOffset, filterX + kernelOffset];
                            greenY += pixelBuffer[calcOffset + 1] * yKernel[filterY + kernelOffset, filterX + kernelOffset];
                            redY += pixelBuffer[calcOffset + 2] * yKernel[filterY + kernelOffset, filterX + kernelOffset];
                        }
                    }

                    double blue = Math.Sqrt((blueX * blueX) + (blueY * blueY));
                    double green = Math.Sqrt((greenX * greenX) + (greenY * greenY));
                    double red = Math.Sqrt((redX * redX) + (redY * redY));

                    resultBuffer[byteOffset] = ClipByte(blue);
                    resultBuffer[byteOffset + 1] = ClipByte(green);
                    resultBuffer[byteOffset + 2] = ClipByte(red);
                }
            }

            Bitmap resultBitmap = new Bitmap(width, height);
            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0, width, height),
                                                          ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
            Marshal.Copy(resultBuffer, 0, resultData.Scan0, resultBuffer.Length);
            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }

        public static Bitmap ApplyDoubleConvolutionFilter(Bitmap sourceBitmap, double[,] xKernel, double[,] yKernel, double threshold)
        {
            int width = sourceBitmap.Width;
            int height = sourceBitmap.Height;
            int kernelWidth = xKernel.GetLength(1);
            int kernelHeight = xKernel.GetLength(0);
            int kernelOffset = kernelWidth / 2;
            Bitmap grayscaleBitmap = sourceBitmap;

            if (Flags.imageIsGrey == false)
            {
                grayscaleBitmap = preprocessing.ConvertToGrayscale(sourceBitmap);
            }

            BitmapData sourceData = grayscaleBitmap.LockBits(new Rectangle(0, 0, width, height),
                                                             ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            byte[] pixelBuffer = new byte[sourceData.Stride * height];
            byte[] resultBuffer = new byte[sourceData.Stride * height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);
            grayscaleBitmap.UnlockBits(sourceData);

            for (int y = kernelOffset; y < height - kernelOffset; y++)
            {
                for (int x = kernelOffset; x < width - kernelOffset; x++)
                {
                    double intensityX = 0.0;
                    double intensityY = 0.0;

                    int byteOffset = y * sourceData.Stride + x * 3;

                    for (int filterY = -kernelOffset; filterY <= kernelOffset; filterY++)
                    {
                        for (int filterX = -kernelOffset; filterX <= kernelOffset; filterX++)
                        {
                            int calcOffset = byteOffset + (filterX * 3) + (filterY * sourceData.Stride);

                            intensityX += pixelBuffer[calcOffset] * xKernel[filterY + kernelOffset, filterX + kernelOffset];
                            intensityY += pixelBuffer[calcOffset] * yKernel[filterY + kernelOffset, filterX + kernelOffset];
                        }
                    }

                    double intensity = Math.Sqrt((intensityX * intensityX) + (intensityY * intensityY));

                    if (intensity > threshold)
                    {
                        resultBuffer[byteOffset] = ClipByte(intensity);
                        resultBuffer[byteOffset + 1] = ClipByte(intensity);
                        resultBuffer[byteOffset + 2] = ClipByte(intensity);
                    }
                    else
                    {
                        resultBuffer[byteOffset] = 0;
                        resultBuffer[byteOffset + 1] = 0;
                        resultBuffer[byteOffset + 2] = 0;
                    }
                }
            }

            Bitmap resultBitmap = new Bitmap(width, height);
            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0, width, height),
                                                          ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
            Marshal.Copy(resultBuffer, 0, resultData.Scan0, resultBuffer.Length);
            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }

        

        private static byte ClipByte(double color)
        {
            return (byte)(color > 255 ? 255 : (color < 0 ? 0 : color));
        }

        public static Bitmap applySobel(Bitmap image)
        {
            Bitmap sobelResultBitmap = ApplyDoubleConvolutionFilter(image, sobelX, sobelY);
            return sobelResultBitmap;
        }
        public static Bitmap applySobel5x5(Bitmap image)
        {
            Bitmap prewittResultBitmap = ApplyDoubleConvolutionFilter(image, sobelX5x5, sobelY5x5);
            return prewittResultBitmap;
        }

        public static Bitmap applyPrewitt(Bitmap image)
        {
            Bitmap prewittResultBitmap = ApplyDoubleConvolutionFilter(image, prewittX, prewittY);
            return prewittResultBitmap;
        }

        public static Bitmap applyScharr(Bitmap image)
        {
            Bitmap prewittResultBitmap = ApplyDoubleConvolutionFilter(image, ScharrX, ScharrY);
            return prewittResultBitmap;
        }

        public static Bitmap applyRobertCross(Bitmap image)
        {
            Bitmap prewittResultBitmap = ApplyDoubleConvolutionFilter(image, RobertCrossX, RobertCrossY);
            return prewittResultBitmap;
        }

        public static Bitmap ApplySingleKernelConvolution(Bitmap sourceBitmap, double[,] kernel)
        {
            int width = sourceBitmap.Width;
            int height = sourceBitmap.Height;
            int kernelWidth = kernel.GetLength(1);
            int kernelOffset = kernelWidth / 2;

            BitmapData sourceData = sourceBitmap.LockBits(new Rectangle(0, 0, width, height),
                                                          ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            byte[] pixelBuffer = new byte[sourceData.Stride * height];
            byte[] resultBuffer = new byte[sourceData.Stride * height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);
            sourceBitmap.UnlockBits(sourceData);

            for (int y = kernelOffset; y < height - kernelOffset; y++)
            {
                for (int x = kernelOffset; x < width - kernelOffset; x++)
                {
                    double blue = 0.0, green = 0.0, red = 0.0;

                    int byteOffset = y * sourceData.Stride + x * 3;

                    for (int filterY = -kernelOffset; filterY <= kernelOffset; filterY++)
                    {
                        for (int filterX = -kernelOffset; filterX <= kernelOffset; filterX++)
                        {
                            int calcOffset = byteOffset + (filterX * 3) + (filterY * sourceData.Stride);

                            blue += pixelBuffer[calcOffset] * kernel[filterY + kernelOffset, filterX + kernelOffset];
                            green += pixelBuffer[calcOffset + 1] * kernel[filterY + kernelOffset, filterX + kernelOffset];
                            red += pixelBuffer[calcOffset + 2] * kernel[filterY + kernelOffset, filterX + kernelOffset];
                        }
                    }

                    resultBuffer[byteOffset] = ClipByte(blue);
                    resultBuffer[byteOffset + 1] = ClipByte(green);
                    resultBuffer[byteOffset + 2] = ClipByte(red);
                }
            }

            Bitmap resultBitmap = new Bitmap(width, height);
            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0, width, height),
                                                          ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
            Marshal.Copy(resultBuffer, 0, resultData.Scan0, resultBuffer.Length);
            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }

        public static double[,] NormalizeKernel(double[,] kernel, double coef)
        {
            double[,] kernelcopy = new double[kernel.GetLength(0),kernel.GetLength(1)];

            for (int i = 0; i < kernel.GetLength(0); i++)
            {
                for (int j = 0; j < kernel.GetLength(1); j++)
                {
                    kernelcopy[i,j] = kernel[i,j];
                    kernelcopy[i, j] /= coef;
                }
            }
            return kernelcopy;
        }

        public static double[,] sharpenKernel = new double[3, 3]
            {
                { 0, -1, 0 },
                { -1, 5, -1 },
                { 0, -1, 0 }
            };

        public static Bitmap applySharpenKernel(Bitmap image)
        {
            Bitmap prewittResultBitmap = ApplySingleKernelConvolution(image, sharpenKernel);
            return prewittResultBitmap;
        }



        public static double[,] gaussianKernel = new double[3, 3]
           {
                { 1, 2, 1 },
                { 2, 4, 2 },
                { 1, 2, 1 }
           };
        public static Bitmap applyGaussianKernel(Bitmap image)
        {
            double[,] normKernel = NormalizeKernel(gaussianKernel, 16.0); //coef is 1/16
            Bitmap prewittResultBitmap = ApplySingleKernelConvolution(image, normKernel);
            return prewittResultBitmap;
        }

        public static double[,] boxBlurKernel = new double[3, 3]
            {
                { 1, 1, 1 },
                { 1, 1, 1 },
                { 1, 1, 1 }
            };
        public static Bitmap applyBoxBlurKernel(Bitmap image)
        {
            double[,] normKernel = NormalizeKernel(boxBlurKernel, 9.0);//coef is 1/9
            Bitmap prewittResultBitmap = ApplySingleKernelConvolution(image,normKernel);
            return prewittResultBitmap;
        }
        public static double[,] biggerGaussinKernel = new double[5, 5]
            {
                { 1, 4, 6, 4, 1 },
                { 4, 16, 24 ,16,4},
                { 6, 24, 36, 24,6 },
                { 4, 16, 24 ,16,4},
                { 1, 4, 6, 4, 1 }
            };

        public static Bitmap applyGaussianBlur5x5Kernel(Bitmap image)
        {
            double[,] normKernel = NormalizeKernel(biggerGaussinKernel, 256.0);//coef is 1/256
            Bitmap prewittResultBitmap = ApplySingleKernelConvolution(image, normKernel);
            return prewittResultBitmap;
        }

        public static double[,] UnsharpKernel = new double[5, 5]
            {
                { 1, 4, 6, 4, 1 },
                { 4, 16, 24 ,16,4},
                { 6, 24, -476, 24,6 },
                { 4, 16, 24 ,16,4},
                { 1, 4, 6, 4, 1 }
            };
        public static Bitmap applyUnsharpKernel(Bitmap image)
        {
            double[,] normKernel = NormalizeKernel(UnsharpKernel, -256.0);//coef is -1/256
            Bitmap prewittResultBitmap = ApplySingleKernelConvolution(image, normKernel);
            return prewittResultBitmap;
        }

        public static double[,] laplacianKernel = {
            { 0, 1, 0 },
            { 1,-4, 1 },
            { 0, 1, 0 }
        };
        
        public static Bitmap applyLaplacian(Bitmap image)
        {
            if (Flags.imageIsGrey == false)
            {
                image = preprocessing.ConvertToGrayscale(image);
            }
            Bitmap lapalcianResultBitmap = ApplySingleKernelConvolution(image, laplacianKernel);
            return lapalcianResultBitmap;
        }
        
    }
}
