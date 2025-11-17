// GIST-ID: f5ca59c45061a4d61b08e3babf55e489
using Aspose.Imaging;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Sources;
using System;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API
when the project is built. Please see https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information.
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET from https://releases.aspose.com/,
install it, and then add its reference to this project. For any issues, questions, or suggestions,
please feel free to contact us via https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.DrawingAndFormattingImages
{
    public class DrawImagesUsingCoreFunctionality
    {
        public static void Run()
        {
            Console.WriteLine("Running example DrawImagesUsingCoreFunctionality");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DrawingAndFormattingImages();

            // Create an instance of BmpOptions and set its various properties.
            BmpOptions imageOptions = new BmpOptions();
            imageOptions.BitsPerPixel = 24;

            // Create an instance of FileCreateSource and assign it to the Source property.
            imageOptions.Source = new FileCreateSource(dataDir + "DrawImagesUsingCoreFunctionality_out.bmp", false);

            // Create an instance of RasterImage and get the pixels of the image by specifying the
            // entire image bounds as the area.
            using (RasterImage rasterImage = (RasterImage)Image.Create(imageOptions, 500, 500))
            {
                Color[] pixels = rasterImage.LoadPixels(rasterImage.Bounds);
                for (int index = 0; index < pixels.Length; index++)
                {
                    // Set each pixel to yellow.
                    pixels[index] = Color.Yellow;
                }

                // Apply the pixel changes to the image and save all changes.
                rasterImage.SavePixels(rasterImage.Bounds, pixels);
                rasterImage.Save();
            }

            Console.WriteLine("Finished example DrawImagesUsingCoreFunctionality");
        }
    }
}