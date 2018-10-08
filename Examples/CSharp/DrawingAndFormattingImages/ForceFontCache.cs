using System;
using System.Diagnostics;
using System.Threading;
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
    class ForceFontCache
    {
        public static void Run()
        {
            //ExStart:ForceFontCache
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_PSD();
            using (PsdImage image = (PsdImage)Image.Load(@"input.psd"))
            {
                image.Save("NoFont.psd");
            }

            Console.WriteLine("You have 2 minutes to install the font");
            Thread.Sleep(TimeSpan.FromMinutes(2));
            OpenTypeFontsCache.UpdateCache();

            using (PsdImage image = (PsdImage)Image.Load(@"input.psd"))
            {
                image.Save("HasFont.psd");
            }
            //ExEnd:ForceFontCache
        }
    }
}