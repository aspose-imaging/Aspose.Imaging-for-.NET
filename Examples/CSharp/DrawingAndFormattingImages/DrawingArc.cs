using System;
using System.IO;
using Aspose.Imaging;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Sources;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information.
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/,
install it, and then add its reference to this project. For any issues, questions, or suggestions,
please feel free to contact us via https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.DrawingAndFormattingImages
{
    public class DrawingArc
    {
        public static void Run()
        {
            Console.WriteLine("Running example DrawingArc");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DrawingAndFormattingImages();

            // Creates an instance of FileStream.
            using (FileStream stream = new FileStream(dataDir + "DrawingArc_out.bmp", FileMode.Create))
            {
                // Create an instance of BmpOptions and set its various properties.
                BmpOptions saveOptions = new BmpOptions();
                saveOptions.BitsPerPixel = 32;

                // Set the source for BmpOptions and create an instance of Image.
                saveOptions.Source = new StreamSource(stream);
                using (Image image = Image.Create(saveOptions, 100, 100))
                {
                    // Create and initialize an instance of Graphics and clear the surface.
                    Graphics graphic = new Graphics(image);
                    graphic.Clear(Color.Yellow);

                    // Draw an arc shape by specifying a Pen object with black color and the coordinates,
                    // height, width, start angle, and sweep angle.
                    int width = 100;
                    int height = 200;
                    int startAngle = 45;
                    int sweepAngle = 270;

                    // Draw the arc and save all changes.
                    graphic.DrawArc(new Pen(Color.Black), 0, 0, width, height, startAngle, sweepAngle);
                    image.Save();
                }
                stream.Close();
            }

            Console.WriteLine("Finished example DrawingArc");
        }
    }
}