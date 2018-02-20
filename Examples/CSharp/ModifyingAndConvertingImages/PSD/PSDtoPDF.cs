using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aspose.Imaging.FileFormats.Png;
using Aspose.Imaging.FileFormats.Psd;
using Aspose.Imaging.ImageOptions;
namespace CSharp.ModifyingAndConvertingImages.PSD
{
    class PSDtoPDF
    {
    //ExStart:PSDtoPDF
    string dataDir = RunExamples.GetDataDir_PSD();
  //  string sourceFileName = "FromRasterImageEthalon.psd";
    //string outputfile = "result.pdf";
 
    using (Aspose.Imaging.Image image = Aspose.Imaging.Image.Load(dataDir + "samplePsd.psd"))
   {
    PsdImage psdImage = (Aspose.Imaging.FileFormats.Psd.PsdImage)image;
    PdfOptions exportOptions = new PdfOptions();
    exportOptions.PdfDocumentInfo = new Aspose.Imaging.FileFormats.Pdf.PdfDocumentInfo();
 
    psdImage.Save(outputfile, exportOptions);

      //ExEnd:PSDtoPDF
    }
    }
}
