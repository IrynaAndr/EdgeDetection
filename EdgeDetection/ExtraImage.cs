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
    public partial class ExtraImage : Form
    {
        public event EventHandler<Bitmap> DataSent;
        public ExtraImage(Bitmap image)
        {
            InitializeComponent();
            pictureBox1.Image = image;
        }
        public ExtraImage()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap resultImage = new Bitmap(pictureBox1.Image);
            DataSent?.Invoke(this, resultImage);
            this.Close();

        }
    }
}
