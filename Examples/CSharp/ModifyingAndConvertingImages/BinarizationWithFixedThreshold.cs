// GIST-ID: 5ad52a4d7d6d5df55cb1bcc7e17deaa9
/*
This project uses the Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API references 
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it, and then add its reference to this project. For any issues, questions, or suggestions, 
please feel free to contact us using https://forum.aspose.com/
*/

using System;
namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    class BinarizationWithFixedThreshold
    {
        public static void Run()
        {
            Console.WriteLine("Running example BinarizationWithFixedThreshold");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Load an image into an instance of Image
            using (Image image = Image.Load(dataDir + "aspose-logo.jpg"))
            {
                // Cast the image to RasterCachedImage and check if the image is cached                
                RasterCachedImage rasterCachedImage = (RasterCachedImage)image;
                if (!rasterCachedImage.IsCached)
                {
                    // Cache the image if it is not already cached
                    rasterCachedImage.CacheData();
                }

                // Binarize the image with a predefined fixed threshold and save the resultant image                
                rasterCachedImage.BinarizeFixed(100);
                rasterCachedImage.Save(dataDir + "BinarizationWithFixedThreshold_out.jpg");
            }

            Console.WriteLine("Finished example BinarizationWithFixedThreshold");
        }
    }
}