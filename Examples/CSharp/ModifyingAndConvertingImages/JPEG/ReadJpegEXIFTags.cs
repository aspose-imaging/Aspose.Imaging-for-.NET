// GIST-ID: 547b7834b6efa68f5fae3ff1b4f3bd61
using System;
using Aspose.Imaging.Exif;
using Aspose.Imaging.FileFormats.Jpeg;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API when the project is built. Please see https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information.
If you prefer not to use NuGet, you can manually download Aspose.Imaging for .NET from https://releases.aspose.com/, install it, and add its reference to this project. For any issues, questions, or suggestions, please feel free to contact us at https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.JPEG
{
    class ReadJpegEXIFTags
    {
        public static void Run()
        {
            //ExStart:ReadJpegEXIFTags
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_JPEG();

            Console.WriteLine("Running example ReadJpegEXIFTags");
            using (JpegImage image = (JpegImage)Image.Load(dataDir + "aspose-logo.jpg"))
            {
                JpegExifData exifData = image.ExifData;
                Console.WriteLine("Camera Owner Name: " + exifData.CameraOwnerName);
                Console.WriteLine("Aperture Value: " + exifData.ApertureValue);
                Console.WriteLine("Orientation: " + exifData.Orientation);
                Console.WriteLine("Focal Length: " + exifData.FocalLength);
                Console.WriteLine("Compression: " + exifData.Compression);
            }

            Console.WriteLine("Finished example ReadJpegEXIFTags");
            //ExEnd:ReadJpegEXIFTags
        }      
    }
}