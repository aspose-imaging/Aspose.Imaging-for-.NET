// GIST-ID: 945f465c84ba0d8d514a22997373d261
using System;
using Aspose.Imaging.ImageOptions;

/*
This project uses the automatic package restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference 
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it, and then add its reference to this project. For any issues, questions, or suggestions, 
please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    public class GetLastModifiedDate
    {
        public static void Run()
        {
            Console.WriteLine("Running example GetLastModifiedDate");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            using (RasterImage image = (RasterImage)Image.Load(dataDir + "aspose-logo.jpg"))
            {
                // Gets the date from the file system (FileInfo).
                string modifyDate = image.GetModifyDate(true).ToString();
                Console.WriteLine("Last modify date using [FileInfo]: {0}", modifyDate);

                // Gets the date from XMP metadata when it is available; otherwise falls back to the file system.
                modifyDate = image.GetModifyDate(false).ToString();
                Console.WriteLine("Last modify date using info from [FileInfo] and XMP metadata: {0}", modifyDate);
            }

            Console.WriteLine("Finished example GetLastModifiedDate");
        }
    }
}