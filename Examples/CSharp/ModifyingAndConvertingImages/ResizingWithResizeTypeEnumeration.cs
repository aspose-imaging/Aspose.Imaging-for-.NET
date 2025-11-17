// GIST-ID: ef79a309336c6c6da260722fa52a9531
/*
This project uses the Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API references when the project is built.
Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information.
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, install it, and then add its reference to this project.
For any issues, questions, or suggestions, please feel free to contact us using https://forum.aspose.com/
*/

using System;
namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    class ResizingWithResizeTypeEnumeration
    {
        public static void Run()
        {
            Console.WriteLine("Running example ResizingWithResizeTypeEnumeration");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();
            using (Image image = Image.Load(dataDir + "aspose-logo.jpg"))
            {
                image.Resize(300, 300, ResizeType.LanczosResample);
                image.Save(dataDir + "SimpleResizing_out.jpg");
            }

            Console.WriteLine("Finished example ResizingWithResizeTypeEnumeration");
        }
    }
}