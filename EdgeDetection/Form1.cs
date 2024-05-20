using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;
using Button = System.Windows.Forms.Button;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;

namespace EdgeDetection
{
    public partial class Form1 : Form
    {
        private Bitmap originalImage; // Store the original image
        private Bitmap displayedImage; // Store the image currently displayed in PictureBox
        public Form1()
        {
            InitializeComponent();

            LoadToolTips();
            LoadImages();
            LoadTextBoxValidation();
            // Assign the same Click event handler to multiple PictureBox controls
            pictureBox1.Click += PictureBox_Click;
            pictureBox2.Click += PictureBox_Click;
            pictureBox3.Click += PictureBox_Click;
            pictureBox4.Click += PictureBox_Click;
            pictureBox5.Click += PictureBox_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string selectedImagePath = openFileDialog.FileName;
                    // Load the selected image into a Bitmap
                    Bitmap image = new Bitmap(selectedImagePath);

                    mainPicture.Image = image;
                    pictureBox1.Image = image;
                    mainPicture.SizeMode = PictureBoxSizeMode.Zoom; // Optional: Adjust the image display mode
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadToolTips()
        {
            pictureBox_questionMark1.Image = Properties.Resources.question_mark;
            toolTip1.SetToolTip(pictureBox_questionMark1, " Adaptive thresholding techniques adjust the threshold value for each pixel\n based " +
                "on local image properties such as local mean or local standard deviation.\n" +
                "   Parameter 'a' controls the contribution of the local standard deviation.\n Higher value equals more influence.\n" +
                "   Parameter 'b' controls the contribution of the global mean to the threshold calculation.\n" +
                "A higher value of b means more influence of the global mean on the threshold.");
            pictureBoxEyeSobel33.Image = Properties.Resources.eye;
            toolTip1.SetToolTip(pictureBoxEyeSobel33,
                "[-1, 0, 1]     [-1, -2, -1]\n" +
                "[-2, 0, 2]     [ 0,  0,  0]\n" +
                "[-1, 0, 1]     [ 1,  2,  1]\n");
            pictureBoxEyeSobel55.Image = Properties.Resources.eye;
            toolTip1.SetToolTip(pictureBoxEyeSobel55,
                "[-1, -2, 0, 2, 1]     [-1,-4,-6, -4,-1]\n" +
                "[-4, -8, 0, 8, 4]     [-2,-8,-12,-8,-2]\n" +
                "[-6,-12,0, 12,6]     [ 0, 0, 0,  0, 0]\n" +
                "[-4, -8, 0, 8, 4]     [ 2, 8, 12, 8, 2]\n" +
                "[-1, -2, 0, 2, 1]     [ 1, 4, 6,  4, 1]\n" +
                "");
            pictureBoxEyePrewitt.Image = Properties.Resources.eye;
            toolTip1.SetToolTip(pictureBoxEyePrewitt,
                "[-1, 0, 1]     [-1, -1, -1]\n" +
                "[-1, 0, 1]     [ 0,  0,  0]\n" +
                "[-1, 0, 1]     [ 1,  1,  1]\n");
            pictureBoxEye1.Image = Properties.Resources.eye;
            toolTip1.SetToolTip(pictureBoxEye1,
                "[ 0, -1,  0]\n" +
                "[-1,  5, -1]\n" +
                "[ 0, -1,  0]\n");
            pictureBoxEye2.Image = Properties.Resources.eye;
            toolTip1.SetToolTip(pictureBoxEye2,
                "[ 1, 4, 6,  4, 1]\n" +
                "[ 4,16, 24, 16,4]\n" +
                "[ 6,24,-476, 24,6]   * -1/256\n" +
                "[ 4,16, 24, 16,4]\n" +
                "[ 1, 4, 6,  4, 1]");
            pictureBoxEye3.Image = Properties.Resources.eye;
            toolTip1.SetToolTip(pictureBoxEye3,
                "[ 1,  2,  1]\n" +
                "[ 2,  4,  2]   * 1/16\n" +
                "[ 1,  2,  1]\n");
            pictureBoxEye4.Image = Properties.Resources.eye;
            toolTip1.SetToolTip(pictureBoxEye2,
                "[ 1, 4, 6,  4, 1]\n" +
                "[ 4,16, 24, 16,4]\n" +
                "[ 6,24, 36, 24,6]   * 1/256\n" +
                "[ 4,16, 24, 16,4]\n" +
                "[ 1, 4, 6,  4, 1]");
            pictureBoxEye5.Image = Properties.Resources.eye;
            toolTip1.SetToolTip(pictureBoxEye5,
                "[ 1,  1,  1]\n" +
                "[ 1,  1,  1]   * 1/9\n" +
                "[ 1,  1,  1]\n");

        }
        private void LoadImages()
        {
            try
            {
                pictureBox1.Image = Properties.Resources.boat; 
                pictureBox2.Image = Properties.Resources.flower;
                pictureBox3.Image = Properties.Resources.book_page;
                pictureBox4.Image = Properties.Resources.portrait1;
                pictureBox5.Image = Properties.Resources.portrait2;

                

                // display mode
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; 
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading images: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTextBoxValidation()
        {
            textBox1.KeyPress += TextBoxNumeric_KeyPress;
            textBox2.KeyPress += TextBoxNumeric_KeyPress;
        }

        private void TextBoxNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') && (e.KeyChar != '-') && (e.KeyChar != ',') &&
                (e.KeyChar != '\b'))
            {
                e.Handled = true; // Cancel the key press if it's not a valid character
                return;
            }
            
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            // Cast sender to PictureBox to identify which PictureBox was clicked
            PictureBox clickedPictureBox = sender as PictureBox;

            if (clickedPictureBox != null)
            {
                try
                {
                    mainPicture.Image = clickedPictureBox.Image;
                    captureResult();
                    Flags.restoreDefault();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error displaying image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        
        private void button_open_rgb_Click(object sender, EventArgs e)
        {
            if (tabControl.Visible)
            {
                button_open_thr.Text = "Threshholding";
                button_open_thr.BackColor = Color.White;
                extraFunctions.UpdateElementVisibility(tabControl, false);
            }
            else
            {
                button_open_thr.Text = "Hide panel";
                button_open_thr.BackColor = Color.DimGray;
                extraFunctions.UpdateElementVisibility(tabControl, true);
            }
        }

        private void trackBarR_Scroll(object sender, EventArgs e)
        {
            
        }

        private void trackBarG_Scroll(object sender, EventArgs e)
        {
            
        }

        private void trackBarB_Scroll(object sender, EventArgs e)
        {
            
        }

        private void captureResult()
        {
            originalImage = new Bitmap(mainPicture.Image); 
            displayedImage = new Bitmap(originalImage);
        }
        public void updateMainPicture()
        {
            mainPicture.Image = originalImage;
        }
        private void RGBUpdateImage()
        {

            //displayedImage = new Bitmap(originalImage);

            for (int y = 0; y < displayedImage.Height; y++)
            {
                for (int x = 0; x < displayedImage.Width; x++)
                {
                    Color originalColor = originalImage.GetPixel(x, y);
                    int newRed = originalColor.R + trackBarR.Value;
                    int newGreen = originalColor.G + trackBarG.Value;
                    int newBlue = originalColor.B + trackBarB.Value;

                    // Clamp RGB values to valid range (0-255)
                    newRed = Math.Max(0, Math.Min(255, newRed));
                    newGreen = Math.Max(0, Math.Min(255, newGreen));
                    newBlue = Math.Max(0, Math.Min(255, newBlue));

                    Color newColor = Color.FromArgb(newRed, newGreen, newBlue);
                    displayedImage.SetPixel(x, y, newColor);
                }
            }

            // Display the updated image in PictureBox
            mainPicture.Image = displayedImage;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            RGBUpdateImage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void RGBgroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void threshold_btn_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double a) && double.TryParse(textBox2.Text, out double b))
            {
                mainPicture.Image =  Thresholding.VariableThresholdingLocalProperties(originalImage, a, b);
            }
            else
            {
                // Parsing failed, handle invalid input
                MessageBox.Show("Invalid double input. Please enter a valid input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            Bitmap res = Thresholding.GlobalThresholding(originalImage);
            mainPicture.Image = res;
            
        }

        private void DrawHistogramChart(int[] histogram)
        {
            Bitmap chartBitmap = new Bitmap(256, 200);
            using (Graphics g = Graphics.FromImage(chartBitmap))
            {
                
                g.Clear(Color.White);

                // Determine maximum histogram value for scaling
                int maxCount = 0;
                foreach (int count in histogram)
                {
                    if (count > maxCount)
                        maxCount = count;
                }

                for (int i = 0; i < 256; i++)
                {
                    int barHeight = (int)((histogram[i] / (double)maxCount) * 200); // Scale bar height
                    g.DrawLine(Pens.Black, i, 199, i, 199 - barHeight); // Draw vertical line for bar
                }
            }

            // Display the histogram chart in the PictureBox
            histogramPictureBox.Image = chartBitmap;
            histogramPictureBox.SizeMode = PictureBoxSizeMode.Zoom;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            int[] hist = Thresholding.CalculateBrightnessHistogram(originalImage);
            DrawHistogramChart(hist);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            MessageBox.Show($"You clicked on: {selectedNode.Text}", "Node Clicked", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mainPicture_Click(object sender, EventArgs e)
        {

        }
        String fileName = "image_name";
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string selectedImagePath = openFileDialog.FileName;
                    fileName = openFileDialog.FileName;
                    // Load the selected image into a Bitmap
                    Bitmap image = new Bitmap(selectedImagePath);

                    mainPicture.Image = image;
                    pictureBox1.Image = image;
                    mainPicture.SizeMode = PictureBoxSizeMode.Zoom; // Optional: Adjust the image display mode
                    captureResult();
                    Flags.restoreDefault();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "JPEG Image|*.jpg;*.jpeg|PNG Image|*.png|Bitmap Image|*.bmp|GIF Image|*.gif";
            saveDialog.Title = "Save Image";
            saveDialog.FileName = fileName+"_ef";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = saveDialog.FileName;
                System.Drawing.Image image = mainPicture.Image;
                if (image != null)
                {
                    try
                    {
                        image.Save(filename);
                        MessageBox.Show("Image saved successfully!", "Save Image", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No image to save!", "Save Image", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        int template_current = 1; // from second slot
        private void saveToTemplatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBox[] collPictureBox = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5 };

            collPictureBox[template_current].Image = mainPicture.Image;
            template_current++;
            template_current = template_current >= 5 ? 0 : template_current;       
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            LoadImages();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void textBox_value_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox_value.Text = trackBar_value.Value.ToString();
            Bitmap copy = extraFunctions.DeepCopyBitmap(originalImage);
            Bitmap res = Thresholding.GlobalThresholding(copy, trackBar_value.Value);
            mainPicture.Image = res;
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        //make other tabs invisible - update buttons by one click
        //do the tab window in the same place
        

        private void button_open_thr_Click(object sender, EventArgs e)
        {
            if (tabControl.Visible)
            {
                button_open_thr.Text = "Threshholding";
                button_open_thr.BackColor = Color.White;
                extraFunctions.UpdateElementVisibility(tabControl, false);
            }
            else
            {
                button_open_thr.Text = "Hide panel";
                button_open_thr.BackColor = Color.DimGray;
                extraFunctions.UpdateElementVisibility(tabControl, true);
            }
        }     
        private void button4_Click_1(object sender, EventArgs e)
        {
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            //double[] variance = new double[256];
            Flags.variance = Thresholding.CalculateInterClassVariance(originalImage);
            int max_variance = extraFunctions.FindMaxElementPoistion(Flags.variance);
            label_resultOtsu.Text = "Best value: " + max_variance;
            textBox_value.Text = max_variance.ToString();
            trackBar_value.Value = max_variance;

            Bitmap resImage = Thresholding.GlobalThresholding(originalImage, trackBar_value.Value);
            mainPicture.Image = resImage;

        }

        private void convertToGreyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            originalImage = Thresholding.ConvertToGrayscale(originalImage);
            updateMainPicture();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Histogram newForm = new Histogram(originalImage, true);
            newForm.Show();
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Histogram newForm = new Histogram(originalImage);
            newForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            captureResult();
            updateMainPicture();
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            textBox3.Text = "" + trackBarBlur.Value;
            var blur = new GaussianBlur(originalImage);
            var result = blur.Process(trackBarBlur.Value);
            mainPicture.Image = result;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            originalImage = Thresholding.ConvertToGrayscale(originalImage);
            updateMainPicture();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            originalImage = KernelConvolution.applySobel(originalImage);
            updateMainPicture();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            originalImage = KernelConvolution.applyPrewitt(originalImage);
            updateMainPicture();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            originalImage = KernelConvolution.applySobel5x5(originalImage);
            updateMainPicture();
        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            originalImage = KernelConvolution.applySharpenKernel(originalImage);
            updateMainPicture();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            originalImage = KernelConvolution.applyUnsharpKernel(originalImage);
            updateMainPicture();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            originalImage = KernelConvolution.applyGaussianKernel(originalImage);
            updateMainPicture();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            originalImage = KernelConvolution.applyGaussianBlur5x5Kernel(originalImage);
            updateMainPicture();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            originalImage = KernelConvolution.applyBoxBlurKernel(originalImage);
            updateMainPicture();
        }

        private void gaussianBlur3x3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            originalImage = KernelConvolution.applyGaussianKernel(originalImage);
            updateMainPicture();
        }

        private void gaussianBlur5x5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            originalImage = KernelConvolution.applyGaussianBlur5x5Kernel(originalImage);
            updateMainPicture();
        }

        private void boxBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            originalImage = KernelConvolution.applyBoxBlurKernel(originalImage);
            updateMainPicture();
        }

        private void sharpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            originalImage = KernelConvolution.applySharpenKernel(originalImage);
            updateMainPicture();
        }

        private void unsharpMaskingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            originalImage = KernelConvolution.applyUnsharpKernel(originalImage);
            updateMainPicture();
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void pythonLibrariesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            APIForm newForm = new APIForm(originalImage);
            newForm.DataSent += ApiForm_DataSent;
            newForm.Show();
        }
        private void ApiForm_DataSent(object sender, Bitmap data)
        {
            originalImage = data;
            updateMainPicture();
        }
    }
}
