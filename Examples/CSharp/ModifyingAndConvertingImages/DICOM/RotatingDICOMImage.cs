using Aspose.Imaging.FileFormats.Dicom;
using Aspose.Imaging.ImageOptions;
using System;
using System.IO;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information.
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, install it, and then add its reference to this project. For any issues, questions, or suggestions, please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.DICOM
{
    class RotatingDICOMImage
    {
        public static void Run()
        {
            //ExStart:RotatingDICOMImage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DICOM();

            Console.WriteLine("Running example RotatingDICOMImage");
            using (var fileStream = new FileStream(dataDir + "file.dcm", FileMode.Open, FileAccess.Read))
            using (DicomImage image = new DicomImage(fileStream))
            {
                image.Rotate(10);
                image.Save(dataDir + "RotatingDICOMImage_out.bmp", new BmpOptions());
            }

            Console.WriteLine("Finished example RotatingDICOMImage");
            //ExEnd:RotatingDICOMImage
        }
    }
}