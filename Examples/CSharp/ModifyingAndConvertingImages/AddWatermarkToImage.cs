using System;
using Aspose.Imaging.Brushes;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API references when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information.
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, install it, and then add its reference to this project. For any issues, questions, or suggestions, please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    public class AddWatermarkToImage
    {
        public static void Run()
        {
            Console.WriteLine("Running example AddWatermarkToImage");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Create an instance of Image and load an existing image.
            using (Image image = Image.Load(dataDir + "WaterMark.bmp"))
            {
                // Create and initialize an instance of the Graphics class.
                Graphics graphics = new Graphics(image);

                // Create an instance of Font.
                Font font = new Font("Times New Roman", 16, FontStyle.Bold);

                // Create an instance of SolidBrush and set its properties.
                SolidBrush brush = new SolidBrush();
                brush.Color = Color.Black;
                brush.Opacity = 100;

                // Draw a string using the SolidBrush and Font at a specific point, then save the image with the changes.
                graphics.DrawString("Aspose.Imaging for .Net", font, brush, new PointF(image.Width / 2, image.Height / 2));
                image.Save(dataDir + "AddWatermarkToImage_out.bmp");
            }

            Console.WriteLine("Finished example AddWatermarkToImage");
        }
    }
}