using Aspose.Imaging.FileFormats.Dicom;
using Aspose.Imaging.ImageFilters.FilterOptions;
using Aspose.Imaging.ImageOptions;
using System;
using System.IO;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API
reference when the project is built. Please see https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information.
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/,
install it, and then add its reference to this project. For any issues, questions, or suggestions,
please feel free to contact us via https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.DICOM
{
    class ApplyFilterOnDICOMImage
    {
        public static void Run()
        {
            //ExStart:ApplyFilterOnDICOMImage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DICOM();

            Console.WriteLine("Running example ApplyFilterDicom");

            using (var fileStream = new FileStream(dataDir + "file.dcm", FileMode.Open, FileAccess.Read))
            using (DicomImage image = new DicomImage(fileStream))
            {
                // Supply the filters to the DICOM image and save the results to the output path.
                image.Filter(image.Bounds, new MedianFilterOptions(8));
                image.Save(dataDir + "ApplyFilterOnDICOMImage_out.bmp", new BmpOptions());
            }

            Console.WriteLine("Finished example ApplyFilterDicom");
            //ExEnd:ApplyFilterOnDICOMImage
        }
    }
}