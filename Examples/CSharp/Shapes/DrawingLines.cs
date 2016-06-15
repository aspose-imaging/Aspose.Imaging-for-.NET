using System.IO;

using Aspose.Imaging;

namespace Aspose.Imaging.Examples.CSharp.Shapes
{
    public class DrawingLines
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Shapes("DrawingLines");

			// Create directory if it is not already present.
            bool IsExists = System.IO.Directory.Exists(dataDir);
            if (!IsExists)
                System.IO.Directory.CreateDirectory(dataDir);
				
            //Creates an instance of FileStream
            using (System.IO.FileStream stream = new System.IO.FileStream(dataDir + "outputlines.bmp", System.IO.FileMode.Create))
            {
                //Create an instance of BmpOptions and set its various properties
                Aspose.Imaging.ImageOptions.BmpOptions saveOptions = new Aspose.Imaging.ImageOptions.BmpOptions();
                saveOptions.BitsPerPixel = 32;

                //Set the Source for BmpOptions
                saveOptions.Source = new Aspose.Imaging.Sources.StreamSource(stream);

                //Create an instance of Image
                using (Aspose.Imaging.Image image = Aspose.Imaging.Image.Create(saveOptions, 100, 100))
                {
                    //Create and initialize an instance of Graphics class
                    Aspose.Imaging.Graphics graphic = new Aspose.Imaging.Graphics(image);

                    //Clear Graphics surface
                    graphic.Clear(Color.Yellow);

                    //Draw two dotted diagonal lines by specifying the Pen object having blue color and co-ordinate Points
                    graphic.DrawLine(new Pen(Color.Blue), 9, 9, 90, 90);
                    graphic.DrawLine(new Pen(Color.Blue), 9, 90, 90, 9);

                    //Draw a continuous line by specifying the Pen object having Solid Brush with red color and two point structures
                    graphic.DrawLine(new Pen(new Aspose.Imaging.Brushes.SolidBrush(Color.Red)), new Point(9, 9), new Point(9, 90));

                    //Draw a continuous line by specifying the Pen object having Solid Brush with aqua color and two point structures
                    graphic.DrawLine(new Pen(new Aspose.Imaging.Brushes.SolidBrush(Color.Aqua)), new Point(9, 90), new Point(90, 90));

                    //Draw a continuous line by specifying the Pen object having Solid Brush with black color and two point structures
                    graphic.DrawLine(new Pen(new Aspose.Imaging.Brushes.SolidBrush(Color.Black)),
                    new Point(90, 90), new Point(90, 9));

                    //Draw a continuous line by specifying the Pen object having Solid Brush with white color and two point structures
                    graphic.DrawLine(new Pen(new Aspose.Imaging.Brushes.SolidBrush(Color.White))
                                       , new Point(90, 9), new Point(9, 9));


                    // save all changes.
                    image.Save();
                }
            }
        }
    }
}