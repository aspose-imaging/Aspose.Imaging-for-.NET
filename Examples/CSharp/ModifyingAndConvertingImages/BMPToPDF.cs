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

            //ExStart:BMPToPDF

            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();
            using (BmpImage image = (BmpImage)Image.Load(dataDir))
            {
                Aspose.Imaging.ImageOptions.PdfOptions exportOptions = new PdfOptions();
                exportOptions.PdfDocumentInfo = new Aspose.Imaging.FileFormats.Pdf.PdfDocumentInfo();

                image.Save(dataDir, exportOptions);
            }

        }
        //ExEnd:BMPToPDF
    }
}