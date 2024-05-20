using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
//using System.Windows.Forms;

namespace EdgeDetection
{
    internal class ImageAPI
    {
        public static string ConvertImageToBase64(Bitmap bitmapImage)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                // Save the Bitmap to the MemoryStream
                bitmapImage.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                // Convert the MemoryStream to a byte array
                byte[] imageArray = memoryStream.ToArray();
                string base64ImageRepresentation = Convert.ToBase64String(imageArray);
                return base64ImageRepresentation;
            }
        }
        public static Bitmap ConvertBase64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return new Bitmap(ms);
            }
        }

        public static async Task<string> SendImageJson(string imageJson, string url)
        {
            using (HttpClient client = new HttpClient())
            {
                var content = new StringContent(imageJson, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    string responseJson = await response.Content.ReadAsStringAsync();
                    return responseJson;
                }
                else
                {
                    throw new Exception("Failed to send image JSON. Status code: " + response.StatusCode);
                }
            }
        }

    

    }
}
