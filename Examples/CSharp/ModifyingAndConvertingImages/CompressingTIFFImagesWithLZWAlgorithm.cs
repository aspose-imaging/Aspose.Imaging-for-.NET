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
    class CompressingTIFFImagesWithLZWAlgorithm
    {
        public static void Run()
        {
            Console.WriteLine("Running example CompressingTIFFImagesWithLZWAlgorithm");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Load an image through file path location or stream
            Image image = Image.Load(dataDir + "SampleTiff.tiff");

            // Create an instance of TiffOptions for the resultant image
            TiffOptions outputSettings = new TiffOptions(TiffExpectedFormat.Default);

            // Set BitsPerSample, Compression, Photometric mode and graycale palette
            outputSettings.BitsPerSample = new ushort[] { 4 };
            outputSettings.Compression = TiffCompressions.Lzw;
            outputSettings.Photometric = TiffPhotometrics.Palette;
            outputSettings.Palette = ColorPaletteHelper.Create4BitGrayscale(false);
            image.Save(dataDir + "SampleTiff_out.tiff", outputSettings);
            Console.WriteLine("Finished example CompressingTIFFImagesWithLZWAlgorithm");
        }
    }
}

