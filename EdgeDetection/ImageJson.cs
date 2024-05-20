using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class ImageJson
{
    public string ImageBase64 { get; set; }

    public static string CreateImageJson(string base64String)
    {
        var imageJson = new ImageJson { ImageBase64 = base64String };
        return JsonConvert.SerializeObject(imageJson);
    }
}
