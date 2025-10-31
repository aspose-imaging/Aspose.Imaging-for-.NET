using Aspose.Imaging;
using Aspose.Imaging.FileFormats.Tiff.Enums;
using Aspose.Imaging.ImageOptions;
using System;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API references 
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it, and then add its reference to this project. For any issues, questions, or suggestions, 
please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    class TiffOptionsConfiguration
    {
        public static void Run()
        {
            Console.WriteLine("Running example TiffOptionsConfiguration");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Load an image through file path location or stream.
            using (Image image = Image.Load(dataDir + "SampleTiff1.tiff"))
            {
                // Create an instance of TiffOptions while specifying the desired format. 
                // Passing TiffExpectedFormat.TiffJpegRgb will set the compression to JPEG and BitsPerPixel 
                // according to the RGB color space.
                TiffOptions options = new TiffOptions(TiffExpectedFormat.TiffJpegRgb);
                image.Save(dataDir + "SampleTiff_out.tiff", options);
            }

            Console.WriteLine("Finished example TiffOptionsConfiguration");
        }
    }
}