/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.JPEG
{
    class RotatingAnImage
    {
        public static void Run()
        {
            // ExStart:RotatingAnImage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_JPEG();

            // Loading and Rotating Image
            using (var image = Image.Load(dataDir + "aspose-logo.jpg"))
            {
                
                image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                image.Save(dataDir + "RotatingAnImage_out.jpg");
            }
            // ExEnd:RotatingAnImage
        }       
    }
}

