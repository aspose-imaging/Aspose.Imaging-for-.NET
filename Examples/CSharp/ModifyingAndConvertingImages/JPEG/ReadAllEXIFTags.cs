using System;
using System.Reflection;
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
    class ReadAllEXIFTags
    {
        public static void Run()
        {
            // ExStart:ReadAllEXIFTags
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_JPEG();

            using (JpegImage image = (JpegImage)Image.Load(dataDir + "aspose-logo.jpg"))
            {
                JpegExifData exifData = image.ExifData;
                Type type = exifData.GetType();
                PropertyInfo[] properties = type.GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    Console.WriteLine(property.Name + ":" + property.GetValue(exifData, null));
                }
            }
        }
        // ExEnd:ReadAllEXIFTags
    }
}