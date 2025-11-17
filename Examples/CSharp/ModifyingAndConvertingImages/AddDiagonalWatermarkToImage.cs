// GIST-ID: 2525b20829867ec754dc425533715c99
using Aspose.Imaging.Brushes;
using System;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference 
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it and then add its reference to this project. For any issues, questions, or suggestions, 
please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    public class AddDiagonalWatermarkToImage
    {
        public static void Run()
        {
            Console.WriteLine("Running example AddDiagonalWatermarkToImage");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Load an existing TIFF image.
            using (Image image = Image.Load(dataDir + "SampleTiff1.tiff"))
            {
                // Declare a string object with the watermark text.
                string theString = "45 Degree Rotated Text";

                // Create and initialize an instance of the Graphics class, and obtain the image size.
                Graphics graphics = new Graphics(image);
                SizeF sz = graphics.Image.Size;

                // Create an instance of Font, initializing it with the font face, size, and style.
                Font font = new Font("Times New Roman", 20, FontStyle.Bold);

                // Create an instance of SolidBrush and set its properties.
                SolidBrush brush = new SolidBrush();
                brush.Color = Color.Red;
                brush.Opacity = 0;

                // Initialize a StringFormat object and set its properties.
                StringFormat format = new StringFormat();
                format.Alignment = StringAlignment.Center;
                format.FormatFlags = StringFormatFlags.MeasureTrailingSpaces;

                // Create a Matrix object for transformation.
                Matrix matrix = new Matrix();

                // First translate, then rotate.
                matrix.Translate(sz.Width / 2, sz.Height / 2);
                matrix.Rotate(-45.0f);

                // Apply the transformation through the matrix.
                graphics.Transform = matrix;

                // Draw the string on the image and save the output to disk.
                graphics.DrawString(theString, font, brush, 0, 0, format);
                image.Save(dataDir + "AddDiagonalWatermarkToImage_out.jpg");
            }

            Console.WriteLine("Finished example AddDiagonalWatermarkToImage");
        }
    }
}