// GIST-ID: 3b9fe73cb103afc39ab51f1154ee1b58
using System;
using Aspose.Imaging.Exif;
using Aspose.Imaging.FileFormats.Jpeg;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information.
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/,
install it, and then add its reference to this project. For any issues, questions, or suggestions,
please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.JPEG
{
    class ReadSpecificEXIFTagsInformation
    {
        public static void Run()
        {
            //ExStart:ReadSpecificEXIFTagsInformation
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_JPEG();
            Console.WriteLine("Running example ReadSpecificEXIFTagsInformation");
            // Load an image using the factory method Load exposed by the Image class.
            using (Image image = Image.Load(dataDir + "aspose-logo.jpg"))
            {
                // Initialize an object of ExifData and fill it with the image's EXIF information.
                ExifData exif = ((JpegImage)image).ExifData;

                // Check if the image has any EXIF entries defined and display a few EXIF entries.
                if (exif != null)
                {                    
                    Console.WriteLine("Exif WhiteBalance: " + exif.WhiteBalance);
                    Console.WriteLine("Exif PixelXDimension: " + exif.PixelXDimension);
                    Console.WriteLine("Exif PixelYDimension: " + exif.PixelYDimension);
                    Console.WriteLine("Exif ISOSpeed: " + exif.ISOSpeed);
                    Console.WriteLine("Exif FocalLength: " + exif.FocalLength);
                }
            }

            Console.WriteLine("Finished example ReadSpecificEXIFTagsInformation");
            //ExEnd:ReadSpecificEXIFTagsInformation
        }
    }
}