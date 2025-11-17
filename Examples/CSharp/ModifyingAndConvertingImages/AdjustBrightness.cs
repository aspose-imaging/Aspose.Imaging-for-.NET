// GIST-ID: 391daab4adf0f30b99806908c3cfc061
using System;
using Aspose.Imaging.FileFormats.Tiff.Enums;
using Aspose.Imaging.ImageOptions;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information.
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, install it, and then add its reference to this project. For any issues, questions, or suggestions, please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    class AdjustBrightness
    {
        public static void Run()
        {
            Console.WriteLine("Running example AdjustBrightness");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Load an image in an instance of Image
            using (Image image__1 = Image.Load(dataDir + Convert.ToString("aspose-logo.jpg")))
            {
                // Cast object of Image to RasterImage
                RasterImage rasterImage = (RasterImage)image__1;

                // Check if RasterImage is cached and cache RasterImage for better performance
                if (!rasterImage.IsCached)
                {                   
                    rasterImage.CacheData();
                }

                // Adjust the brightness
                rasterImage.AdjustBrightness(70);

                // Create an instance of TiffOptions for the resultant image, set various properties for the object of TiffOptions, and save the resultant image
                TiffOptions tiffOptions = new TiffOptions(TiffExpectedFormat.Default);
                tiffOptions.BitsPerSample = new ushort[] { 8, 8, 8 };
                tiffOptions.Photometric = TiffPhotometrics.Rgb;
                rasterImage.Save(dataDir + Convert.ToString("AdjustBrightness_out.tiff"), tiffOptions);
            }

            Console.WriteLine("Finished example AdjustBrightness");
        }
    }
}