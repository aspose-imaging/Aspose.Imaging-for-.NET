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
    class SupportForSmallCap
    {
        public static void Run()
        {
            //ExStart:SupportForSmallCap
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_PSD();
            using (PsdImage image = Image.Load(dataDir+"smallCap.psd") as PsdImage)
            {
                image.Save(dataDir+"smallCap.png", new PngOptions() { ColorType = PngColorType.TruecolorWithAlpha });
            }


            //ExEnd:SupportForSmallCap
        }
    }
}