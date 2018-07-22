using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;

namespace CSharp.ModifyingAndConvertingImages.SVG
{
    class ConvOfOtherFormatsToSVG
    {
        public static void Run()
        {
            //ExStart:ConvOfOtherFormatsToSVG
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_SVG();

            using (Image image = Image.Load(dataDir+"mysvg.svg"))
            {
                using (FileStream fs = new FileStream(dataDir+"yoursvg.svg", FileMode.Create, FileAccess.ReadWrite))
                {
                    image.Save(fs);
                }
            }
            //ExEnd:ConvOfOtherFormatsToSVG
        }
    }
}
