using Aspose.Imaging.ImageOptions;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.PNG
{
    class SpecifyTransparencyUsingRasterImage
    {
        public static void Run()
        {
            // ExStart:SpecifyTransparencyforPNGImagesUsingRasterImage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_PNG();

            // Initialize variables to hold width & height values
            int width = 0;
            int height = 0;

            // Create an instance of RasterImage and load a BMP image
            using (RasterImage image = (RasterImage)Image.Load(dataDir + "aspose_logo.png"))
            {
                // Store the width & height in variables for later use
                width = image.Width;
                height = image.Height;

                // Set the background color, transparent, HasTransparentColor & HasBackgroundColor properties for the image
                image.BackgroundColor = Color.White;
                image.TransparentColor = Color.Black;
                image.HasTransparentColor = true;
                image.HasBackgroundColor = true;
                image.Save(dataDir + "SpecifyTransparencyforPNGImagesUsingRasterImage_out.jpg", new PngOptions());
            }
            // ExEnd:SpecifyTransparencyforPNGImages
        }
    }
}
