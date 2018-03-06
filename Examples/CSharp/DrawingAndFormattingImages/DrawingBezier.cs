using System.IO;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Sources;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.DrawingAndFormattingImages
{
    public class DrawingBezier
    {
        public static void Run()
        {
            //ExStart:DrawingBezier
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DrawingAndFormattingImages();
 
            // Creates an instance of FileStream
            using (FileStream stream = new FileStream(dataDir + "DrawingBezier_out.bmp", FileMode.Create))
            {
                // Create an instance of BmpOptions and set its various properties
                BmpOptions saveOptions = new BmpOptions();
                saveOptions.BitsPerPixel = 32;

                // Set the Source for BmpOptions and Create an instance of Image
                saveOptions.Source = new StreamSource(stream);
                using (Image image = Image.Create(saveOptions, 100, 100))
                {
                    // Create and initialize an instance of Graphics class and clear Graphics surface
                    Graphics graphic = new Graphics(image);
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

                    // Draw a Bezier shape by specifying the Pen object having black color and co-ordinate Points and save all changes.
                    graphic.DrawBezier(BlackPen, startX, startY, controlX1, controlY1, controlX2, controlY2, endX, endY);
                    image.Save();
                }
            }
            //ExEnd:DrawingBezier
        }
    }
}