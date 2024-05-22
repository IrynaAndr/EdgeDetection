using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace EdgeDetection
{
    public partial class KernelConstructor : Form
    {
        private Bitmap originalImage;
        public event EventHandler<Bitmap> DataSent;
        private Bitmap OriginalCopy;

        public KernelConstructor(Bitmap image)
        {
            InitializeComponent();
            this.originalImage = image;
            
            OriginalCopy = extraFunctions.DeepCopyBitmap(originalImage); 
            mainPicture.Image = image;
        }


        private void mainPicture_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap resultImage = new Bitmap(mainPicture.Image);
            DataSent?.Invoke(this, resultImage);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBigGaussian_Click(object sender, EventArgs e)
        {
            FillFromKernelChosen(KernelConvolution.biggerGaussinKernel);
            textBox26.Text = "256.0";

        }

        private void buttonSharpen_Click(object sender, EventArgs e)
        {
            FillFromKernelChosen(KernelConvolution.sharpenKernel);
        }
        private void FillFromKernelChosen(double[,] kernel)
        {
            CheckForFormat(kernel);
            TextBox[,] textBox3x3Group = new TextBox[3,3] { { textBox7, textBox8, textBox9 },{ textBox12, textBox13, textBox14 },{ textBox17, textBox18, textBox19 } };
            TextBox[,] textBox5x5Group = new TextBox[5,5] { { textBox1, textBox2, textBox3, textBox4, textBox5 }, { textBox6, textBox7, textBox8, textBox9, textBox10 },{ textBox11, textBox12, textBox13, textBox14, textBox15 },{ textBox16, textBox17, textBox18, textBox19, textBox20 },{ textBox21, textBox22, textBox23, textBox24, textBox25 } };

            int length = kernel.GetLength(0);
            int width = kernel.GetLength(1);
            TextBox[,] CorrectTextBoxGroup  = length == 3 ? textBox3x3Group : textBox5x5Group;

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    CorrectTextBoxGroup[i, j].Text = kernel[i, j].ToString();
                }
            }
            textBox26.Text = "1"; //reset coef to 1. in few individual cases it will be set manually
        }


        private void CheckForFormat(double[,] kernel)
        {
            if ((kernel.GetLength(0) == 3 && textBox1.Visible) || (kernel.GetLength(0) == 5 && !textBox1.Visible))
            {
                ChangeTextBoxVisibility();
            }
        }
        private void ChangeTextBoxVisibility()
        {
            TextBox[] textBoxOnly5x5Group = new TextBox[16] {textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox10, textBox11, textBox15, textBox16, textBox20, textBox21, textBox22, textBox23, textBox24, textBox25};

            bool previousVisibility = textBox1.Visible;
            foreach (TextBox textBox in textBoxOnly5x5Group)
            {
                textBox.Visible = !previousVisibility;
            }  
        }

        private void buttonTry_Click(object sender, EventArgs e)
        {

            double [,]  myKernel = getKernelfromTextBox();
            myKernel = NormalizeKernel(myKernel);
            Bitmap copy = extraFunctions.DeepCopyBitmap(originalImage);
            Bitmap resultConvolution = KernelConvolution.ApplySingleKernelConvolution(copy, myKernel);
            mainPicture.Image = resultConvolution;

        }
        
        private double[,] getKernelfromTextBox()
        {
            double[,] result5x5= new double[5,5];
            double[,] result3x3 = new double[3, 3];
            TextBox[,] textBox3x3Group = new TextBox[3, 3] { { textBox7, textBox8, textBox9 }, { textBox12, textBox13, textBox14 }, { textBox17, textBox18, textBox19 } };
            TextBox[,] textBox5x5Group = new TextBox[5, 5] { { textBox1, textBox2, textBox3, textBox4, textBox5 }, { textBox6, textBox7, textBox8, textBox9, textBox10 }, { textBox11, textBox12, textBox13, textBox14, textBox15 }, { textBox16, textBox17, textBox18, textBox19, textBox20 }, { textBox21, textBox22, textBox23, textBox24, textBox25 } };

            TextBox[,] CorrectTextBoxGroup = textBox1.Visible ? textBox5x5Group : textBox3x3Group;
            double[,] result = textBox1.Visible ? result5x5 : result3x3;
            try
            {
                for (int i = 0; i < CorrectTextBoxGroup.GetLength(0); i++)
                {
                    for (int j = 0; j < CorrectTextBoxGroup.GetLength(0); j++)
                    {
                        result[i, j] = Convert.ToDouble(CorrectTextBoxGroup[i, j].Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("provide proper input (double)", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        private double[,] NormalizeKernel(double[,] kernel)
        {
            double coef = Convert.ToDouble(textBox26.Text);
            if (coef == 0)
            {
                MessageBox.Show("Dont divide by zero", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(coef == 1)
            {
            }
            else
            {
                kernel = KernelConvolution.NormalizeKernel(kernel, coef);
            }
            return kernel;
        }
    
        

        private void button3_Click(object sender, EventArgs e)
        {
            FillFromKernelChosen(KernelConvolution.boxBlurKernel);
            textBox26.Text = "9.0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FillFromKernelChosen(KernelConvolution.gaussianKernel);
            textBox26.Text = "16.0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FillFromKernelChosen(KernelConvolution.UnsharpKernel);
            textBox26.Text = "-256.0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FillFromKernelChosen(KernelConvolution.laplacianKernel);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FillFromKernelChosen(KernelConvolution.sobelY5x5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FillFromKernelChosen(KernelConvolution.sobelX5x5);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FillFromKernelChosen(KernelConvolution.sobelX);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FillFromKernelChosen(KernelConvolution.sobelY);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FillFromKernelChosen(KernelConvolution.prewittX);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FillFromKernelChosen(KernelConvolution.prewittX);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            originalImage = OriginalCopy;
            mainPicture.Image = originalImage;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            originalImage = new Bitmap(mainPicture.Image);
        }
    }
}
