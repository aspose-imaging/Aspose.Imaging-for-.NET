using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aspose.Imaging.FileFormats.Tiff;
using Aspose.Imaging.FileFormats.Tiff.Enums;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.FileFormats.Tiff.Enums;
using Aspose.Imaging.ImageOptions;
namespace CSharp.ModifyingAndConvertingImages
{
    class SupportTiffDeflate
    {
    //ExStart:SupportTiffDeflate
     string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();
    //Export png with alpha channel to tiff
    using (Image image = Image.Load(dataDir+"Alpha.png"))
   {
    TiffOptions options = new TiffOptions(TiffExpectedFormat.TiffDeflateRgba);
    image.Save(outputFileTiff, options);
   }
 
    //Export tiff with alpha channel to png
    using (Image image = Image.Load(dataDir+"Alpha.tiff"))
   {
    Assert.AreEqual(((RasterImage)image).HasAlpha, true);
    image.Save(dataDir+"Alpha1.png", new PngOptions() { ColorType = PngColorType.TruecolorWithAlpha });
    }
   //ExEnd:SupportTiffDeflate 
   }
}
    
