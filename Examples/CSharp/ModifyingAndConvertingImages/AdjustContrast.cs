using Aspose.Imaging.FileFormats.Tiff.Enums;
using Aspose.Imaging.ImageOptions;
using System;

/*
This project uses the automatic package restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information.
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, install it, and then add its reference to this project. For any issues, questions, or suggestions, please feel free to contact us using https://forum.aspose.com/.
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    class AdjustContrast
    {
        public static void Run()
        {
            Console.WriteLine("Running example AdjustContrast");
            // To get proper output, please apply a valid Aspose.Imaging license. You can purchase a full license or obtain a 30‑day temporary license from https://www.aspose.com/purchase/default.aspx.
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Load an image into an instance of Image.
            using (Image image = Image.Load(dataDir + "aspose-logo.jpg"))
            {
                // Cast the Image object to RasterImage.
                RasterImage rasterImage = (RasterImage)image;

                // Check if the RasterImage is cached and cache it for better performance.
                if (!rasterImage.IsCached)
                {
                    rasterImage.CacheData();
                }

                // Adjust the contrast.
                rasterImage.AdjustContrast(10);

                // Create an instance of TiffOptions for the resultant image, set various properties, and save the image to TIFF format.
                TiffOptions tiffOptions = new TiffOptions(TiffExpectedFormat.Default);
                tiffOptions.BitsPerSample = new ushort[] { 8, 8, 8 };
                tiffOptions.Photometric = TiffPhotometrics.Rgb;
                rasterImage.Save(dataDir + "AdjustContrast_out.tiff", tiffOptions);
            }

            Console.WriteLine("Finished example AdjustContrast");
        }
    }
}