// GIST-ID: 3c4ae6091f4d58bac5fe7de4918f1f5f
using Aspose.Imaging.FileFormats.Jpeg;
using System;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API references 
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it, and then add its reference to this project. For any issues, questions, or suggestions, 
please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.JPEG
{
    class AutoCorrectOrientationOfJPEGImages
    {
        public static void Run()
        {
            //ExStart:AutoCorrectOrientationOfJPEGImages
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_JPEG();
            Console.WriteLine("Running example AutoCorrectOrientationOfJPEGImages");
            // Load a JPEG image from a file path location or stream.
            using (JpegImage image = (JpegImage)Image.Load(dataDir + "aspose-logo.jpg"))
            {
                // Perform the automatic rotation on the image depending on the orientation data stored in the EXIF,
                // and save the result to disk or a stream.
                image.AutoRotate();               
                image.Save(dataDir + "aspose-logo_out.jpg");
            }

            Console.WriteLine("Finished example AutoCorrectOrientationOfJPEGImages");
            //ExEnd:AutoCorrectOrientationOfJPEGImages
        }       
    }
}