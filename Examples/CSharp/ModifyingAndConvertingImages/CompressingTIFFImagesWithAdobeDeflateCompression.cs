using Aspose.Imaging;
using Aspose.Imaging.FileFormats.Tiff.Enums;
using Aspose.Imaging.ImageOptions;
using System;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API
reference when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more
information. If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from
https://releases.aspose.com/, install it, and then add its reference to this project. For any issues,
questions, or suggestions, please feel free to contact us using https://forum.aspose.com/.
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    class CompressingTIFFImagesWithAdobeDeflateCompression
    {
        public static void Run()
        {
            Console.WriteLine("Running example CompressingTIFFImagesWithAdobeDeflateCompression");
            // To get proper output, please apply a valid Aspose.Imaging license. You can purchase a full license
            // or obtain a 30‑day temporary license from https://www.aspose.com/purchase/default.aspx.
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Load an image through file path location or stream
            Image image = Image.Load(dataDir + "SampleTiff1.tiff");

            // Create an instance of TiffOptions for the resultant image
            TiffOptions outputSettings = new TiffOptions(TiffExpectedFormat.Default);

            // Set BitsPerSample, Photometric mode, and Compression mode
            outputSettings.BitsPerSample = new ushort[] { 4 };
            outputSettings.Compression = TiffCompressions.AdobeDeflate;
            outputSettings.Photometric = TiffPhotometrics.Palette;

            // Set grayscale palette
            outputSettings.Palette = ColorPaletteHelper.Create4BitGrayscale(false);

            Console.WriteLine("Finished example CompressingTIFFImagesWithAdobeDeflateCompression");
        }
    }
}