// GIST-ID: 6d6b95ddb9da89ca947752715c117d3b
using System;
using Aspose.Imaging.FileFormats.Psd;
using Aspose.Imaging.ImageOptions;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API
reference when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq
for more information. If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API
from https://releases.aspose.com/, install it, and then add its reference to this project. For any issues,
questions, or suggestions, please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    public class ExportImageToPSD
    {
        public static void Run()
        {
            Console.WriteLine("Running example ExportImageToPSD");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();
           
            // Load an existing image
            using (Image image = Image.Load(dataDir + "sample.bmp"))
            {
                // Create an instance of PsdOptions and set its various properties. Save the image to disk in PSD format.
                PsdOptions psdOptions = new PsdOptions();
                psdOptions.ColorMode = ColorModes.Rgb;
                psdOptions.CompressionMethod = CompressionMethod.Raw;
                psdOptions.Version = 4;
                image.Save(dataDir + "ExportImageToPSD_output.psd", psdOptions);               
            }

            Console.WriteLine("Finished example ExportImageToPSD");
        }
    }
}