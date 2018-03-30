using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aspose.Imaging.FileFormats.Png;
using Aspose.Imaging.FileFormats.Psd;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging;
namespace CSharp.ModifyingAndConvertingImages.PSD
{
    class PSDtoPDF
    {
   public static void Run(){
    //ExStart:PSDtoPDF
    string dataDir = RunExamples.GetDataDir_PSD();
    string sourceFileName = "FromRasterImageEthalon.psd";
    string outputfile = "result.pdf";
 
    //using (Aspose.Imaging.Image image = Aspose.Imaging.Image.Load(dataDir + "samplePsd.psd"));
     using (Image image = Image.Load(dataDir+"sample.psd"))
   {
     PsdImage psdImage = (Aspose.Imaging.FileFormats.Psd.PsdImage)image;

    //PsdImage psdImage = (Aspose.Imaging.FileFormats.Psd.PsdImage)image;
    
       
    PdfOptions exportOptions = new PdfOptions();
    exportOptions.PdfDocumentInfo = new Aspose.Imaging.FileFormats.Pdf.PdfDocumentInfo();
 
    psdImage.Save(outputfile);

      //ExEnd:PSDtoPDF
    }
    }
}
}