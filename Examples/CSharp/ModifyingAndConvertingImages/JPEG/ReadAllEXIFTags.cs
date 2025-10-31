using System;
using System.Reflection;
using Aspose.Imaging;
using Aspose.Imaging.Exif;
using Aspose.Imaging.FileFormats.Jpeg;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API
when the project is built. Please see https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more
information. If you prefer not to use NuGet, you can manually download Aspose.Imaging for .NET API from
https://releases.aspose.com/, install it, and then add its reference to this project. For any issues,
questions, or suggestions, feel free to contact us at https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.JPEG
{
    class ReadAllEXIFTags
    {
        public static void Run()
        {
            //ExStart:ReadAllEXIFTags
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_JPEG();

            Console.WriteLine("Running example ReadAllEXIFTags");
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

            Console.WriteLine("Finished example ReadAllEXIFTags");
            //ExEnd:ReadAllEXIFTags
        }
    }
}