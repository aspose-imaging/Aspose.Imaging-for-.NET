using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Sources;
using System;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference when the project is built. Please see https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. If you prefer not to use NuGet, you can manually download Aspose.Imaging for .NET from https://releases.aspose.com/, install it, and then add its reference to this project. For any issues, questions, or suggestions, please feel free to contact us via https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.WebPImages
{
    class CreatingWebPImage
    {
        public static void Run()
        {
            Console.WriteLine("Running example CreatingWebPImage");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_WebPImages();

            // Create an instance of WebPOptions class and set properties
            WebPOptions imageOptions = new WebPOptions();
            imageOptions.Lossless = true;
            imageOptions.Source = new FileCreateSource(dataDir + "CreatingWebPImage_out.webp", false);

            // Create an instance of image class by using the WebPOptions instance that you have just created.
            using (Image image = Image.Create(imageOptions, 500, 500))
            {
                image.Save();
            }

            Console.WriteLine("Finished example CreatingWebPImage");
        }
    }
}