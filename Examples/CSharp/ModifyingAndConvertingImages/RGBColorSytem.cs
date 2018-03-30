using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Tiff.Enums;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.IO;

namespace CSharp.ModifyingAndConvertingImages
{
    class RGBColorSytem
    {
       public static void Run()
    {
      
       //ExStart:RGBColorSytem
      string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();
      string sourceFilePath = "testTileDeflate.tif";
      string outputFilePath = "testTileDeflate Cmyk Icc.tif";
      TiffOptions options = new TiffOptions(TiffExpectedFormat.TiffLzwCmyk);

      using (Image image = Image.Load(sourceFilePath))
      {
          image.Save(outputFilePath, options);
      }
       //ExEnd:RGBColorSytem
        }
    }
}