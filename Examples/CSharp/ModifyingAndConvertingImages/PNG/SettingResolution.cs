using Aspose.Imaging.FileFormats.Png;
using Aspose.Imaging.ImageOptions;
using System;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
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

            // Initialize variables to hold width & height values
            int width = 0;
            int height = 0;

            // Initialize an array of type Color to hold the pixel data
            Color[] pixels = null;

            // Create an instance of RasterImage and load a BMP image
            using (RasterImage raster = (RasterImage)Image.Load(dataDir + "aspose_logo.png"))
            {
                // Store the width & height in variables for later use
                width = raster.Width;
                height = raster.Height;
              
                // Load the pixels of RasterImage into the array of type Color
                pixels = raster.LoadPixels(new Rectangle(0, 0, width, height));
            }

            // Create & initialize an instance of PngImage while specifying size and PngColorType
            using (PngImage png = new PngImage(width, height))
            {
                // Save the previously loaded pixels on to the new PngImage
                png.SavePixels(new Rectangle(0, 0, width, height), pixels);

                // Create an instance of PngOptions, Set the horizontal & vertical resolutions and Save the result on disc
                PngOptions options = new PngOptions();                
                options.ResolutionSettings = new ResolutionSetting(72, 96);
                png.Save(dataDir + "SettingResolution_output.png", options);
            }

            Console.WriteLine("Finished example SettingResolution");
        }
    }
}
