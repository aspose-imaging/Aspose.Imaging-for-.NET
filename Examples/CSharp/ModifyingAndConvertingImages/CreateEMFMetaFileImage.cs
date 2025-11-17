// GIST-ID: f9b0cf7de4207bdbf17fbd516c71a946
using Aspose.Imaging.Brushes;
using Aspose.Imaging.FileFormats.Emf;
using Aspose.Imaging.FileFormats.Emf.Emf.Consts;
using Aspose.Imaging.FileFormats.Emf.Graphics;
using Aspose.Imaging.ImageOptions;
using System;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API references 
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it, and then add its reference to this project. For any issues, questions, or suggestions 
please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    public class CreateEMFMetaFileImage
    {
        public static void Run()
        {
            Console.WriteLine("Running example CreateEMFMetaFileImage");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // EmfRecorderGraphics2D provides a frame or canvas on which to draw shapes.
            EmfRecorderGraphics2D graphics = new EmfRecorderGraphics2D(new Rectangle(0, 0, 1000, 1000), new Size(1000, 1000), new Size(100, 100));
            {
                // Create an instance of the Pen class and set its color.
                Pen pen = new Pen(Color.Bisque);

                // Draw a line by calling DrawLine and passing the coordinates of the start and end points.
                graphics.DrawLine(pen, 1, 1, 50, 50);

                // Reset the pen color and specify the end style of the line.
                pen = new Pen(Color.BlueViolet, 3);
                pen.EndCap = LineCap.Round;

                // Draw another line with the updated pen and end style.
                graphics.DrawLine(pen, 15, 5, 50, 60);

                // Change the end style and draw a line.
                pen.EndCap = LineCap.Square;
                graphics.DrawLine(pen, 5, 10, 50, 10);
                pen.EndCap = LineCap.Flat;

                // Draw a line using Point structures.
                graphics.DrawLine(pen, new Point(5, 20), new Point(50, 20));

                // Create a HatchBrush to define a rectangular brush with specific settings.
                HatchBrush hatchBrush = new HatchBrush
                {
                    BackgroundColor = Color.AliceBlue,
                    ForegroundColor = Color.Red,
                    HatchStyle = HatchStyle.Cross
                };

                // Use the hatch brush to draw a rectangle.
                pen = new Pen(hatchBrush, 7);
                graphics.DrawRectangle(pen, 50, 50, 20, 30);

                // Change the background mode and draw a line.
                graphics.BackgroundMode = EmfBackgroundMode.OPAQUE;
                graphics.DrawLine(pen, 80, 50, 80, 80);

                // Draw a polygon with a specific line join style.
                pen = new Pen(new SolidBrush(Color.Aqua), 3);
                pen.LineJoin = LineJoin.MiterClipped;
                graphics.DrawPolygon(pen, new[]
                {
                    new Point(10, 20),
                    new Point(12, 45),
                    new Point(22, 48),
                    new Point(48, 36),
                    new Point(30, 55)
                });

                // Draw rectangles with different line join settings.
                pen.LineJoin = LineJoin.Bevel;
                graphics.DrawRectangle(pen, 50, 10, 10, 5);
                pen.LineJoin = LineJoin.Round;
                graphics.DrawRectangle(pen, 65, 10, 10, 5);
                pen.LineJoin = LineJoin.Miter;
                graphics.DrawRectangle(pen, 80, 10, 10, 5);

                // End recording to produce the final shape as an EmfImage.
                using (EmfImage image = graphics.EndRecording())
                {
                    // Create an instance of PdfOptions.
                    PdfOptions options = new PdfOptions();

                    // Define rasterization options for the EMF image.
                    EmfRasterizationOptions rasterizationOptions = new EmfRasterizationOptions
                    {
                        PageSize = image.Size
                    };
                    options.VectorRasterizationOptions = rasterizationOptions;

                    string outPath = dataDir + "CreateEMFMetaFileImage_out.pdf";
                    image.Save(outPath, options);
                }
            }

            Console.WriteLine("Finished example CreateEMFMetaFileImage");
        }
    }
}