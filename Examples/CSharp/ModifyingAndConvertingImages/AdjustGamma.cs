// GIST-ID: 313a9e298e4ff7dfc9a2cd8e130a72b2
using Aspose.Imaging.FileFormats.Tiff.Enums;
using Aspose.Imaging.ImageOptions;
using System;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference when the project is built. Please see https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information.
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET from https://releases.aspose.com/, install it, and then add its reference to this project. For any issues, questions, or suggestions, please feel free to contact us via https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    class AdjustGamma
    {
        public static void Run()
        {
            Console.WriteLine("Running example AdjustGamma");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Load an image in an instance of Image.
            using (Image image = Image.Load(dataDir + "aspose-logo.jpg"))
            {
                // Cast the Image object to RasterImage.
                RasterImage rasterImage = (RasterImage)image;

                // Check if the RasterImage is cached; cache it for better performance if necessary.
                if (!rasterImage.IsCached)
                {
                    rasterImage.CacheData();
                }

                // Adjust the gamma.
                rasterImage.AdjustGamma(2.2f, 2.2f, 2.2f);

                // Create an instance of TiffOptions for the resultant image, set various properties,
                // and save the resultant image to TIFF format.
                TiffOptions tiffOptions = new TiffOptions(TiffExpectedFormat.Default);
                tiffOptions.BitsPerSample = new ushort[] { 8, 8, 8 };
                tiffOptions.Photometric = TiffPhotometrics.Rgb;
                rasterImage.Save(dataDir + "AdjustGamma_out.tiff", tiffOptions);
            }

            Console.WriteLine("Finished example AdjustGamma");
        }
    }
}