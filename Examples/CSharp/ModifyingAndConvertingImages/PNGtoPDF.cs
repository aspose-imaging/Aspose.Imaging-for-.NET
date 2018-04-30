using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Bmp;
using Aspose.Imaging.FileFormats.Png;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.ModifyingAndConvertingImages
{
    public class PNGtoPDF
    {
        public static void Run()
        {

            //ExStart:PNGtoPDF

            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            using (PngImage image = (PngImage)Image.Load(dataDir + "test.png"))
            {
                Aspose.Imaging.ImageOptions.PdfOptions exportOptions = new Aspose.Imaging.ImageOptions.PdfOptions();
                exportOptions.PdfDocumentInfo = new Aspose.Imaging.FileFormats.Pdf.PdfDocumentInfo();
                image.Save(dataDir + "test.pdf", exportOptions);
            }
            //ExEnd:PNGtoPDF
        }
    }
}