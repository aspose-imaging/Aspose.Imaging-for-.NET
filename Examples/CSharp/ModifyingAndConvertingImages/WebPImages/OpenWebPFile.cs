using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Webp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.WebPImages
{
    class OpenWebPFile
    {
        public static void Run()
        {
            Console.WriteLine("Running example OpenWebPFile");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_WebPImages();

            string inputFile = Path.Combine(dataDir, "Animation1.webp");
            string outputFile = Path.Combine(dataDir, "Animation2.webp");
            using (MemoryStream ms = new MemoryStream())
            {
                using (WebPImage image = (WebPImage)Image.Load(inputFile))
                {
                    image.Resize(300, 450, ResizeType.HighQualityResample);
                    image.Crop(new Rectangle(10, 10, 200, 300));
                    image.RotateFlipAll(RotateFlipType.Rotate90FlipX);
                    image.Save(ms);
                }

                using (FileStream fs = new FileStream(outputFile, FileMode.Create))
                {
                    fs.Write(ms.GetBuffer(), 0, (int)ms.Length);
                }
            }

            Console.WriteLine("Finished example OpenWebPFile");

        }
    }
}
