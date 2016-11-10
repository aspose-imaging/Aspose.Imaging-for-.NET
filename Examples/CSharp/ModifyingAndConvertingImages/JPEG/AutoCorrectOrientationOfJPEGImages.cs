using Aspose.Imaging.FileFormats.Jpeg;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.JPEG
{
    class AutoCorrectOrientationOfJPEGImages
    {
        public static void Run()
        {
            // ExStart:ReadAllEXIFTags
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_JPEG();

            // Load a Jpeg image from file path location or stream
            using (JpegImage image = (JpegImage)Image.Load(dataDir + "aspose-logo.jpg"))
            {
                // Perform the automatic rotation on the image depending on the orientation data stored in the EXIF and  Save the result on disc or stream
                image.AutoRotate();               
                image.Save(dataDir + "aspose-logo_out.jpg");
            }
        }
        // ExEnd:ReadAllEXIFTags
    }
}