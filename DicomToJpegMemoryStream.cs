using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using Dicom.Imaging;

namespace DicomToJpegDLL
{
    class DicomToJpegMemoryStream
    {
        public MemoryStream Convert(string filePath)
        {
            var image = new DicomImage(filePath);
            Bitmap btm = image.RenderImage().AsClonedBitmap();

            MemoryStream ms = new MemoryStream();
            btm.Save(ms, ImageFormat.Jpeg);

            //Console.WriteLine(btm.Width);
            //Console.WriteLine(btm.Height);
            return ms;
        }
    }
}
