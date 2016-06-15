using System.IO;

using Aspose.Imaging;

namespace Aspose.Imaging.Examples.CSharp.Shapes
{
    public class DrawingBezier
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Shapes("DrawingBezier");

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

                    //Initializes the instance of PEN class with black color and width
                    Pen BlackPen = new Pen(Color.Black, 3);

                    float startX = 10;
                    float startY = 25;
                    float controlX1 = 20;
                    float controlY1 = 5;
                    float controlX2 = 55;
                    float controlY2 = 10;
                    float endX = 90;
                    float endY = 25;


                    //Draw a Bezier shape by specifying the Pen object having black color and co-ordinate Points
                    graphic.DrawBezier(BlackPen, startX, startY, controlX1, controlY1, controlX2, controlY2, endX, endY);



                    // save all changes.
                    image.Save();
                }
            }

        }
    }
}