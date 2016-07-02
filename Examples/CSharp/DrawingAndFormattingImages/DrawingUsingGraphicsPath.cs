using System;
using Aspose.Imaging.Brushes;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Shapes;
using Aspose.Imaging.Sources;

namespace Aspose.Imaging.Examples.CSharp.DrawingAndFormattingImages
{
    public class DrawingUsingGraphicsPath
    {
        public static void Run()
        {
            // ExStart:DrawingUsingGraphicsPath
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DrawingAndFormattingImages();
            
            // Create an instance of BmpOptions and set its various properties
            BmpOptions ImageOptions = new BmpOptions();
            ImageOptions.BitsPerPixel = 24;

            // Create an instance of FileCreateSource and assign it to Source property
            ImageOptions.Source = new FileCreateSource(dataDir + "sample_1.bmp", false);

            // Create an instance of Image 
            using (Image image = Image.Create(ImageOptions, 500, 500))
            {
                // Create and initialize an instance of Graphics
                Graphics graphics = new Graphics(image);

                // Clear the image surface with white color
                graphics.Clear(Color.White);

                // Create an instance of GraphicsPath
                GraphicsPath graphicspath = new GraphicsPath();

                // Create an instance of Figure
                Figure figure = new Figure();

                // Add EllipseShape to the figure by defining boundary Rectangle
                figure.AddShape(new EllipseShape(new RectangleF(0, 0, 499, 499)));

                // Add RectangleShape to the figure
                figure.AddShape(new RectangleShape(new RectangleF(0, 0, 499, 499)));

                // Add TextShape to the figure by defining the boundary Rectangle and Font
                figure.AddShape(new TextShape("Aspose.Imaging", new RectangleF(170, 225, 170, 100), new Font("Arial", 20), StringFormat.GenericTypographic));

                // Add figures to the GraphicsPath object
                graphicspath.AddFigures(new[] { figure });

                // Draw Path
                graphics.DrawPath(new Pen(Color.Blue), graphicspath);

                // Create an instance of HatchBrush and set its properties
                HatchBrush hatchbrush = new HatchBrush();
                hatchbrush.BackgroundColor = Color.Brown;
                hatchbrush.ForegroundColor = Color.Blue;
                hatchbrush.HatchStyle = HatchStyle.Vertical;

                // Fill path by supplying the brush and GraphicsPath objects
                graphics.FillPath(hatchbrush, graphicspath);

                // Save the changes.
                image.Save();

                // Display Status.
                Console.WriteLine("Processing completed successfully.");
            }
            // ExEnd:DrawingUsingGraphicsPath
        }
    }
}