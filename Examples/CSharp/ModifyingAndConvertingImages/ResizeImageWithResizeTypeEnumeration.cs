/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference 
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it, and then add its reference to this project. For any issues, questions, or suggestions, 
please feel free to contact us using https://forum.aspose.com/
*/

using System;
using Aspose.Imaging;

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    class ResizeImageWithResizeTypeEnumeration
    {
        public static void Run()
        {
            Console.WriteLine("Running example ResizeImageWithResizeTypeEnumeration");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Load an image from disk
            using (Image image = Image.Load(dataDir + "aspose-logo.jpg"))
            {
                if (!image.IsCached)
                {
                    image.CacheData();
                }

                // Specify only height, width, and ResizeType
                int newWidth = image.Width / 2;
                image.ResizeWidthProportionally(newWidth, ResizeType.LanczosResample);
                int newHeight = image.Height / 2;
                image.ResizeHeightProportionally(newHeight, ResizeType.NearestNeighbourResample);
                image.Save(dataDir + "ResizeImageWithResizeTypeEnumeration_out.png");
            }

            Console.WriteLine("Finished example ResizeImageWithResizeTypeEnumeration");
        }
    }
}