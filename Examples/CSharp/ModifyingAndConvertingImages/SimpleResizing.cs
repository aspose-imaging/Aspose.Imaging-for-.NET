/*
This project uses the Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API references
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information.
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/,
install it, and then add its reference to this project. For any issues, questions, or suggestions,
please feel free to contact us using https://forum.aspose.com/
*/

using System;
namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    class SimpleResizing
    {
        public static void Run()
        {
            // To get proper output please apply a valid Aspose.Imaging License.
            // You can purchase a full license or get a 30‑day temporary license from https://www.aspose.com/purchase/default.aspx.

            Console.WriteLine("Running example SimpleResizing");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();
            using (Image image = Image.Load(dataDir + "aspose-logo.jpg"))
            {
                image.Resize(300, 300);
                image.Save(dataDir + "SimpleResizing_out.jpg");
            }

            using (Image image = Image.Load(dataDir + "aspose-logo.jpg"))
            {
                image.Resize(200, 200, ResizeType.CatmullRom);
            }

            Console.WriteLine("Finished example SimpleResizing");
        }
    }
}