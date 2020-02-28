using Aspose.Imaging.FileFormats.Tiff;
using Aspose.Imaging.FileFormats.Tiff.Enums;
using Aspose.Imaging.ImageOptions;
using System;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
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

            // Set the Compression to AdobeDeflate
            options.Compression = TiffCompressions.AdobeDeflate;
            
            // Or Deflate                        
            // Options.Compression = TiffCompressions.Deflate;

            // Create a new TiffImage with specific size and TiffOptions settings
            using (TiffImage tiffImage = new TiffImage(new TiffFrame(options, 100, 100)))
            {
                // Loop over the pixels to set the color to red
                for (int i = 0; i < 100; i++)
                {
                    tiffImage.ActiveFrame.SetPixel(i, i, Color.Red);
                }
                // Save resultant image
                tiffImage.Save(dataDir);
            }

            Console.WriteLine("Finished example CreatingTIFFImageWithCompression");
        }
    }
}
