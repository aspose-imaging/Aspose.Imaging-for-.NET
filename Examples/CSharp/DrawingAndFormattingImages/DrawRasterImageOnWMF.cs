using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Wmf;
using Aspose.Imaging.FileFormats.Wmf.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.DrawingAndFormattingImages
{
    class DrawRasterImageOnWMF
    {
        public static void Run()
        {
            Console.WriteLine("Running example DrawRasterImageOnWMF");

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DrawingAndFormattingImages();

            // Load the image to be drawn.
            using (RasterImage imageToDraw = (RasterImage)Image.Load(dataDir + "asposenet_220_src01.png"))
            {
                // Load the image that will serve as the drawing surface.
                using (WmfImage canvasImage = (WmfImage)Image.Load(dataDir + "asposenet_222_wmf_200.wmf"))
                {
                    WmfRecorderGraphics2D graphics = WmfRecorderGraphics2D.FromWmfImage(canvasImage);

                    // Draw a rectangular part of the raster image within the specified bounds of the vector image (drawing surface).
                    // Note that because the source size is not equal to the destination size, the drawn image is stretched horizontally and vertically.
                    graphics.DrawImage(
                        imageToDraw,
                        new Rectangle(67, 67, canvasImage.Width, canvasImage.Height),
                        new Rectangle(0, 0, imageToDraw.Width, imageToDraw.Height),
                        GraphicsUnit.Pixel);

                    // Save the result image.
                    using (WmfImage resultImage = graphics.EndRecording())
                    {
                        resultImage.Save(dataDir + "asposenet_222_wmf_200.DrawImage.wmf");
                    }
                }
            }

            Console.WriteLine("Finished example DrawRasterImageOnWMF");
        }
    }
}