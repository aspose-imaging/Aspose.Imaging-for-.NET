using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.Exif;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharp.ModifyingAndConvertingImages.DICOM
{
    internal class SupportDicomYBR422
    {
        public static void Run()
        {
            Console.WriteLine("Running example SupportDicomYBR422");

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DICOM();

            var inputPath = Path.Combine(dataDir, @"input.dcm");
            using (var image = Image.Load(inputPath))
            {
                image.Save(inputPath + ".png");
            }

            File.Delete(inputPath + ".png");

            Console.WriteLine("Finished example SupportDicomYBR422");
        }        
    }
}
