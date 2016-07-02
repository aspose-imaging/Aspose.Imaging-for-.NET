using System.IO;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Sources;

namespace Aspose.Imaging.Examples.CSharp.DrawingAndFormattingImages
{
    public class DrawingArc
    {
        public static void Run()
        {
            // ExStart:DrawingBezier
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DrawingAndFormattingImages();

            // Creates an instance of FileStream
            using (FileStream stream = new FileStream(dataDir + "DrawingArc_out.bmp", FileMode.Create))
            {
                // Create an instance of BmpOptions and set its various properties
                BmpOptions saveOptions = new BmpOptions();
                saveOptions.BitsPerPixel = 32;

                // Set the Source for BmpOptions
                saveOptions.Source = new StreamSource(stream);

                // Create an instance of Image
                using (Image image = Image.Create(saveOptions, 100, 100))
                {
                    // Create and initialize an instance of Graphics class
                    Graphics graphic = new Graphics(image);

                    // Clear Graphics surface
                    graphic.Clear(Color.Yellow);

                    // Draw an arc shape by specifying the Pen object having red black color and coordinates, height, width, start & end angles                 
                    int width = 100;
                    int height = 200;
                    int startAngle = 45;
                    int sweepAngle = 270;

                    // Draw arc to screen.
                    graphic.DrawArc(new Pen(Color.Black), 0, 0, width, height, startAngle, sweepAngle);

                    // save all changes.
                    image.Save();
                }

                stream.Close();
            }

        }
    }
}