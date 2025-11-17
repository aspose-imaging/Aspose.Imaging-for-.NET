// GIST-ID: 83c15fb75937a059fe680a9c13d315e8
using Aspose.Imaging.Brushes;
using Aspose.Imaging.FileFormats.Wmf;
using Aspose.Imaging.FileFormats.Wmf.Graphics;
using System;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API references when the project is built. Please see https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. If you prefer not to use NuGet, you can manually download Aspose.Imaging for .NET from https://releases.aspose.com/, install it, and add its reference to this project. For any issues, questions, or suggestions, feel free to contact us via https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    public class CreateWMFMetaFileImage
    {
        public static void Run()
        {
            Console.WriteLine("Running example CreateWMFMetaFileImage");

            // WmfRecorderGraphics2D provides a canvas on which you can draw shapes.
            // Create an instance of WmfRecorderGraphics2D. The constructor takes two parameters:
            // 1. An Imaging Rectangle defining the drawing area.
            // 2. An integer specifying the resolution in DPI.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();
            WmfRecorderGraphics2D graphics = new WmfRecorderGraphics2D(new Rectangle(0, 0, 100, 100), 96);

            // Define the background color.
            graphics.BackgroundColor = Color.WhiteSmoke;

            // Initialize a Pen and a Brush with their respective colors.
            Pen pen = new Pen(Color.Blue);
            Brush brush = new SolidBrush(Color.YellowGreen);

            // Fill and draw a polygon.
            graphics.FillPolygon(brush, new[] { new Point(2, 2), new Point(20, 20), new Point(20, 2) });
            graphics.DrawPolygon(pen, new[] { new Point(2, 2), new Point(20, 20), new Point(20, 2) });
            brush = new HatchBrush { HatchStyle = HatchStyle.Cross, BackgroundColor = Color.White, ForegroundColor = Color.Silver };

            // Fill and draw an ellipse.
            graphics.FillEllipse(brush, new Rectangle(25, 2, 20, 20));
            graphics.DrawEllipse(pen, new Rectangle(25, 2, 20, 20));

            // Define pen style by setting DashStyle and color.
            pen.DashStyle = DashStyle.Dot;
            pen.Color = Color.Black;

            // Draw an arc.
            graphics.DrawArc(pen, new Rectangle(50, 2, 20, 20), 0, 180);
            pen.DashStyle = DashStyle.Solid;
            pen.Color = Color.Red;

            // Draw a cubic Bézier curve.
            graphics.DrawCubicBezier(pen, new Point(10, 25), new Point(20, 50), new Point(30, 50), new Point(40, 25));

            // Load an image and draw it onto the canvas.
            using (Image image = Image.Load(dataDir + @"WaterMark.bmp"))
            {
                // Cast the loaded image to RasterImage.
                RasterImage rasterImage = image as RasterImage;
                if (rasterImage != null)
                {
                    graphics.DrawImage(rasterImage, new Point(50, 50));
                }
            }

            // Draw a line.
            graphics.DrawLine(pen, new Point(2, 98), new Point(2, 50));

            // Define brush settings for a pie shape.
            brush = new SolidBrush(Color.Green);
            pen.Color = Color.DarkGoldenrod;

            // Fill and draw a pie.
            graphics.FillPie(brush, new Rectangle(2, 38, 20, 20), 0, 45);
            graphics.DrawPie(pen, new Rectangle(2, 38, 20, 20), 0, 45);
            pen.Color = Color.AliceBlue;

            // Draw a polyline.
            graphics.DrawPolyline(pen, new[] { new Point(50, 40), new Point(75, 40), new Point(75, 45), new Point(50, 45) });

            // Create a font for drawing text.
            Font font = new Font("Arial", 16);

            // Draw a string.
            graphics.DrawString("Aspose", font, Color.Blue, 25, 75);

            // End recording and save the WMF image.
            using (WmfImage image = graphics.EndRecording())
            {
                image.Save(dataDir + "CreateWMFMetaFileImage.wmf");
            }

            Console.WriteLine("Finished example CreateWMFMetaFileImage");
        }
    }
}