using System.IO;
using Aspose.Imaging.Brushes;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Sources;

namespace Aspose.Imaging.Examples.CSharp.DrawingAndFormattingImages
{
    public class DrawingEllipse
    {
        public static void Run()
        {
            // ExStart:DrawingEllipse
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DrawingAndFormattingImages();
 				
            // Creates an instance of FileStream
            using (FileStream stream = new FileStream(dataDir + "DrawingEllipse_out.bmp", FileMode.Create))
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

                    // Draw a dotted ellipse shape by specifying the Pen object having red color and a surrounding Rectangle
                    graphic.DrawEllipse(new Pen(Color.Red), new Rectangle(30, 10, 40, 80));

                    // Draw a continuous ellipse shape by specifying the Pen object having solid brush with blue color and a surrounding Rectangle
                    graphic.DrawEllipse(new Pen(new SolidBrush(Color.Blue)), new Rectangle(10, 30, 80, 40));

                    // save all changes.
                    image.Save();
                }
                stream.Close();
            }
            // ExEnd:DrawingEllipse
        }
    }
}