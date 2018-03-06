using System.IO;
using Aspose.Imaging.Brushes;
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
    class DrawingRectangle
    {
        public static void Run()
        {
            //ExStart:DrawingRectangle
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DrawingAndFormattingImages() + "SampleRectangle_out.bmp";

            // Creates an instance of FileStream
            using (FileStream stream = new FileStream(dataDir, FileMode.Create))
            {
                // Create an instance of BmpOptions and set its various properties
                BmpOptions saveOptions = new BmpOptions();
                saveOptions.BitsPerPixel = 32;

                // Set the Source for BmpOptions and Create an instance of Image
                saveOptions.Source = new StreamSource(stream);
                using (Image image = Image.Create(saveOptions, 100, 100))
                {
                    // Create and initialize an instance of Graphics class,  Clear Graphics surface, Draw a rectangle shapes and  save all changes.
                    Graphics graphic = new Graphics(image);
                    graphic.Clear(Color.Yellow);
                    graphic.DrawRectangle(new Pen(Color.Red), new Rectangle(30, 10, 40, 80));
                    graphic.DrawRectangle(new Pen(new SolidBrush(Color.Blue)), new Rectangle(10, 30, 80, 40));
                    image.Save();
                }
            }
            //ExEnd:DrawingRectangle
        }
    }
}
