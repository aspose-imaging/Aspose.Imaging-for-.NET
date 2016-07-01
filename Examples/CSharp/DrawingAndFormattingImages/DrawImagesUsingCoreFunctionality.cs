using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Sources;

namespace Aspose.Imaging.Examples.CSharp.DrawingAndFormattingImages
{
    public class DrawImagesUsingCoreFunctionality
    {
        public static void Run()
        {
            // ExStart:DrawImagesUsingCoreFunctionality
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DrawingAndFormattingImages();

            // Create an instance of BmpOptions and set its various properties
            BmpOptions ImageOptions = new BmpOptions();
            ImageOptions.BitsPerPixel = 24;

            // Create an instance of FileCreateSource and assign it to Source property
            ImageOptions.Source = new FileCreateSource(dataDir + "DrawImagesUsingCoreFunctionality_out.bmp", false);

            // Create an instance of RasterImage
            using (RasterImage rasterImage = (RasterImage)Image.Create(ImageOptions, 500, 500))
            {
                //Get the pixels of the image by specifying the area as image boundary
                Color[] pixels = rasterImage.LoadPixels(rasterImage.Bounds);

                for (int index = 0; index < pixels.Length; index++)
                {
                    // Set the indexed pixel color to yellow
                    pixels[index] = Color.Yellow;
                }

                // Apply the pixel changes to the image
                rasterImage.SavePixels(rasterImage.Bounds, pixels);

                // Save all changes.
                rasterImage.Save();
            }
            // ExStart:DrawImagesUsingCoreFunctionality
        }
    }
}