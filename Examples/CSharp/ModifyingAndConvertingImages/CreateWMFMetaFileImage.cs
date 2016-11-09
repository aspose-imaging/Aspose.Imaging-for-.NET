using Aspose.Imaging.Brushes;
using Aspose.Imaging.FileFormats.Wmf;
using Aspose.Imaging.FileFormats.Wmf.Graphics;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{

    public class CreateWMFMetaFileImage
    {
        public static void Run()
        {
            // WmfRecorderGraphics2D class provides you the frame or canvas to draw shapes on it.  Create an instance of WmfRecorderGraphics2D class. The constructor takes in 2 parameters:  1. Instance of Imaging Rectangle class 2. An integer value for inches
            // ExStart:CreateWMFMetaFileImage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            WmfRecorderGraphics2D graphics = new WmfRecorderGraphics2D(new Rectangle(0, 0, 100, 100), 96);

            // Define background color
            graphics.BackgroundColor = Color.WhiteSmoke;

            // Init Create an instance of Imaging Pen class and mention its color.
            Pen pen = new Pen(Color.Blue);

            // Create an instance of Imaging Brush class and mention its color.
            Brush brush = new SolidBrush(Color.YellowGreen);

            // Polygon Fill polygon by calling FillPolygon method and passing parameters brush and points.
            graphics.FillPolygon(brush, new[] { new Point(2, 2), new Point(20, 20), new Point(20, 2) });

            // Draw a polygon by calling DrawPolygon method and passing parameters pen and points.
            graphics.DrawPolygon(pen, new[] { new Point(2, 2), new Point(20, 20), new Point(20, 2) });

            // Ellipse  Create an instance of HatchBrush class set different properties.
            brush = new HatchBrush { HatchStyle = HatchStyle.Cross, BackgroundColor = Color.White, ForegroundColor = Color.Silver };

            // Fill ellipse by calling FillEllipse method and passing parameters brush and an instance of Imaging Rectangle class.
            graphics.FillEllipse(brush, new Rectangle(25, 2, 20, 20));

            // Draw an ellipse by calling DrawEllipse method and passing parameters pen and an instance of Imaging Rectangle class.
            graphics.DrawEllipse(pen, new Rectangle(25, 2, 20, 20));

            // Arc  Define pen style by setting DashStyle value
            pen.DashStyle = DashStyle.Dot;

            // Set color of the pen
            pen.Color = Color.Black;

            // Draw an Arc by calling DrawArc method and passing parameters pen and an instance of Imaging Rectangle class.
            graphics.DrawArc(pen, new Rectangle(50, 2, 20, 20), 0, 180);

            // CubicBezier
            pen.DashStyle = DashStyle.Solid;
            pen.Color = Color.Red;

            // Draw an CubicBezier by calling DrawCubicBezier method and passing parameters pen and points.
            graphics.DrawCubicBezier(pen, new Point(10, 25), new Point(20, 50), new Point(30, 50), new Point(40, 25));

            // Image  Create an Instance of Image class.
            using (Image image = Image.Load(dataDir + @"WaterMark.bmp"))
            {
                // Cast the instance of image class to RasterImage.
                RasterImage rasterImage = image as RasterImage;
                if (rasterImage != null)
                {
                    // Draw an image by calling DrawImage method and passing parameters rasterimage and point.
                    graphics.DrawImage(rasterImage, new Point(50, 50));
                }
            }

            // Line Draw a line by calling DrawLine method and passing x,y coordinates of 1st point and same for 2nd point along with color infor as Pen.
            graphics.DrawLine(pen, new  Point(2, 98), new  Point(2, 50));

            // Pie Define settings of the brush object.
            brush = new  SolidBrush( Color.Green);
            pen.Color =  Color.DarkGoldenrod;

            // Fill pie by calling FillPie method and passing parameters brush and an instance of Imaging Rectangle class.
            graphics.FillPie(brush, new Rectangle(2, 38, 20, 20), 0, 45);

            // Draw pie by calling DrawPie method and passing parameters pen and an instance of Imaging Rectangle class.
            graphics.DrawPie(pen, new Rectangle(2, 38, 20, 20), 0, 45);

            pen.Color = Color.AliceBlue;

            // Polyline Draw Polyline by calling DrawPolyline method and passing parameters pen and points.
            graphics.DrawPolyline(pen, new[] { new Point(50, 40), new Point(75, 40), new Point(75, 45), new Point(50, 45) });

            // For having Strings Create an instance of Font class.
            Font font = new Font("Arial", 16);

            // Draw String by calling DrawString method and passing parameters string to display, color and X & Y coordinates.
            graphics.DrawString("Aspose", font, Color.Blue, 25, 75);

            // Call end recording of graphics object and save WMF image by calling Save method.
            using (WmfImage image = graphics.EndRecording())
            {
                image.Save(dataDir + "CreateWMFMetaFileImage.wmf");
            }
            // ExEnd:CreateWMFMetaFileImage
        }
    }
}