// GIST-ID: 980862855f978a888703f8fa18ac65dc
using Aspose.Imaging.FileFormats.Dicom;
using Aspose.Imaging.ImageOptions;
using System;
using System.IO;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API references 
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it, and then add its reference to this project. For any issues, questions, or suggestions, 
please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.DICOM
{
    class AdjustBrightnessDICOM
    {
        public static void Run()
        {
            //ExStart:AdjustBrightnessDICOM
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DICOM();

            Console.WriteLine("Running example AdjustBrightnessDicom");
            using (var fileStream = new FileStream(dataDir + "file.dcm", FileMode.Open, FileAccess.Read))
            using (DicomImage image = new DicomImage(fileStream))
            {
                // Adjust the brightness, create an instance of BmpOptions for the resulting image, and save the image
                image.AdjustBrightness(50);
                image.Save(dataDir + "AdjustBrightnessDICOM_out.bmp", new BmpOptions());
            }

            Console.WriteLine("Finished example AdjustBrightnessDicom");
            //ExEnd:AdjustBrightnessDICOM
        }
    }
}