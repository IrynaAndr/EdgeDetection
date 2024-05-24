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

    }
}
