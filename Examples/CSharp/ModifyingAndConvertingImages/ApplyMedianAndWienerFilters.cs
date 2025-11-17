// GIST-ID: 72d7ea5b661d51bb70913d7f13029d3a
using Aspose.Imaging.ImageFilters.FilterOptions;
using System;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API references when the project is built. Please see https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information.
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, install it, and then add its reference to this project. For any issues, questions, or suggestions, please feel free to contact us via https://forum.aspose.com/.
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    class ApplyMedianAndWienerFilters
    {
        public static void Run()
        {
            Console.WriteLine("Running example ApplyMedianAndWienerFilters");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Load the noisy image 
            using (Image image = Image.Load(dataDir + "asposelogo.gif"))
            {
                // Cast the image to a RasterImage
                RasterImage rasterImage = image as RasterImage;
                if (rasterImage == null)
                {
                    return;
                }

                // Create an instance of MedianFilterOptions with the desired size, apply the filter to the RasterImage, and save the resulting image
                MedianFilterOptions options = new MedianFilterOptions(4);
                rasterImage.Filter(image.Bounds, options);
                image.Save(dataDir + "median_test_denoise_out.gif");
            }

            Console.WriteLine("Finished example ApplyMedianAndWienerFilters");
        }
    }
}