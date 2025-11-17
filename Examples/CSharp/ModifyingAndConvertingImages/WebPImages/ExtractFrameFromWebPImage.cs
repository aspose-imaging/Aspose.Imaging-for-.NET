// GIST-ID: 91b7d0bd82b9dd82df758039a018c9e3
using Aspose.Imaging.FileFormats.Webp;
using Aspose.Imaging.ImageOptions;
using System;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information.
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, install it, and then add its reference to this project. For any issues, questions, or suggestions, please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.WebPImages
{
    class ExtractFrameFromWebPImage
    {
        public static void Run()
        {
            Console.WriteLine("Running example ExtractFrameFromWebPImage");            
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_WebPImages();

            // Load an existing WebP image into an instance of the WebPImage class.
            using (WebPImage image = new WebPImage(dataDir + "asposelogo.webp"))
            {
                if (image.Pages.Length > 2)
                {
                    // Access a particular frame from the WebP image and cast it to a raster image.
                    RasterImage block = (image.Pages[2] as RasterImage);

                    if (block != null)
                    {
                        // Save the raster image to a BMP file.
                        block.Save(dataDir + "ExtractFrameFromWebPImage.bmp", new BmpOptions());
                    }
                }
            }

            Console.WriteLine("Finished example ExtractFrameFromWebPImage");            
        }
    }
}