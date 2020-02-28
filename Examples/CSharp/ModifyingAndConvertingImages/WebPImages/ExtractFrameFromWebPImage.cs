using Aspose.Imaging.FileFormats.Webp;
using Aspose.Imaging.ImageOptions;
using System;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
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

            // Load an existing WebP image into the instance of WebPImage class.
            using (WebPImage image = new WebPImage(dataDir + "asposelogo.webp"))
            {
                if (image.Pages.Length > 2)
                {
                    // Access a particular frame from WebP image and cast it to Raster Image
                    RasterImage block = (image.Pages[2] as RasterImage);

                    if (block != null)
                    {
                        // Save the Raster Image to a BMP image.
                        block.Save(dataDir + "ExtractFrameFromWebPImage.bmp", new BmpOptions());
                    }
                }
            }

            Console.WriteLine("Finished example ExtractFrameFromWebPImage");            
        }
    }
}