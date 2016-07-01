using System.IO;
using Aspose.Imaging.FileFormats.Tiff;
using Aspose.Imaging.FileFormats.Tiff.Enums;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Sources;
using Aspose.Imaging;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    class TiffDataRecovery
    {
        public static void Run()
        {
            // To get proper output please apply a valid Aspose.Imaging License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");

            // ExStart:TiffDataRecovery
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Create an instance of LoadOptions
            LoadOptions loadOptions = new LoadOptions();
            // Specify the DataRecoveryMode for the object of LoadOptions
            loadOptions.DataRecoveryMode = DataRecoveryMode.ConsistentRecover;
            // Specify the DataBackgroundColor for the object of LoadOptions
            loadOptions.DataBackgroundColor = Color.Red;
            // Create an instance of Image and load a damaged image by passing the instance of LoadOptions
            using (Image image = Image.Load(dataDir + "SampleTiff1.tiff", loadOptions))
            {
                // Do some work
            }
            // ExEnd:TiffDataRecovery
        }
    }
}
