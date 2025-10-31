using System;
using System.Drawing;
using Aspose.Imaging;
using Aspose.Imaging.ImageOptions;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information.
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/,
install it, and then add its reference to this project. For any issues, questions, or suggestions, please feel free to
contact us via https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    public class ConvertWMFToWebp
    {
        public static void Run()
        {
            Console.WriteLine("Running example ConvertWMFToWebp");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Load an existing WMF image
            using (Image image = Image.Load(dataDir + "input.wmf"))
            {
                // Calculate new WebP image height
                double k = (image.Width * 1.00) / image.Height;

                // Create an instance of WmfRasterizationOptions class and set its properties
                WmfRasterizationOptions emfRasterization = new WmfRasterizationOptions
                {
                    BackgroundColor = Color.WhiteSmoke,
                    PageWidth = 400,
                    PageHeight = (int)Math.Round(400 / k),
                    BorderX = 5,
                    BorderY = 10
                };

                // Create an instance of WebPOptions and assign the rasterization options
                ImageOptionsBase imageOptions = new WebPOptions
                {
                    VectorRasterizationOptions = emfRasterization
                };

                // Save the WMF file as a WebP image
                image.Save(dataDir + "ConvertWMFToWebp_out.webp", imageOptions);
            }

            Console.WriteLine("Finished example ConvertWMFToWebp");
        }
    }
}