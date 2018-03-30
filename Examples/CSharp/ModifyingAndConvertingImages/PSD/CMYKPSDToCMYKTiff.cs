using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using Aspose.Imaging.FileFormats.Png;
using Aspose.Imaging.FileFormats.Psd;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging;
using System.IO;
using Aspose.Imaging.FileFormats.Tiff.Enums;
namespace CSharp.ModifyingAndConvertingImages.PSD
{
    class CMYKPSDToCMYKTiff
    {

        public static void Run(string folder, bool isIccProfile)
        {
            //ExStart:CMYKPSDToCMYKTiff
            string dataDir = RunExamples.GetDataDir_PSD();
           string fileName = string.Format("cmyk_{0}.tiff", isIccProfile);
           string inputFile = Path.Combine(folder,"cmyk.psd");
           string inputIccFile = Path.Combine(folder,"JapanWebCoated.icc");
           string outputFile = Path.Combine(folder,fileName);
           using (Image image = Image.Load(inputFile))
      {
          if (isIccProfile)
      {
          using (MemoryStream ms = new MemoryStream(File.ReadAllBytes(inputIccFile)))
      {
         image.Save(outputFile, new TiffOptions(TiffExpectedFormat.TiffLzwCmyk) { IccProfile = ms });
      }
      }
     else
      {
        image.Save(outputFile, new TiffOptions(TiffExpectedFormat.TiffLzwCmyk));
      }
      }
      }
            
      //ExEnd:CMYKPSDToCMYKTiff
        }
    }
