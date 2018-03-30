using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Png;
using Aspose.Imaging.FileFormats.Psd;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Xmp.Types.Complex.Colorant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.ModifyingAndConvertingImages.PSD
{
   
    class SupportForSubscript
    {
      public static void Run(){
        //ExStart:SupportForSubscript
        string dataDir = RunExamples.GetDataDir_PSD();
        string[] inputFiles = new string[]
    {
    "text",
    "textReverse"
    };

   foreach (string inputFile in inputFiles)
{
    
    string sourceFileName = "FromRasterImageEthalon.psd";
    using (Image image = Image.Load(dataDir + "sample.psd"))
    {
        image.Save(inputFile + ".png", new PngOptions() { ColorType = PngColorType.TruecolorWithAlpha });
    }
    }
    //ExEnd:SupportForSubscript
    }
    }
}