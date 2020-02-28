using System.IO;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Sources;
using System;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
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

            // Creates an instance of FileStream
            using (FileStream stream = new FileStream(dataDir + "DrawingArc_out.bmp", FileMode.Create))
            {
                // Create an instance of BmpOptions and set its various properties
                BmpOptions saveOptions = new BmpOptions();
                saveOptions.BitsPerPixel = 32;

                // Set the Source for BmpOptions and create an instance of Image
                saveOptions.Source = new StreamSource(stream);               
                using (Image image = Image.Create(saveOptions, 100, 100))
                {
                    // Create and initialize an instance of Graphics class and clear Graphics surface
                    Graphics graphic = new Graphics(image);
                    graphic.Clear(Color.Yellow);

                    // Draw an arc shape by specifying the Pen object having red black color and coordinates, height, width, start & end angles                 
                    int width = 100;
                    int height = 200;
                    int startAngle = 45;
                    int sweepAngle = 270;

                    // Draw arc to screen and save all changes.
                    graphic.DrawArc(new Pen(Color.Black), 0, 0, width, height, startAngle, sweepAngle);
                    image.Save();
                }
                stream.Close();
            }

            Console.WriteLine("Finished example DrawingArc");
        }
    }
}