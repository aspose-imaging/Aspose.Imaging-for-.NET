using System.IO;
using Aspose.Imaging.Brushes;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Sources;
using System;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API references when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information.
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, install it, and then add its reference to this project. For any issues, questions, or suggestions, please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.DrawingAndFormattingImages
{
    class DrawingRectangle
    {
        public static void Run()
        {
            Console.WriteLine("Running example DrawingRectangle");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DrawingAndFormattingImages() + "SampleRectangle_out.bmp";

            // Creates an instance of a FileStream.
            using (FileStream stream = new FileStream(dataDir, FileMode.Create))
            {
                // Create an instance of BmpOptions and set its various properties.
                BmpOptions saveOptions = new BmpOptions();
                saveOptions.BitsPerPixel = 32;

                // Set the source for BmpOptions and create an instance of Image.
                saveOptions.Source = new StreamSource(stream);
                using (Image image = Image.Create(saveOptions, 100, 100))
                {
                    // Creates and initializes an instance of the Graphics class, clears the graphics surface,
                    // draws rectangle shapes, and saves all changes.
                    Graphics graphic = new Graphics(image);
                    graphic.Clear(Color.Yellow);
                    graphic.DrawRectangle(new Pen(Color.Red), new Rectangle(30, 10, 40, 80));
                    graphic.DrawRectangle(new Pen(new SolidBrush(Color.Blue)), new Rectangle(10, 30, 80, 40));
                    image.Save();
                }
            }

            Console.WriteLine("Finished example DrawingRectangle");
        }
    }
}