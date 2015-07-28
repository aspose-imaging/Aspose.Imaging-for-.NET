//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Imaging. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Imaging;
using Aspose.Imaging.Shapes;

namespace Aspose.Imaging.Examples.Images
{
    public class DrawingUsingGraphicsPath
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Aspose.Imaging.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            
            //Create an instance of BmpCreateOptions and set its various properties
            //Create an instance of BmpOptions and set its various properties
            Aspose.Imaging.ImageOptions.BmpOptions ImageOptions = new Aspose.Imaging.ImageOptions.BmpOptions();
            ImageOptions.BitsPerPixel = 24;

            //Create an instance of FileCreateSource and assign it to Source property
            ImageOptions.Source = new Aspose.Imaging.Sources.FileCreateSource(dataDir + "sample.bmp", false);

            //Create an instance of Image 
            using (Aspose.Imaging.Image image = Aspose.Imaging.Image.Create(ImageOptions, 500, 500))
            {
                //Create and initialize an instance of Graphics
                Aspose.Imaging.Graphics graphics = new Aspose.Imaging.Graphics(image);

                //Clear the image surface with white color
                graphics.Clear(Aspose.Imaging.Color.White);

                //Create an instance of GraphicsPath
                Aspose.Imaging.GraphicsPath graphicspath = new Aspose.Imaging.GraphicsPath();

                //Create an instance of Figure
                Aspose.Imaging.Figure figure = new Aspose.Imaging.Figure();

                //Add EllipseShape to the figure by defining boundary Rectangle
                figure.AddShape(new EllipseShape(new RectangleF(0, 0, 499, 499)));

                //Add RectangleShape to the figure
                figure.AddShape(new RectangleShape(new RectangleF(0, 0, 499, 499)));

                //Add TextShape to the figure by defining the boundary Rectangle and Font
                figure.AddShape(new TextShape("Aspose.Imaging", new RectangleF(170, 225, 170, 100), new Font("Arial", 20), StringFormat.GenericTypographic));

                //Add figures to the GraphicsPath object
                graphicspath.AddFigures(new Aspose.Imaging.Figure[] { figure });

                //Draw Path
                graphics.DrawPath(new Aspose.Imaging.Pen(Aspose.Imaging.Color.Blue), graphicspath);

                //Create an instance of HatchBrush and set its properties
                Aspose.Imaging.Brushes.HatchBrush hatchbrush = new Aspose.Imaging.Brushes.HatchBrush();
                hatchbrush.BackgroundColor = Aspose.Imaging.Color.Brown;
                hatchbrush.ForegroundColor = Color.Blue;
                hatchbrush.HatchStyle = HatchStyle.Vertical;

                //Fill path by supplying the brush and GraphicsPath objects
                graphics.FillPath(hatchbrush, graphicspath);

                // Save the changes.
                image.Save();

                // Display Status.
                System.Console.WriteLine("Processing completed successfully.");
            }
        }
    }
}