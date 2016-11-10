using Aspose.Imaging.FileFormats.Png;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.PNG
{
    class SpecifyTransparency
    {
        public static void Run()
        {
            // ExStart:SpecifyTransparency
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
            using (PngImage png = new PngImage(width, height, PngColorType.TruecolorWithAlpha))
            {
                // Save the previously loaded pixels on to the new PngImage and Set TransparentColor property to specify which color to be rendered as transparent
                png.SavePixels(new Rectangle(0, 0, width, height), pixels);
                png.TransparentColor = Color.Black;
                png.HasTransparentColor = true;
                png.Save(dataDir + "SpecifyTransparencyforPNGImages_out.jpg");
            }
            // ExEnd:SpecifyTransparency
        }
    }
}
