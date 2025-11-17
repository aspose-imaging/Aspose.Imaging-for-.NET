// GIST-ID: dbf48a70afb09037416f8aa3905e092a
using Aspose.Imaging;
using Aspose.Imaging.ImageFilters.FilterOptions;
using System;

/*
This project uses the automatic package restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference 
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it, and then add its reference to this project. For any issues, questions, or suggestions, 
please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    class ApplyGaussWienerFilterForColoredImage
    {
        public static void Run()
        {
            Console.WriteLine("Running example ApplyGaussWienerFilterForColoredImage");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Load the image
            using (Image image = Image.Load(dataDir + "asposelogo.gif"))
            {
                // Cast the image into RasterImage
                RasterImage rasterImage = image as RasterImage;
                if (rasterImage == null)
                {
                    return;
                }

                // Create an instance of GaussWienerFilterOptions class and set the radius size and smooth value.
                GaussWienerFilterOptions options = new GaussWienerFilterOptions(5, 1.5);
                options.Brightness = 1;

                // Apply GaussWienerFilterOptions filter to the RasterImage object and save the resultant image.
                rasterImage.Filter(image.Bounds, options);
                image.Save(dataDir + "ApplyGaussWienerFilter_out.gif");
            }

            Console.WriteLine("Finished example ApplyGaussWienerFilterForColoredImage");
        }
    }
}