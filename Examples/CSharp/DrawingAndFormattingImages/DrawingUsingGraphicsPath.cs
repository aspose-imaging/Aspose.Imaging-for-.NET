using System;
using Aspose.Imaging.Brushes;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Shapes;
using Aspose.Imaging.Sources;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API references
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information.
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/,
install it, and then add its reference to this project. For any issues, questions, or suggestions,
please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.DrawingAndFormattingImages
{
    public class DrawingUsingGraphicsPath
    {
        public static void Run()
        {
            Console.WriteLine("Running example DrawingUsingGraphicsPath");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DrawingAndFormattingImages();

            // Create an instance of BmpOptions and set its various properties.
            BmpOptions ImageOptions = new BmpOptions();
            ImageOptions.BitsPerPixel = 24;

            // Create an instance of FileCreateSource and assign it to the Source property.
            ImageOptions.Source = new FileCreateSource(dataDir + "sample_1.bmp", false);

            // Create an Image instance and initialize a Graphics object.
            using (Image image = Image.Create(ImageOptions, 500, 500))
            {
                Graphics graphics = new Graphics(image);
                graphics.Clear(Color.White);

                // Create an instance of GraphicsPath and a Figure, then add EllipseShape, RectangleShape, and TextShape to the figure.
                GraphicsPath graphicspath = new GraphicsPath();
                Figure figure = new Figure();
                figure.AddShape(new EllipseShape(new RectangleF(0, 0, 499, 499)));
                figure.AddShape(new RectangleShape(new RectangleF(0, 0, 499, 499)));
                figure.AddShape(new TextShape("Aspose.Imaging", new RectangleF(170, 225, 170, 100), new Font("Arial", 20), StringFormat.GenericTypographic));
                graphicspath.AddFigures(new[] { figure });
                graphics.DrawPath(new Pen(Color.Blue), graphicspath);

                // Create an instance of HatchBrush, set its properties, and fill the path using the brush and the GraphicsPath objects.
                HatchBrush hatchbrush = new HatchBrush();
                hatchbrush.BackgroundColor = Color.Brown;
                hatchbrush.ForegroundColor = Color.Blue;
                hatchbrush.HatchStyle = HatchStyle.Vertical;
                graphics.FillPath(hatchbrush, graphicspath);
                image.Save();
                Console.WriteLine("Processing completed successfully.");
            }

            Console.WriteLine("Finished example DrawingUsingGraphicsPath");
        }
    }
}