using Aspose.Imaging.Brushes;
using Aspose.Imaging.FileFormats.Emf;
using Aspose.Imaging.FileFormats.Emf.Emf.Consts;
using Aspose.Imaging.FileFormats.Emf.Graphics;
using Aspose.Imaging.ImageOptions;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    public class CreateEMFMetaFileImage
    {
        public static void Run()
        {
            // ExStart:CreateEMFMetaFileImage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // EmfRecorderGraphics2D class provides you the frame or canvas to draw shapes on it.
            EmfRecorderGraphics2D graphics = new EmfRecorderGraphics2D(new Rectangle(0, 0, 1000, 1000), new Size(1000, 1000), new Size(100, 100));
            {
                // Create an instance of Imaging Pen class and mention its color.
                Pen pen = new Pen(Color.Bisque);

                // Draw a line by calling DrawLine method and passing x,y coordinates of 1st point and same for 2nd point along with color infor as Pen.
                graphics.DrawLine(pen, 1, 1, 50, 50);

                // Reset the Pen color Specify the end style of the line.
                pen = new Pen(Color.BlueViolet, 3);
                pen.EndCap = LineCap.Round;

                // Draw a line by calling DrawLine method and passing x,y coordinates of 1st point and same for 2nd point along with color infor as Pen and end style of line.
                graphics.DrawLine(pen, 15, 5, 50, 60);

                // Specify the end style of the line.
                pen.EndCap = LineCap.Square;
                graphics.DrawLine(pen, 5, 10, 50, 10);
                pen.EndCap = LineCap.Flat;

                // Draw a line by calling DrawLine method and passing parameters.
                graphics.DrawLine(pen, new Point(5, 20), new Point(50, 20));

                // Create an instance of HatchBrush class to define rectanglurar brush with with different settings.
                HatchBrush hatchBrush = new HatchBrush
                {
                    BackgroundColor = Color.AliceBlue,
                    ForegroundColor = Color.Red,
                    HatchStyle = HatchStyle.Cross
                };

                // Draw a line by calling DrawLine method and passing parameters.
                pen = new Pen(hatchBrush, 7);
                graphics.DrawRectangle(pen, 50, 50, 20, 30);

                // Draw a line by calling DrawLine method and passing parameters with different mode.
                graphics.BackgroundMode = EmfBackgroundMode.OPAQUE;
                graphics.DrawLine(pen, 80, 50, 80, 80);

                // Draw a polygon by calling DrawPolygon method and passing parameters with line join setting/style.
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

                // Draw a rectangle by calling DrawRectangle method.
                pen.LineJoin = LineJoin.Bevel;
                graphics.DrawRectangle(pen, 50, 10, 10, 5);
                pen.LineJoin = LineJoin.Round;
                graphics.DrawRectangle(pen, 65, 10, 10, 5);
                pen.LineJoin = LineJoin.Miter;
                graphics.DrawRectangle(pen, 80, 10, 10, 5);

                // Call EndRecording method to produce the final shape. EndRecording method will return the final shape as EmfImage. So create an instance of EmfImage class and initialize it with EmfImage returned by EndRecording method.
                using (EmfImage image = graphics.EndRecording())
                {
                    // Create an instance of PdfOptions class.
                    PdfOptions options = new PdfOptions();

                    // Create an instance of EmfRasterizationOptions class and define different settings.
                    EmfRasterizationOptions rasterizationOptions = new EmfRasterizationOptions();
                    rasterizationOptions.PageSize = image.Size;
                    options.VectorRasterizationOptions = rasterizationOptions;
                    string outPath = dataDir + "CreateEMFMetaFileImage_out.pdf";
                    image.Save(outPath, options);
                }
            }
            // ExStart:CreateEMFMetaFileImage
        }
    }
}