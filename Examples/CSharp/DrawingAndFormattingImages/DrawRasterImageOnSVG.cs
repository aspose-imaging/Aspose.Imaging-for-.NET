// GIST-ID: f4a178db9aefb75b5fc502b016053beb
using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Svg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.DrawingAndFormattingImages
{
    class DrawRasterImageOnSVG
    {
        public static void Run()
        {
            Console.WriteLine("Running example DrawRasterImageOnSVG");

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DrawingAndFormattingImages();

            // Load the raster image to be drawn.
            using (RasterImage imageToDraw = (RasterImage)Image.Load(dataDir + "asposenet_220_src01.png"))
            {
                // Load the SVG image that will serve as the drawing surface.
                using (SvgImage canvasImage = (SvgImage)Image.Load(dataDir + "asposenet_220_src02.svg"))
                {
                    // Drawing on an existing SVG image.
                    Aspose.Imaging.FileFormats.Svg.Graphics.SvgGraphics2D graphics =
                        new Aspose.Imaging.FileFormats.Svg.Graphics.SvgGraphics2D(canvasImage);

                    // Draw a rectangular part of the raster image within the specified bounds of the vector image (drawing surface).
                    // Note that because the source size is equal to the destination size, the drawn image is not stretched.
                    graphics.DrawImage(
                        new Rectangle(0, 0, imageToDraw.Width, imageToDraw.Height),
                        new Rectangle(67, 67, imageToDraw.Width, imageToDraw.Height),
                        imageToDraw);

                    // Save the result image.
                    using (SvgImage resultImage = graphics.EndRecording())
                    {
                        resultImage.Save(dataDir + "asposenet_220_src02.DrawImage.svg");
                    }
                }
            }

            Console.WriteLine("Finished example DrawRasterImageOnSVG");
        }
    }
}