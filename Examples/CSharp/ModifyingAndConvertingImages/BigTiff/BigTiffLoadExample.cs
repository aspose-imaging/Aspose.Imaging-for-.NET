using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.BigTiff;
using Aspose.Imaging.FileFormats.Tiff.Enums;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.BigTiff
{
    internal class BigTiffLoadExample
    {
        public static void Run()
        {
            Console.WriteLine("Running example BigTiffLoadExample");
            string dataDir = RunExamples.GetDataDir_Tiff();
            string fileName = "input-BigTiff.tif";
            string inputFilePath = Path.Combine(dataDir, fileName);
            string outputFilePath = Path.Combine(dataDir, "result.tiff");

            using (var image = Image.Load(inputFilePath) as BigTiffImage)
            {
                image.Save(outputFilePath, new BigTiffOptions(TiffExpectedFormat.TiffLzwRgba));
            }

            File.Delete(outputFilePath);

            Console.WriteLine("Finished example BigTiffLoadExample");
        }
    }
}
