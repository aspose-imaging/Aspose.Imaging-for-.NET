using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.PNG
{
    internal class Support16BitChannel64BitPng
    {
        public static void Run()
        {
            Console.WriteLine("Running example Support16BitChannel64BitPng");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_PNG();

            using (RasterImage image = (RasterImage)Image.Load(dataDir + "image0.png"))
            {
                ImageOptionsBase options = image.GetOriginalOptions();
                image.Save(dataDir + "result.png", options);
            }

            File.Delete(dataDir + "result.png");

            Console.WriteLine("Finished example Support16BitChannel64BitPng");
        }
    }
}