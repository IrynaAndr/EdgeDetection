using Newtonsoft.Json.Linq;
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

namespace EdgeDetection
{
    public partial class APIForm : Form
    {
        private Bitmap originalImage;
        public event EventHandler<Bitmap> DataSent;

        public APIForm(Bitmap image)
        {
            InitializeComponent();
            this.originalImage = image;
            mainPicture.Image = image;
        }

        private void APIForm_Load(object sender, EventArgs e)
        {

        }

        private void mainPicture_Click(object sender, EventArgs e)
        {

        }

        private string url = "http://127.0.0.1:8000"; //API endpoint
        private async void button1_Click(object sender, EventArgs e)
        {
            string base64String = ImageAPI.ConvertImageToBase64(originalImage);
            string imageJson = ImageJson.CreateImageJson(base64String);

            string urlfull = url + "/upload"; //API endpoint
            try
            {
                string responseJson = await ImageAPI.SendImageJson(imageJson, urlfull);

                JObject jsonResponse = JObject.Parse(responseJson);
                string modifiedImageBase64 = jsonResponse["ImageBase64"].ToString();

                // Convert the base64 string back to a Bitmap
                Bitmap modifiedBitmapImage = ImageAPI.ConvertBase64ToImage(modifiedImageBase64);
                ImportedPicture.Image = modifiedBitmapImage;
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
                label1.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap  resultImage = new Bitmap(ImportedPicture.Image);
            DataSent?.Invoke(this, resultImage);

            // Close the form 
            this.Close();
        }
    }
}
