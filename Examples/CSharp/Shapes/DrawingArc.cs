using System.IO;

using Aspose.Imaging;

namespace Aspose.Imaging.Examples.Shapes
{
    public class DrawingArc
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = Aspose.Imaging.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

			// Create directory if it is not already present.
            bool IsExists = System.IO.Directory.Exists(dataDir);
            if (!IsExists)
                System.IO.Directory.CreateDirectory(dataDir);
				
            //Creates an instance of FileStream
            using (System.IO.FileStream stream = new System.IO.FileStream(dataDir + "outputarc.bmp", System.IO.FileMode.Create))
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

                    //Draw an arc shape by specifying the Pen object having red black color and coordinates, height, width, start & end angles                 
                    int width = 100;
                    int height = 200;
                    int startAngle = 45;
                    int sweepAngle = 270;

                    // Draw arc to screen.
                    graphic.DrawArc(new Pen(Color.Black), 0, 0, width, height, startAngle, sweepAngle);

                    // save all changes.
                    image.Save();
                }

                stream.Close();
            }

        }
    }
}