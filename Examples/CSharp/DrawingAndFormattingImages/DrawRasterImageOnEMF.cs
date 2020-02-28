﻿using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Emf;
using Aspose.Imaging.FileFormats.Emf.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.DrawingAndFormattingImages
{
    class DrawRasterImageOnEMF
    {

        public static void Run()
        {
            Console.WriteLine("Running example DrawRasterImageOnEMF");

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DrawingAndFormattingImages();

            // Load the image to be drawn
            using (RasterImage imageToDraw = (RasterImage)Image.Load(dataDir + "asposenet_220_src01.png"))
            {
                // Load the image for drawing on it (drawing surface)
                using (EmfImage canvasImage = (EmfImage)Image.Load(dataDir + "input.emf"))
                {
                    EmfRecorderGraphics2D graphics = EmfRecorderGraphics2D.FromEmfImage(canvasImage);

                    // Draw a rectagular part of the raster image within the specified bounds of the vector image (drawing surface).
                    // Note that because the source size is not equal to the destination one, the drawn image is stretched horizontally and vertically.
                    graphics.DrawImage(
                        imageToDraw,
                        new Rectangle(67, 67, canvasImage.Width, canvasImage.Height),
                        new Rectangle(0, 0, imageToDraw.Width, imageToDraw.Height),
                        GraphicsUnit.Pixel);

                    // Save the result image
                    using (EmfImage resultImage = graphics.EndRecording())
                    {
                        resultImage.Save(dataDir + "input.DrawImage.emf");
                    }
                }
            }

            Console.WriteLine("Finished example DrawRasterImageOnEMF");
        }
    }
}