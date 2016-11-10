using Aspose.Imaging.FileFormats.Dicom;
using Aspose.Imaging.ImageOptions;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
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

            // Load a DICOM image in an instance of DicomImage
            using (DicomImage image = new DicomImage(dataDir + "image.dcm"))
            {
                // Adjust the gamma and Create an instance of BmpOptions for the resultant image and Save the resultant image
                image.AdjustGamma(50);
                image.Save(dataDir + "AdjustGammaDICOM_out.bmp", new BmpOptions());
            }
            // ExEnd:AdjustGammaDICOM
        }
    }
}