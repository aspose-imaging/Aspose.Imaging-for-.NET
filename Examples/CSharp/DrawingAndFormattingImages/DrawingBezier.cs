using System.IO;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Sources;

namespace Aspose.Imaging.Examples.CSharp.DrawingAndFormattingImages
{
    public class DrawingBezier
    {
        public static void Run()
        {
            // ExStart:DrawingBezier
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DrawingAndFormattingImages();
 
            // Creates an instance of FileStream
            using (FileStream stream = new FileStream(dataDir + "DrawingBezier_out.bmp", FileMode.Create))
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

                    // Initializes the instance of PEN class with black color and width
                    Pen BlackPen = new Pen(Color.Black, 3);

                    float startX = 10;
                    float startY = 25;
                    float controlX1 = 20;
                    float controlY1 = 5;
                    float controlX2 = 55;
                    float controlY2 = 10;
                    float endX = 90;
                    float endY = 25;

                    // Draw a Bezier shape by specifying the Pen object having black color and co-ordinate Points
                    graphic.DrawBezier(BlackPen, startX, startY, controlX1, controlY1, controlX2, controlY2, endX, endY);

                    // save all changes.
                    image.Save();
                }
            }
            // ExEnd:DrawingBezier
        }
    }
}