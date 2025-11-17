// GIST-ID: 45dc8b730481161bd175532a947d3bc1
using Aspose.Imaging.ImageOptions;
using System;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API references
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information.
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/,
install it, and then add its reference to this project. For any issues, questions, or suggestions,
please feel free to contact us via https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.PNG
{
    class SpecifyTransparencyUsingRasterImage
    {
        public static void Run()
        {
            Console.WriteLine("Running example SpecifyTransparencyUsingRasterImage");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_PNG();

            // Initialize variables to hold width and height values
            int width = 0;
            int height = 0;

            // Create an instance of RasterImage and load a PNG image
            using (RasterImage image = (RasterImage)Image.Load(dataDir + "aspose_logo.png"))
            {
                // Store the width and height in variables for later use
                width = image.Width;
                height = image.Height;

                // Set the background color, transparent color, HasTransparentColor, and HasBackgroundColor properties for the image
                image.BackgroundColor = Color.White;
                image.TransparentColor = Color.Black;
                image.HasTransparentColor = true;
                image.HasBackgroundColor = true;
                image.Save(dataDir + "SpecifyTransparencyforPNGImagesUsingRasterImage_out.png", new PngOptions());
            }

            Console.WriteLine("Running example SpecifyTransparencyUsingRasterImage");
        }
    }
}