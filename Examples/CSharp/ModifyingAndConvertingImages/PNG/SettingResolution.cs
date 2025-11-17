// GIST-ID: 3077067f9555800838b7a852b9cfcd99
using Aspose.Imaging;
using Aspose.Imaging.FileFormats.Png;
using Aspose.Imaging.ImageOptions;
using System;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference 
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it, and then add its reference to this project. For any issues, questions, or suggestions, 
please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.PNG
{
    class SettingResolution
    {
        public static void Run()
        {
            Console.WriteLine("Running example SettingResolution");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_PNG();

            // Initialize variables to hold width and height values.
            int width = 0;
            int height = 0;

            // Initialize an array of type Color to hold the pixel data.
            Color[] pixels = null;

            // Create an instance of RasterImage and load a PNG image.
            using (RasterImage raster = (RasterImage)Image.Load(dataDir + "aspose_logo.png"))
            {
                // Store the width and height in variables for later use.
                width = raster.Width;
                height = raster.Height;

                // Load the pixels of RasterImage into the array of type Color.
                pixels = raster.LoadPixels(new Rectangle(0, 0, width, height));
            }

            // Create and initialize an instance of PngImage while specifying size and PngColorType.
            using (PngImage png = new PngImage(width, height))
            {
                // Save the previously loaded pixels onto the new PngImage.
                png.SavePixels(new Rectangle(0, 0, width, height), pixels);

                // Create an instance of PngOptions, set the horizontal and vertical resolutions, and save the result to disc.
                PngOptions options = new PngOptions();
                options.ResolutionSettings = new ResolutionSetting(72, 96);
                png.Save(dataDir + "SettingResolution_output.png", options);
            }

            Console.WriteLine("Finished example SettingResolution");
        }
    }
}