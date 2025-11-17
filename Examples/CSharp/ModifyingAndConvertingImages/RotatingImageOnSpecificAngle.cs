// GIST-ID: afd33a28f500132c0c0c5305a13868f0
/*
This project uses the Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API references when the project is built.
Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information.
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/,
install it, and then add its reference to this project. For any issues, questions, or suggestions,
please feel free to contact us using https://forum.aspose.com/
*/

using System;
namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    class RotatingImageOnSpecificAngle
    {
        public static void Run()
        {
            Console.WriteLine("Running example RotatingImageOnSpecificAngle");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Load an image to be rotated into an instance of RasterImage.
            using (RasterImage image = (RasterImage)Image.Load(dataDir + "aspose-logo.jpg"))
            {
                // Before rotation, the image should be cached for better performance.
                if (!image.IsCached)
                {
                    image.CacheData();
                }
                // Perform the rotation by 20 degrees while keeping the image size proportional,
                // using a red background color, and save the result to a new file.
                image.Rotate(20f, true, Color.Red);
                image.Save(dataDir + "RotatingImageOnSpecificAngle_out.jpg");
            }

            Console.WriteLine("Finished example RotatingImageOnSpecificAngle");
        }
    }
}