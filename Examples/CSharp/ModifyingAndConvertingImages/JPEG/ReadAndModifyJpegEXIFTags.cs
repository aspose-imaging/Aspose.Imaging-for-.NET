using System;
using System.Reflection;
using Aspose.Imaging.Exif;
using Aspose.Imaging.FileFormats.Jpeg;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference 
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download the Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it, and then add its reference to this project. For any issues, questions, or suggestions, 
please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.JPEG
{
    class ReadAndModifyJpegEXIFTags
    {
        public static void Run()
        {
            //ExStart:ReadAndModifyJpegEXIFTags
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_JPEG();

            Console.WriteLine("Running example ReadAndModifyJpegEXIFTags");
            // Load an image using the factory method Load exposed by the Image class.
            using (Image image = Image.Load(dataDir + "aspose-logo.jpg"))
            {
                // Initialize an ExifData object and fill it with the image's EXIF information. Then check if the image has any EXIF entries defined.
                ExifData exif = ((JpegImage)image).ExifData;
                if (exif != null)
                {
                    // To get all EXIF tags, first obtain the type of the EXIF object,
                    // retrieve all its properties into an array, and iterate over them.
                    Type type = exif.GetType();
                    PropertyInfo[] properties = type.GetProperties();
                    foreach (PropertyInfo property in properties)
                    {
                        // Display property name and its value.
                        Console.WriteLine(property.Name + ":" + property.GetValue(exif, null));
                    }
                }
            }

            Console.WriteLine("Finished example ReadAndModifyJpegEXIFTags");
            //ExEnd:ReadAndModifyJpegEXIFTags
        }
    }
}