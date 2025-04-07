using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages
{
    internal class AutoAdjustImageBrightness
    {
        public static void Run()
        {
            Console.WriteLine("Running example AutoAdjustImageBrightness");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            string outputFilePath = RunExamples.GetDataDir_ModifyingAndConvertingImages() + "result.png";
            string outputFilePath2 = RunExamples.GetDataDir_ModifyingAndConvertingImages() + "result2.png";
            // Load an existing JPG image
            using (RasterImage image = (RasterImage)Image.Load(dataDir + "sample.png"))
            {
                image.NormalizeHistogram();
                image.Save(outputFilePath);
                image.AdjustContrast(30);
                image.Save(outputFilePath2);
                File.Delete(outputFilePath);
                File.Delete(outputFilePath2);
            }

            Console.WriteLine("Finished example AutoAdjustImageBrightness");
        }
    }
}
