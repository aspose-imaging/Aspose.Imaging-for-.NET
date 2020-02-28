using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aspose.Imaging.FileFormats.Tiff;
using Aspose.Imaging.FileFormats.Tiff.Enums;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.FileFormats.Tiff.Enums;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging;
namespace CSharp.ModifyingAndConvertingImages
{
    class SupportTiffDeflate
    {
        public static void Run()
        {
            Console.WriteLine("Running example SupportTiffDeflate");
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();
            string sourceFileName = "FromRasterImageEthalon.psd";
            string outputfile = "result.tiff";

            //Export png with alpha channel to tiff
            using (Image image = Image.Load(dataDir + "sample.png"))
            {
                TiffOptions options = new TiffOptions(TiffExpectedFormat.TiffDeflateRgba);
                image.Save(outputfile, options);

            }

            Console.WriteLine("Finished example SupportTiffDeflate");
        }
    }
}