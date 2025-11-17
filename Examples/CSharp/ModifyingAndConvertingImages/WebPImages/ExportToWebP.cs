// GIST-ID: a0cd791be80598432be50ecdb85a04c8
using Aspose.Imaging;
using Aspose.Imaging.ImageOptions;
using System;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information.
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/,
install it, and then add its reference to this project. For any issues, questions, or suggestions,
please feel free to contact us using https://forum.aspose.com/.
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.WebPImages
{
    class ExportToWebP
    {
        public static void Run()
        {
            Console.WriteLine("Running example ExportToWebP");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_WebPImages();

            // Create an instance of the Image class.
            using (Image image = Image.Load(dataDir + "SampleImage1.bmp"))
            {
                // Create an instance of WebPOptions and set its properties.
                WebPOptions options = new WebPOptions
                {
                    Quality = 50,
                    Lossless = false
                };
                image.Save(dataDir + "ExportToWebP_out.webp", options);
            }

            Console.WriteLine("Finished example ExportToWebP");
        }
    }
}