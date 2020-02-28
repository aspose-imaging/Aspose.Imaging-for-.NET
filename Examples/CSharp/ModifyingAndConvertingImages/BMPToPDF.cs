using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aspose.Imaging;
using Aspose.Imaging.FileFormats.Bmp;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Examples.CSharp;

namespace CSharp.ModifyingAndConvertingImages
{
    public class BMPToPDF
    {
        public static void Run()
        {
            Console.WriteLine("Running example BMPToPDF");
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();
            using (BmpImage image = (BmpImage)Image.Load(System.IO.Path.Combine(dataDir,"sample.bmp")))
            {
                Aspose.Imaging.ImageOptions.PdfOptions exportOptions = new PdfOptions();
                exportOptions.PdfDocumentInfo = new Aspose.Imaging.FileFormats.Pdf.PdfDocumentInfo();

                image.Save(System.IO.Path.Combine(dataDir, "sample_out.pdf"), exportOptions);
            }

            Console.WriteLine("Finished example BMPToPDF");
        }        
    }
}