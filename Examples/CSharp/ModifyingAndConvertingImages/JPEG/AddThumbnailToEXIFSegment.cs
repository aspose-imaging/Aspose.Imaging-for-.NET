using System;
using System.IO;
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
    class AddThumbnailToEXIFSegment
    {
        public static void Run()
        {
            //ExStart:AddThumbnailToEXIFSegment
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_JPEG();
            Console.WriteLine("Running example AddThumbnailToEXIFSegment");
            using (MemoryStream stream = new MemoryStream())
            {
                JpegImage thumbnailImage = new JpegImage(100, 100);
                JpegImage image = new JpegImage(1000, 1000);
                image.ExifData = new JpegExifData();
                image.ExifData.Thumbnail = thumbnailImage;
                image.Save(Path.Combine(dataDir, "AddThumbnailToEXIFSegment_out.jpg"));
            }

            Console.WriteLine("Finished example AddThumbnailToEXIFSegment");
            //ExEnd:AddThumbnailToEXIFSegment
        }
    }
}