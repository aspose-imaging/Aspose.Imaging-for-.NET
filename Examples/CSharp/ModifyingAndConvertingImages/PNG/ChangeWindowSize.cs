using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Png;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.ModifyingAndConvertingImages.PNG
{
    class ChangeWindowSize
    {
        public static void Run()
        {
            // ExStart: ChangeWindowSize
            string dataDir = RunExamples.GetDataDir_PNG();
            string sourceFile = @"test.png";
            string outputFile = "result.png";
            using (PngImage image = (PngImage)Image.Load(dataDir + sourceFile))
            {
                image.BinarizeBradley(10, 20);
                image.Save(dataDir + outputFile);
            }
            // ExEnd: ChangeWindowSize
        }
    }
}