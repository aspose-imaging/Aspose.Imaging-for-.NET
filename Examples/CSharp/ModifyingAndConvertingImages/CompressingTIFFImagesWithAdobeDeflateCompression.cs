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
    class CompressingTIFFImagesWithAdobeDeflateCompression
    {
        public static void Run()
        {
            Console.WriteLine("Running example CompressingTIFFImagesWithAdobeDeflateCompression");
            // To get proper output please apply a valid Aspose.Imaging License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");            
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Load an image through file path location or stream
            Image image = Image.Load(dataDir + "SampleTiff1.tiff");

            // Create an instance of TiffOptions for the resultant image
            TiffOptions outputSettings = new TiffOptions(TiffExpectedFormat.Default);

            // Set BitsPerSample, Photometric mode & Compression mode
            outputSettings.BitsPerSample = new ushort[] { 4 };
            outputSettings.Compression = TiffCompressions.AdobeDeflate;
            outputSettings.Photometric = TiffPhotometrics.Palette;

            // Set graycale palette
            outputSettings.Palette = ColorPaletteHelper.Create4BitGrayscale(false);

            Console.WriteLine("Finished example CompressingTIFFImagesWithAdobeDeflateCompression");
        }
    }
}

