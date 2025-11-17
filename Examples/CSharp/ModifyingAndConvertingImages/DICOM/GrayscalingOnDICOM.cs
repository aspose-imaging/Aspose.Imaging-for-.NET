// GIST-ID: 3ebff0a0c6f60b0fbd855d7e3cd7eedd
using Aspose.Imaging.FileFormats.Dicom;
using Aspose.Imaging.ImageOptions;
using System;
using System.IO;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API references
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information.
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/,
install it, and then add its reference to this project. For any issues, questions, or suggestions,
please feel free to contact us via https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.DICOM
{
    class GrayscalingOnDICOM
    {
        public static void Run()
        {
            //ExStart:GrayscalingOnDICOM
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DICOM();

            Console.WriteLine("Running example GrayscalingOnDICOM");
            using (var fileStream = new FileStream(dataDir + "file.dcm", FileMode.Open, FileAccess.Read))
            using (DicomImage image = new DicomImage(fileStream))
            {
                // Transform the image to its grayscale representation and save the resulting image.
                image.Grayscale();
                image.Save(dataDir + "GrayscalingOnDICOM_out.bmp", new BmpOptions());
            }

            Console.WriteLine("Finished example GrayscalingOnDICOM");
            //ExEnd:GrayscalingOnDICOM
        }
    }
}