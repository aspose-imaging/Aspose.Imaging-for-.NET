using Aspose.Imaging.FileFormats.Png;
using Aspose.Imaging.ImageOptions;
using System;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information.
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/,
install it, and then add its reference to this project. For any issues, questions, or suggestions,
please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.PNG
{
    class SpecifyBitDepth
    {
        public static void Run()
        {
            Console.WriteLine("Running example SpecifyBitDepth");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_PNG();

            // Load an existing PNG image
            using (PngImage png = (PngImage)Image.Load(dataDir + "aspose_logo.png"))
            {
                // Create an instance of PngOptions, set the desired ColorType and BitDepth according to the specified ColorType, and save the image
                PngOptions options = new PngOptions();
                options.ColorType = PngColorType.Grayscale;
                options.BitDepth = 1;
                png.Save(dataDir + "SpecifyBitDepth_out.png", options);
            }

            Console.WriteLine("Finished example SpecifyBitDepth");
        }
    }
}