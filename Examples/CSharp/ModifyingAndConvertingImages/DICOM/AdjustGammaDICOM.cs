// GIST-ID: 65ea7da6ed4ae23c4750a05d4a44eaef
using Aspose.Imaging.FileFormats.Dicom;
using Aspose.Imaging.ImageOptions;
using System;
using System.IO;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference 
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it, and then add its reference to this project. For any issues, questions, or suggestions, 
please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.DICOM
{
    class AdjustGammaDICOM
    {
        public static void Run()
        {
            // ExStart:AdjustGammaDICOM
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DICOM();

            Console.WriteLine("Running example AdjustGammaDicom");
            using (var fileStream = new FileStream(dataDir + "file.dcm", FileMode.Open, FileAccess.Read))
            using (DicomImage image = new DicomImage(fileStream))
            {
                // Adjust the gamma, create an instance of BmpOptions for the resultant image, and save the resultant image.
                image.AdjustGamma(50);
                image.Save(dataDir + "AdjustGammaDICOM_out.bmp", new BmpOptions());
            }

            Console.WriteLine("Finished example AdjustGammaDicom");
            // ExEnd:AdjustGammaDICOM
        }
    }
}