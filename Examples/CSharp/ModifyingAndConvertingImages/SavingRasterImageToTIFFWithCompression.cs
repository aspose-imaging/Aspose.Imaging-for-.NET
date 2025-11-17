// GIST-ID: 103b21d30e8853c2efbe6f8eae5f3ac8
using Aspose.Imaging.FileFormats.Tiff;
using Aspose.Imaging.FileFormats.Tiff.Enums;
using Aspose.Imaging.ImageOptions;
using System;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference 
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it, and then add its reference to this project. For any issues, questions, or suggestions 
please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    class SavingRasterImageToTIFFWithCompression
    {
        public static void Run()
        {
            Console.WriteLine("Running example SavingRasterImageToTIFFWithCompression");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();
            
            // Create an instance of TiffOptions and set its various properties
            TiffOptions options = new TiffOptions(TiffExpectedFormat.Default);
            options.BitsPerSample = new ushort[] { 8, 8, 8 };
            options.Photometric = TiffPhotometrics.Rgb;
            options.Xresolution = new TiffRational(72);
            options.Yresolution = new TiffRational(72);
            options.ResolutionUnit = TiffResolutionUnits.Inch;
            options.PlanarConfiguration = TiffPlanarConfigs.Contiguous;

            // Set the Compression to AdobeDeflate
            options.Compression = TiffCompressions.AdobeDeflate;            
            // Or Deflate         
            // options.Compression = TiffCompressions.Deflate;

            // Load an existing image in an instance of RasterImage
            using (RasterImage image = (RasterImage)Image.Load(dataDir + "SampleTiff1.tiff"))
            {
                // Create a new TiffImage from the RasterImage and save the resultant image while passing the instance of TiffOptions
                using (TiffImage tiffImage = new TiffImage(new TiffFrame(image)))
                {
                    tiffImage.Save(dataDir + "SavingRasterImage_out.tiff", options);
                }
            }

            Console.WriteLine("Finished example SavingRasterImageToTIFFWithCompression");
        }
    }
}