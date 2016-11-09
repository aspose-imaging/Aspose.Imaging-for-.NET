using System;
using Aspose.Imaging.ImageOptions;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    public class GetLastModifiedDate
    {
        public static void Run()
        {
            // ExStart:GetLastModifiedDate
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            using (RasterImage image = (RasterImage)Image.Load(dataDir + "aspose-logo.jpg"))
            {
                // Gets the date from [FileInfo]
                string modifyDate = image.GetModifyDate(true).ToString();
                Console.WriteLine("Last modify date using [FileInfo]: {0}", modifyDate);

                // Gets the date from XMP metadata of [FileInfo] as long as it's not default case
                modifyDate = image.GetModifyDate(false).ToString();
                Console.WriteLine("Last modify date using info from [FileInfo] and XMP metadata: {0}", modifyDate);
            }
            // ExEnd:GetLastModifiedDate
        }
    }
}