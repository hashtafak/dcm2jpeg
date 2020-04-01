using System;
using System.IO;
using System.Threading.Tasks;
using DicomToJpegDLL;

public class Startup
{
    #pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
    public async Task<object> Invoke(object input)
    #pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
    {
        string filePath = (string)input;
        DicomToJpegMemoryStream dcm2jpeg = new DicomToJpegMemoryStream();
        MemoryStream ms = dcm2jpeg.Convert(filePath);
        byte[] byteImage = ms.ToArray();

        // Get Base64
        var SigBase64 = Convert.ToBase64String(byteImage);
        return SigBase64;
    }
}