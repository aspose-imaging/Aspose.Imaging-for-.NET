using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.ModifyingAndConvertingImages
{
    class SupportBMPHeader
    {
        public static void Run()
        {
            //ExStart: Support BMP Header
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();
            string sourceFile = @"D:\source.bmp";

            string resultFile = @"D:\result.png";

            using (Image image = Image.Load(sourceFile))
            {
                image.Save(resultFile, new PngOptions());
            }
            //ExEnd: Support BMP Header
        }
    }
}