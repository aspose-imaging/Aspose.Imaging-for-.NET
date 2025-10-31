using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.ICO
{
    class ConvertICOToTiff
    {
        public static void Run()
        {
            // Path to the data directory.
            string dataDir = RunExamples.GetDataDir_ICO();
            Console.WriteLine("Running example ConvertICOToTiff");

            using (var image = Image.Load(dataDir + "notebook-ico.ico"))
            {
                image.Save(dataDir + "result.tiff", new TiffOptions(Aspose.Imaging.FileFormats.Tiff.Enums.TiffExpectedFormat.Default));
            }

            File.Delete(dataDir + "result.tiff");

            Console.WriteLine("Finished example ConvertICOToTiff");
        }
    }
}