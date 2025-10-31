using System;
using System.IO;
using Aspose.Imaging.FileFormats.Tiff;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference 
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it, and then add its reference to this project. For any issues, questions, or suggestions, 
please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    public class ConcatTIFFImages
    {
        public static void Run()
        {
            Console.WriteLine("Running example ConcatTIFFImages");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Create a copy of the original image to avoid any alteration.
            File.Copy(dataDir + "demo.tif", dataDir + "TestDemo.tif", true);

            // Load the copied destination image.
            using (TiffImage image = (TiffImage)Image.Load(dataDir + "TestDemo.tif"))
            {
                // Load the source image.
                using (TiffImage image1 = (TiffImage)Image.Load(dataDir + "sample.tif"))
                {
                    // Copy the active frame of the source image, add the copied frame to the destination image, and save the result.
                    TiffFrame frame = TiffFrame.CopyFrame(image1.ActiveFrame);
                    image.AddFrame(frame);
                    image.Save(dataDir + "ConcatTIFFImages_out.tiff");
                }
            }

            Console.WriteLine("Finished example ConcatTIFFImages");
        }
    }
}