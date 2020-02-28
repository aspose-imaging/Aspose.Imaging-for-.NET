using Aspose.Imaging.FileFormats.Dicom;
using Aspose.Imaging.ImageOptions;
using System;
using System.IO;
/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/


namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.DICOM
{
    class BinarizationWithOtsuThresholdOnDICOMImage
    {
        public static void Run()
        {
            //ExStart:BinarizationWithOtsuThresholdOnDICOMImage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DICOM();

            Console.WriteLine("Running example BinarizationWithOtsuThresholdOnDICOMImage");
            using (var fileStream = new FileStream(dataDir + "file.dcm", FileMode.Open, FileAccess.Read))
            using (DicomImage image = new DicomImage(fileStream))
            {
                // Binarize image with Otsu Thresholding and Save the resultant image.
                image.BinarizeOtsu();
                image.Save(dataDir + "BinarizationWithOtsuThresholdOnDICOMImage_out.bmp", new BmpOptions());
            }

            Console.WriteLine("Finished example BinarizationWithOtsuThresholdOnDICOMImage");
            //ExEnd:BinarizationWithOtsuThresholdOnDICOMImage
        }
    }
}