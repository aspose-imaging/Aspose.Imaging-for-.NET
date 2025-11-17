// GIST-ID: 678278a4c341c17e6447956f2e3539c1
/*
This project uses the Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API references
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information.
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/,
install it, and then add its reference to this project. For any issues, questions, or suggestions,
please feel free to contact us using https://forum.aspose.com/.
*/

using System;
namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    class Grayscaling
    {
        public static void Run()
        {
            Console.WriteLine("Running example Grayscaling");
            // To get proper output, please apply a valid Aspose.Imaging License. You can purchase a full license
            // or obtain a 30‑day temporary license from https://www.aspose.com/purchase/default.aspx.
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Load an image into an instance of Image.
            using (Image image = Image.Load(dataDir + "aspose-logo.jpg"))
            {
                // Cast the image to RasterCachedImage and check if the image is cached.
                RasterCachedImage rasterCachedImage = (RasterCachedImage)image;
                if (!rasterCachedImage.IsCached)
                {
                    // Cache image if not already cached.
                    rasterCachedImage.CacheData();
                }

                // Transform the image to its grayscale representation and save the resultant image.
                rasterCachedImage.Grayscale();
                rasterCachedImage.Save(dataDir + "Grayscaling_out.jpg");
            }

            Console.WriteLine("Finished example Grayscaling");
        }
    }
}