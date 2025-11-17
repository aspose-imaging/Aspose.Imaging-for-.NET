// GIST-ID: 4475fec6a811b999c9a4d8d3124e74a0
/*
This project uses the automatic package‑restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, install it, and then add its reference to this project. For any issues, questions, or suggestions, please feel free to contact us using https://forum.aspose.com/.
*/

using System;
namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    class SimpleResizeImageProportionally
    {
        public static void Run()
        {
            Console.WriteLine("Running example SimpleResizeImageProportionally");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Load an image from disk.
            using (Image image = Image.Load(dataDir + "aspose-logo.jpg"))
            {
                if (!image.IsCached)
                {
                    image.CacheData();
                }
                // Specify a new width and resize proportionally.
                int newWidth = image.Width / 2;
                image.ResizeWidthProportionally(newWidth);
                // Specify a new height and resize proportionally.
                int newHeight = image.Height / 2;
                image.ResizeHeightProportionally(newHeight);
                image.Save(dataDir + "SimpleResizeImageProportionally_out.png");
            }

            Console.WriteLine("Finished example SimpleResizeImageProportionally");
        }
    }
}