// GIST-ID: b13f8547b8725bbd26d11e64c2908d40
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aspose.Imaging;
using Aspose.Imaging.FileFormats.Tiff;
using Aspose.Imaging.FileFormats.Tiff.Enums;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Examples.CSharp;

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

            // Export PNG with alpha channel to TIFF
            using (Image image = Image.Load(dataDir + "sample.png"))
            {
                TiffOptions options = new TiffOptions(TiffExpectedFormat.TiffDeflateRgba);
                image.Save(outputfile, options);
            }

            Console.WriteLine("Finished example SupportTiffDeflate");
        }
    }
}