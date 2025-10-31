using Aspose.Imaging.Exif;
using Aspose.Imaging.Exif.Enums;
using Aspose.Imaging.FileFormats.Jpeg;
using System;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API references 
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it, and then add its reference to this project. For any issues, questions, or suggestions, 
please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.JPEG
{
    class WritingAndModifyingEXIFData
    {
        public static void Run()
        {
            // ExStart:WritingAndModifyingEXIFData
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_JPEG();

            Console.WriteLine("Running example WritingAndModifyingEXIFData");
            // Load an image using the factory method Load exposed by the Image class.
            using (Image image = Image.Load(dataDir + "aspose-logo.jpg"))
            {
                // Initialize an object of ExifData and fill it with the image's EXIF information.
                JpegExifData exif = ((JpegImage)image).ExifData;

                // Set LensMake, WhiteBalance, and Flash information. Save the image.
                exif.LensMake = "Sony";
                exif.WhiteBalance = ExifWhiteBalance.Auto;
                exif.Flash = ExifFlash.Fired;
                image.Save(dataDir + "aspose-logo_out.jpg");
            }

            Console.WriteLine("Finished example WritingAndModifyingEXIFData");
            // ExEnd:WritingAndModifyingEXIFData
        }
    }
}