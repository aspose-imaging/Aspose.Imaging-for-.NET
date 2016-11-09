using System;
using Aspose.Imaging.Exif;
using Aspose.Imaging.FileFormats.Jpeg;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.JPEG
{
    class ReadSpecificEXIFTagsInformation
    {
        public static void Run()
        {
            // ExStart:ReadSpecificEXIFTagsInformation
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_JPEG();

            // Load an image using the factory method Load exposed by Image class
            using (Image image = Image.Load(dataDir + "aspose-logo.jpg"))
            {
                // Initialize an object of ExifData and fill it will image's EXIF information
                ExifData exif = ((JpegImage)image).ExifData;

                // Check if image has any EXIF entries defined and Display a few EXIF entries
                if (exif != null)
                {                    
                    Console.WriteLine("Exif WhiteBalance: " + exif.WhiteBalance);
                    Console.WriteLine("Exif PixelXDimension: " + exif.PixelXDimension);
                    Console.WriteLine("Exif PixelYDimension: " + exif.PixelYDimension);
                    Console.WriteLine("Exif ISOSpeed: " + exif.ISOSpeed);
                    Console.WriteLine("Exif FocalLength: " + exif.FocalLength);
                }
            }
            // ExEnd:ReadSpecificEXIFTagsInformation
        }
    }
}

