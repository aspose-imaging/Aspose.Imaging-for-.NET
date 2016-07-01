using System;
using Aspose.Imaging.FileFormats.Dicom;
using Aspose.Imaging.FileFormats.Tiff;
using Aspose.Imaging.ImageFilters.FilterOptions;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.DICOM
{
    class DICOMCroppingByShifts
    {
        public static void Run()
        {
            // ExStart:DICOMCroppingByShifts
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DICOM();

            // Load an existing image.
            using (DicomImage image = new DicomImage(dataDir + "image.dcm"))
            {
                // Call and supply the four values to Crop method.
                image.Crop(1, 1, 1, 1);

                // Save the results to disk
                image.Save(dataDir + "DICOMCroppingByShifts_out.bmp", new BmpOptions());
            }
            // ExEnd:DICOMCroppingByShifts
        }
    }
}