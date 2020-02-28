using Aspose.Imaging.Exif;
using Aspose.Imaging.Exif.Enums;
using Aspose.Imaging.FileFormats.Jpeg;
using System;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.JPEG
{
    class WritingAndModifyingEXIFData
    {
        public static void Run()
        {
            //ExStart:WritingAndModifyingEXIFData
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_JPEG();

            Console.WriteLine("Running example WritingAndModifyingEXIFData");
            // Load an image using the factory method Load exposed by Image class
            using (Image image = Image.Load(dataDir + "aspose-logo.jpg"))
            {
                // Initialize an object of ExifData and fill it will image's EXIF information
                JpegExifData exif = ((JpegImage)image).ExifData;

                // Set LensMake, WhiteBalance, Flash information Save the image
                exif.LensMake = "Sony";
                exif.WhiteBalance = ExifWhiteBalance.Auto;
                exif.Flash = ExifFlash.Fired;
                image.Save(dataDir + "aspose-logo_out.jpg");
            }

            Console.WriteLine("Finished example WritingAndModifyingEXIFData");
            //ExEnd:WritingAndModifyingEXIFData
        }
    }
}

