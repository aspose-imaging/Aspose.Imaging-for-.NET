using Aspose.Imaging.FileFormats.Dicom;
using Aspose.Imaging.ImageOptions;
using System;
using System.IO;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API references 
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it, and then add its reference to this project. For any issues, questions, or suggestions 
please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.DICOM
{
    class BinarizationWithBradleysAdaptiveThreshold
    {
        public static void Run()
        {
            //ExStart:BinarizationWithBradleysAdaptiveThreshold
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DICOM();
            string inputFile = dataDir + "image.dcm";

            Console.WriteLine("Running example BinarizationWithBradleysAdaptiveThreshold");
            using (var fileStream = new FileStream(dataDir + "file.dcm", FileMode.Open, FileAccess.Read))
            using (DicomImage image = new DicomImage(fileStream))
            {
                // Binarize image with Bradley's adaptive threshold and save the resultant image.
                image.BinarizeBradley(10);
                image.Save(dataDir + "BinarizationWithBradleysAdaptiveThreshold_out.bmp", new BmpOptions());
            }

            Console.WriteLine("Finished example BinarizationWithBradleysAdaptiveThreshold");
            //ExEnd:BinarizationWithBradleysAdaptiveThreshold
        }
    }
}