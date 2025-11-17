// GIST-ID: 3790cc3ee64ca2753d0e89f3f94fe2c2
using Aspose.Imaging.FileFormats.Png;
using Aspose.Imaging.ImageOptions;
using System;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API when the project is built. 
Please see https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET from https://releases.aspose.com/, 
install it, and then add a reference to this project. For any issues, questions, or suggestions, 
please feel free to contact us at https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.PNG
{
    class ApplyFilterMethod
    {
        public static void Run()
        {
            Console.WriteLine("Running example ApplyFilterMethod");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_PNG();

            using (PngImage png = (PngImage)Image.Load(dataDir + "aspose_logo.png"))
            {
                // Create an instance of PngOptions, set the PNG filter method, and save changes to the disk.
                PngOptions options = new PngOptions();
                options.FilterType = PngFilterType.Paeth;
                png.Save(dataDir + "ApplyFilterMethod_out.png", options);
            }

            Console.WriteLine("Finished example ApplyFilterMethod");
        }
    }
}