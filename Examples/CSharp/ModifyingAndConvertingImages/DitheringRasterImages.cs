// GIST-ID: 2890e005f3d8b07752bc3ceb222d7cc8
using Aspose.Imaging.FileFormats.Jpeg;
using System;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference 
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it, and then add its reference to this project. For any issues, questions, or suggestions, 
please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    class DitheringRasterImages
    {
        public static void Run()
        {
            Console.WriteLine("Running example DitheringRasterImages");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Create an instance of JpegImage and load an image as a JpegImage.
            using (var image = (JpegImage)Image.Load(dataDir + "aspose-logo.jpg"))
            {
                // Perform Floyd‑Steinberg dithering on the current image and save the resultant image.
                image.Dither(DitheringMethod.ThresholdDithering, 4);
                image.Save(dataDir + "SampleImage_out.bmp");
            }

            Console.WriteLine("Finished example DitheringRasterImages");
        }
    }
}