using System.IO;

using Aspose.Imaging;

namespace Aspose.Imaging.Examples.CSharp.Shapes
{
    public class DrawingEllipse
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Shapes("DrawingEllipse");

			// Create directory if it is not already present.
            bool IsExists = System.IO.Directory.Exists(dataDir);
            if (!IsExists)
                System.IO.Directory.CreateDirectory(dataDir);
				
            //Creates an instance of FileStream
            using (System.IO.FileStream stream = new System.IO.FileStream(dataDir + "output.bmp", System.IO.FileMode.Create))
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

                    //Draw a dotted ellipse shape by specifying the Pen object having red color and a surrounding Rectangle
                    graphic.DrawEllipse(new Pen(Color.Red), new Rectangle(30, 10, 40, 80));

                    //Draw a continuous ellipse shape by specifying the Pen object having solid brush with blue color and a surrounding Rectangle
                    graphic.DrawEllipse(new Pen(new Aspose.Imaging.Brushes.SolidBrush(Color.Blue)), new Rectangle(10, 30, 80, 40));

                    // save all changes.
                    image.Save();
                }
                stream.Close();
            }
        }
    }
}