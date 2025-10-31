using Aspose.Imaging;
using Aspose.Imaging.FileFormats.Tiff;
using Aspose.Imaging.FileFormats.Tiff.Enums;
using Aspose.Imaging.ImageOptions;
using System;

/*
This project uses the automatic package restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information.
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, install it, and then add its reference to this project. For any issues, questions, or suggestions, please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    class CreatingTIFFImageWithCompression
    {
        public static void Run()
        {
            Console.WriteLine("Running example CreatingTIFFImageWithCompression");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages() + "SavingRasterImageToTIFFWithCompression_out.tiff";

            // Create an instance of TiffOptions and set its various properties
            TiffOptions options = new TiffOptions(TiffExpectedFormat.Default);
            options.BitsPerSample = new ushort[] { 8, 8, 8 };
            options.Photometric = TiffPhotometrics.Rgb;
            options.Xresolution = new TiffRational(72);
            options.Yresolution = new TiffRational(72);
            options.ResolutionUnit = TiffResolutionUnits.Inch;
            options.PlanarConfiguration = TiffPlanarConfigs.Contiguous;

            // Set the compression to AdobeDeflate
            options.Compression = TiffCompressions.AdobeDeflate;
            
            // Or Deflate                        
            // options.Compression = TiffCompressions.Deflate;

            // Create a new TiffImage with specific size and TiffOptions settings
            using (TiffImage tiffImage = new TiffImage(new TiffFrame(options, 100, 100)))
            {
                // Loop over the pixels to set the color to red
                for (int i = 0; i < 100; i++)
                {
                    tiffImage.ActiveFrame.SetPixel(i, i, Color.Red);
                }
                // Save the resulting image
                tiffImage.Save(dataDir);
            }

            Console.WriteLine("Finished example CreatingTIFFImageWithCompression");
        }
    }
}