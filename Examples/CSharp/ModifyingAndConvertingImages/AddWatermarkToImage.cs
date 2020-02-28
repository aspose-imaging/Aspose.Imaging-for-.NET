using System;
using Aspose.Imaging.Brushes;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
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

            // Create an instance of Image and load an existing image
            using (Image image = Image.Load(dataDir + "WaterMark.bmp"))
            {
                // Create and initialize an instance of Graphics class
                Graphics graphics = new Graphics(image);

                // Creates an instance of Font
                Font font = new Font("Times New Roman", 16, FontStyle.Bold);

                // Create an instance of SolidBrush and set its various properties
                SolidBrush brush = new SolidBrush();
                brush.Color = Color.Black;
                brush.Opacity = 100;

                // Draw a String using the SolidBrush object and Font, at specific Point and Save the image with changes.
                graphics.DrawString("Aspose.Imaging for .Net", font, brush, new PointF(image.Width / 2, image.Height / 2));
                image.Save(dataDir + "AddWatermarkToImage_out.bmp");                
            }

            Console.WriteLine("Finished example AddWatermarkToImage");
        }
    }
}