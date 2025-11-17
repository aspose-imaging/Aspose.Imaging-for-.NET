// GIST-ID: 15c92804534b69467126ab5d829487d9
using Aspose.Imaging;
using Aspose.Imaging.FileFormats.Tiff.Enums;
using Aspose.Imaging.ImageOptions;
using System;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference when the project is built. 
Please see https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET from https://releases.aspose.com/, install it, and then add its reference to this project. 
For any issues, questions, or suggestions, please feel free to contact us via https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    class CompressingTIFFImagesWithLZWAlgorithm
    {
        public static void Run()
        {
            Console.WriteLine("Running example CompressingTIFFImagesWithLZWAlgorithm");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Load an image from a file path or stream.
            Image image = Image.Load(dataDir + "SampleTiff.tiff");

            // Create an instance of TiffOptions for the resultant image.
            TiffOptions outputSettings = new TiffOptions(TiffExpectedFormat.Default);

            // Set BitsPerSample, Compression, Photometric mode, and a grayscale palette.
            outputSettings.BitsPerSample = new ushort[] { 4 };
            outputSettings.Compression = TiffCompressions.Lzw;
            outputSettings.Photometric = TiffPhotometrics.Palette;
            outputSettings.Palette = ColorPaletteHelper.Create4BitGrayscale(false);
            image.Save(dataDir + "SampleTiff_out.tiff", outputSettings);
            Console.WriteLine("Finished example CompressingTIFFImagesWithLZWAlgorithm");
        }
    }
}