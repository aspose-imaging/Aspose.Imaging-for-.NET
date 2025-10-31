using System.IO;
using Aspose.Imaging.Brushes;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Sources;
using System;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API references
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information.
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/,
install it, and then add its reference to this project. For any issues, questions, or suggestions,
please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.DrawingAndFormattingImages
{
    public class DrawingLines
    {
        public static void Run()
        {
            Console.WriteLine("Running example DrawingLines");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DrawingAndFormattingImages() + "SolidLines_out.bmp";

            // Creates an instance of FileStream.
            using (FileStream stream = new FileStream(dataDir, FileMode.Create))
            {
                // Create an instance of BmpOptions and set its various properties.
                BmpOptions saveOptions = new BmpOptions();
                saveOptions.BitsPerPixel = 32;
                saveOptions.Source = new StreamSource(stream);

                // Create an instance of Image.
                using (Image image = Image.Create(saveOptions, 100, 100))
                {
                    // Create and initialize an instance of the Graphics class and clear the graphics surface.
                    Graphics graphic = new Graphics(image);
                    graphic.Clear(Color.Yellow);

                    // Draw two dotted diagonal lines by specifying a Pen object with blue color and coordinate points.
                    graphic.DrawLine(new Pen(Color.Blue), 9, 9, 90, 90);
                    graphic.DrawLine(new Pen(Color.Blue), 9, 90, 90, 9);

                    // Draw four continuous lines by specifying Pen objects with solid brushes of various colors.
                    graphic.DrawLine(new Pen(new SolidBrush(Color.Red)), new Point(9, 9), new Point(9, 90));
                    graphic.DrawLine(new Pen(new SolidBrush(Color.Aqua)), new Point(9, 90), new Point(90, 90));
                    graphic.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(90, 90), new Point(90, 9));
                    graphic.DrawLine(new Pen(new SolidBrush(Color.White)), new Point(90, 9), new Point(9, 9));
                    image.Save();
                }
            }

            Console.WriteLine("Finished example DrawingLines");
        }
    }
}