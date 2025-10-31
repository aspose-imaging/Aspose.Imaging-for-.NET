using Aspose.Imaging;
using Aspose.Imaging.ImageOptions;
using System;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference when the project is built. Please see https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information.
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET from https://releases.aspose.com/, install it, and then add its reference to this project.
For any issues, questions, or suggestions, please feel free to contact us via https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.WebPImages
{
    class ExportWebPToOtherImageFormats
    {
        public static void Run()
        {
            Console.WriteLine("Running example ExportWebPToOtherImageFormats");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_WebPImages();

            // Load WebP image into the instance of Image class.
            using (Image image = Image.Load(dataDir + "asposelogo.webp"))
            {
                // Save the image in BMP format.
                image.Save(dataDir + "ExportWebPToOtherImageFormats_out.bmp", new BmpOptions());
            }

            Console.WriteLine("Finished example ExportWebPToOtherImageFormats");
        }
    }
}