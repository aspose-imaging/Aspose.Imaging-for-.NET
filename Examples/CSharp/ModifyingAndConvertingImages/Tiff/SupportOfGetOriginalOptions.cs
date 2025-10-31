using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Tiff;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.Tiff
{
    class SupportOfGetOriginalOptions
    {
        public static void Run()
        {
            Console.WriteLine("Running example SupportOfGetOriginalOptions");

            var filePath = RunExamples.GetDataDir_Tiff();

            string inputFile = "lichee.tif";
            using (var image = Image.Load(Path.Combine(filePath, inputFile)))
            {
                string output1 = Path.Combine(filePath, "result1.tiff");
                string output2 = Path.Combine(filePath, "result2.tiff");
                image.Save(output1, image.GetOriginalOptions());

                TiffFrame frame = ((TiffImage)image).Frames[0];
                frame.Save(output2, frame.GetOriginalOptions());

                File.Delete(output1);
                File.Delete(output2);
            }

            Console.WriteLine("Finished example SupportOfGetOriginalOptions");
        }
    }
}