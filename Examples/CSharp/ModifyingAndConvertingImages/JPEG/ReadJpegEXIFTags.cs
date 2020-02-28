﻿using System;
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