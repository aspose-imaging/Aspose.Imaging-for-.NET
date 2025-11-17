// GIST-ID: 45a2de98ee07b655953f1415a250ff44
using Aspose.Imaging.FileFormats.Png;
using System;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API references 
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it, and then add its reference to this project. For any issues, questions, or suggestions, 
please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.PNG
{
    class SpecifyTransparency
    {
        public static void Run()
        {
            Console.WriteLine("Running example SpecifyTransparency");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_PNG();

            // Initialize variables to hold width and height values.
            int width = 0;
            int height = 0;

            // Initialize an array of type Color to hold the pixel data.
            Color[] pixels = null;

            // Create an instance of RasterImage and load a BMP image.
            using (RasterImage raster = (RasterImage)Image.Load(dataDir + "aspose_logo.png"))
            {
                // Store the width and height in variables for later use.
                width = raster.Width;
                height = raster.Height;

                // Load the pixels of RasterImage into the array of type Color.
                pixels = raster.LoadPixels(new Rectangle(0, 0, width, height));
            }

            // Create and initialize an instance of PngImage while specifying size and PngColorType.
            using (PngImage png = new PngImage(width, height, PngColorType.TruecolorWithAlpha))
            {
                // Save the previously loaded pixels onto the new PngImage and set the TransparentColor property to specify which color should be rendered as transparent.
                png.SavePixels(new Rectangle(0, 0, width, height), pixels);
                png.TransparentColor = Color.Black;
                png.HasTransparentColor = true;
                png.Save(dataDir + "SpecifyTransparencyforPNGImages_out.jpg");
            }

            Console.WriteLine("Finished example SpecifyTransparency");
        }
    }
}