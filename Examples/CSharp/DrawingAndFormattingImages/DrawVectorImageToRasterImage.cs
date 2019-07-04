using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Svg;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CSharp.DrawingAndFormattingImages
{
    class DrawVectorImageToRasterImage
    {
        public static void Run() {

            //ExStart:DrawVectorImageToRasterImage

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DrawingAndFormattingImages();

            using (MemoryStream drawnImageStream = new MemoryStream())
            {
                // First, rasterize Svg to Png and write the result to a stream.
                using (SvgImage svgImage = (SvgImage)Image.Load(dataDir + "asposenet_220_src02.svg"))
                {
                    SvgRasterizationOptions rasterizationOptions = new SvgRasterizationOptions();
                    rasterizationOptions.PageSize = svgImage.Size;

                    PngOptions saveOptions = new PngOptions();
                    saveOptions.VectorRasterizationOptions = rasterizationOptions;

                    svgImage.Save(drawnImageStream, saveOptions);

                    // Now load a Png image from stream for further drawing.
                    drawnImageStream.Seek(0, System.IO.SeekOrigin.Begin);
                    using (RasterImage imageToDraw = (RasterImage)Image.Load(drawnImageStream))
                    {
                        // Drawing on the existing Svg image.
                        Aspose.Imaging.FileFormats.Svg.Graphics.SvgGraphics2D graphics = new Aspose.Imaging.FileFormats.Svg.Graphics.SvgGraphics2D(svgImage);

                        // Scale down the entire drawn image by 2 times and draw it to the center of the drawing surface.
                        int width = imageToDraw.Width / 2;
                        int height = imageToDraw.Height / 2;
                        Point origin = new Point((svgImage.Width - width) / 2, (svgImage.Height - height) / 2);
                        Size size = new Size(width, height);

                        graphics.DrawImage(imageToDraw, origin, size);

                        // Save the result image
                        using (SvgImage resultImage = graphics.EndRecording())
                        {
                            resultImage.Save(dataDir + "asposenet_220_src02.DrawVectorImage.svg");
                        }
                    }
                }
            }
            //ExEnd:DrawVectorImageToRasterImage
        }
    }
}
