using System;
using Aspose.Imaging.ImageOptions;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    public class ImplementationOfLossyGIFCompressor
    {
        public static void Run()
        {
            // ExStart:ImplementationOfLossyGIFCompressor
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();
            // Sets the maximum allowed pixel difference. If greater than zero, lossy compression will be used.
            // Recommended value for optimal lossy compression is 80. 30 is very light compression, 200 is heavy.
            GifOptions gifExport = new GifOptions();
            gifExport.MaxDiff = 80;

            using (Image image = Image.Load("anim_orig.gif"))
            {
                image.Save("anim_lossy-80.gif", gifExport);
            }
            // ExEnd:ImplementationOfLossyGIFCompressor
        }
    }
}