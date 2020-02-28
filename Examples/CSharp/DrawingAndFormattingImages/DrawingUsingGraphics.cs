﻿using Aspose.Imaging.Brushes;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Sources;
using System;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.DrawingAndFormattingImages
{
    class DrawingUsingGraphics
    {
        public static void Run()
        {
            Console.WriteLine("Running example DrawingUsingGraphics");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DrawingAndFormattingImages() + "SampleImage_out.bmp";

            // Create an instance of BmpOptions and set its various properties
            BmpOptions imageOptions = new BmpOptions();
            imageOptions.BitsPerPixel = 24;

            // Create an instance of FileCreateSource and assign it to Source property 
            imageOptions.Source = new FileCreateSource(dataDir, false);
            using (var image = Image.Create(imageOptions, 500, 500))
            {
                var graphics = new Graphics(image);

                // Clear the image surface with white color and Create and initialize a Pen object with blue color
                graphics.Clear(Color.White);
                var pen = new Pen(Color.Blue);

                // Draw Ellipse by defining the bounding rectangle of width 150 and height 100 also Draw a polygon using the LinearGradientBrush
                graphics.DrawEllipse(pen, new Rectangle(10, 10, 150, 100));
                using (var linearGradientBrush = new LinearGradientBrush(image.Bounds, Color.Red, Color.White, 45f))
                {
                    graphics.FillPolygon(
                        linearGradientBrush,
                        new[] { new Point(200, 200), new Point(400, 200), new Point(250, 350) });
                }

                image.Save();
            }

            Console.WriteLine("Finished example DrawingUsingGraphics");
        }
    }
}