using System;
using Aspose.Imaging.FileFormats.Png;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Sources;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API
reference when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information.
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/,
install it, and then add its reference to this project. For any issues, questions, or suggestions,
please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.DrawingAndFormattingImages
{
    class Imagetransparency
    {
        public static void Run()
        {
            Console.WriteLine("Running example Imagetransparency");
            // The path to the documents directory.

            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            string filePath = System.IO.Path.Combine(dataDir, "sample.png"); // specify your path
            using (PngImage image = (PngImage)Image.Load(filePath))
            {
                float opacity = image.ImageOpacity; // opacity = 0.470798
                Console.WriteLine(opacity);
                if (opacity == 0)
                {
                    // The image is fully transparent.
                }

            }

            Console.WriteLine("Finished example Imagetransparency");
        }
    }
}