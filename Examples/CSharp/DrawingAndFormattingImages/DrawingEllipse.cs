using System.IO;
using Aspose.Imaging.Brushes;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Sources;
using System;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API references 
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it, and then add its reference to this project. For any issues, questions, or suggestions 
please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.DrawingAndFormattingImages
{
    public class DrawingEllipse
    {
        public static void Run()
        {
            Console.WriteLine("Running example DrawingEllipse");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DrawingAndFormattingImages();

            // Creates an instance of FileStream
            using (FileStream stream = new FileStream(dataDir + "DrawingEllipse_out.bmp", FileMode.Create))
            {
                // Create an instance of BmpOptions and set its various properties
                BmpOptions saveOptions = new BmpOptions();
                saveOptions.BitsPerPixel = 32;
                saveOptions.Source = new StreamSource(stream);

                // Create an instance of Image
                using (Image image = Image.Create(saveOptions, 100, 100))
                {
                    // Create and initialize an instance of the Graphics class and clear the graphics surface
                    Graphics graphic = new Graphics(image);
                    graphic.Clear(Color.Yellow);

                    // Draw a dotted ellipse using a Pen object with red color and a surrounding rectangle
                    graphic.DrawEllipse(new Pen(Color.Red), new Rectangle(30, 10, 40, 80));

                    // Draw a continuous ellipse using a Pen object with a solid blue brush and a surrounding rectangle
                    graphic.DrawEllipse(new Pen(new SolidBrush(Color.Blue)), new Rectangle(10, 30, 80, 40));
                    image.Save();
                }
                stream.Close();
            }

            Console.WriteLine("Finished example DrawingEllipse");
        }
    }
}