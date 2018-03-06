using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Sources;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.DrawingAndFormattingImages
{
    public class DrawImagesUsingCoreFunctionality
    {
        public static void Run()
        {
            //ExStart:DrawImagesUsingCoreFunctionality
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DrawingAndFormattingImages();

            // Create an instance of BmpOptions and set its various properties
            BmpOptions ImageOptions = new BmpOptions();
            ImageOptions.BitsPerPixel = 24;

            // Create an instance of FileCreateSource and assign it to Source property
            ImageOptions.Source = new FileCreateSource(dataDir + "DrawImagesUsingCoreFunctionality_out.bmp", false);

            // Create an instance of RasterImage and Get the pixels of the image by specifying the area as image boundary
            using (RasterImage rasterImage = (RasterImage)Image.Create(ImageOptions, 500, 500))
            {
                Color[] pixels = rasterImage.LoadPixels(rasterImage.Bounds);
                for (int index = 0; index < pixels.Length; index++)
                {
                    // Set the indexed pixel color to yellow
                    pixels[index] = Color.Yellow;
                }

                // Apply the pixel changes to the image and Save all changes.
                rasterImage.SavePixels(rasterImage.Bounds, pixels);
                rasterImage.Save();
            }
            //ExStart:DrawImagesUsingCoreFunctionality
        }
    }
}