using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdgeDetection
{
    public partial class Histogram : Form
    {
        private Bitmap originalImage;
        private bool ShowVariance = false;
        private int scale = 250;
        public Histogram(Bitmap image)
        {
            
            InitializeComponent();
            this.originalImage = image;
            int[] hist = Thresholding.CalculateBrightnessHistogram(originalImage);
            DrawHistogramChart(hist);
        }
        public Histogram(Bitmap image, bool showVar)
        {
            InitializeComponent();
            this.originalImage = image;
            this.ShowVariance = showVar;
            int[] hist = Thresholding.CalculateBrightnessHistogram(originalImage);
            DrawHistogramChart(hist);
        }


        private void DrawHistogramChart(int[] histogram)
        {
            Bitmap chartBitmap = new Bitmap(256, scale);
            using (Graphics g = Graphics.FromImage(chartBitmap))
            {
                g.Clear(Color.White);
                int maxCount = histogram.Max();
                for (int i = 0; i < 256; i++)
                {
                    int barHeight = (int)((histogram[i] / (double)maxCount) * scale); // Scale bar height
                    g.DrawLine(Pens.Black, i, scale-1, i, (scale - 1) - barHeight); // Draw vertical line for bar
                }
            }

            // Overlay the variance line on the histogram chart
            if (ShowVariance)
            {
                if (Flags.variance == null)
                {
                    Flags.variance = Thresholding.CalculateInterClassVariance(originalImage);
                }
                OverlayVarianceLine(chartBitmap, Flags.variance);
                label2.Visible = true;
                label2.Text += ". Highest value on " +  extraFunctions.FindMaxElementPoistion(Flags.variance);
            }

            histogramPictureBox.Image = chartBitmap;
            //histogramPictureBox.SizeMode = PictureBoxSizeMode.Zoom;

        }
        private void OverlayVarianceLine(Bitmap chartBitmap, double[] variance)
        {
            using (Graphics g = Graphics.FromImage(chartBitmap))
            {
                double maxVariance = variance.Max();
                for (int i = 0; i < 256; i++)
                {
                    int y = (int)((variance[i] / maxVariance) * scale);
                    y = chartBitmap.Height - y; 
                    g.DrawLine(Pens.Red, i, y, i, y); // Draw a single point for the variance line
                    // Optionally, draw a small vertical line to make the variance more visible
                    g.DrawLine(Pens.Red, i, y, i, y - 1);
                }
            }
        }

        private void histogramPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
