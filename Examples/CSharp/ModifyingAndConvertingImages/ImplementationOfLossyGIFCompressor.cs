// GIST-ID: bb0a98b09e0506d3453bcf9a2b82fe91
using System;
using Aspose.Imaging.ImageOptions;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference 
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it, and then add its reference to this project. For any issues, questions, or suggestions, 
please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    public class ImplementationOfLossyGIFCompressor
    {
        public static void Run()
        {
            // ExStart:ImplementationOfLossyGIFCompressor
            // Path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Set the maximum allowed pixel difference. If greater than zero, lossy compression will be used.
            // Recommended value for optimal lossy compression is 80. 
            // A value of 30 provides very light compression, while 200 results in heavy compression.
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