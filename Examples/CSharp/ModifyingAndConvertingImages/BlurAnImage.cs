using Aspose.Imaging;
using Aspose.Imaging.ImageFilters.FilterOptions;
using System;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference 
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it, and then add its reference to this project. For any issues, questions, or suggestions, 
please feel free to contact us using https://forum.aspose.com/.
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    class BlurAnImage
    {
        public static void Run()
        {
            Console.WriteLine("Running example BlurAnImage");
            // To get proper output, please apply a valid Aspose.Imaging license. You can purchase a full license or obtain a 30‑day temporary license from https://www.aspose.com/purchase/default.aspx.
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Load the image.
            using (Image image = Image.Load(dataDir + "asposelogo.gif"))
            {
                // Convert the image to a RasterImage, pass the image bounds and a GaussianBlurFilterOptions instance to the Filter method, and save the result.
                RasterImage rasterImage = (RasterImage)image;
                rasterImage.Filter(rasterImage.Bounds, new GaussianBlurFilterOptions(5, 5));
                rasterImage.Save(dataDir + "BlurAnImage_out.gif");
            }

            Console.WriteLine("Finished example BlurAnImage");
        }
    }
}