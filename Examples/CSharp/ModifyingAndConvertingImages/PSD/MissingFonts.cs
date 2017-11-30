using System;
using System.Diagnostics;
using Aspose.Imaging.FileFormats.Psd;
using Aspose.Imaging.FileFormats.Psd.Layers;
using Aspose.Imaging.ImageOptions;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.PSD
{
    class MissingFonts
    {
        public static void Run()
        {
            //ExStart:MissingFonts
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_PSD();
            using (Image image = Image.Load("testReplacementNotAvailableFonts.psd", new PsdLoadOptions() { DefaultReplacementFont = "Arial" }))
            {
                PsdImage psdImage = (PsdImage)image;
                psdImage.Save(dataDir+"result.png", new PngOptions() { ColorType = PngColorType.TruecolorWithAlpha });
            }
            //ExEnd:MissingFonts
        }
    }
}