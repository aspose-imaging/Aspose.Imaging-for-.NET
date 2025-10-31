/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference 
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it, and then add its reference to this project. For any issues, questions, or suggestions, 
please feel free to contact us using https://forum.aspose.com/
*/

using System;
namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.JPEG
{
    class RotatingAnImage
    {
        public static void Run()
        {
            //ExStart:RotatingAnImage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_JPEG();

            Console.WriteLine("Running example RotatingAnImage");
            // Loading and rotating the image
            using (var image = Image.Load(dataDir + "aspose-logo.jpg"))
            {
                image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                image.Save(dataDir + "RotatingAnImage_out.jpg");
            }

            Console.WriteLine("Finished example RotatingAnImage");
            //ExEnd:RotatingAnImage
        }       
    }
}