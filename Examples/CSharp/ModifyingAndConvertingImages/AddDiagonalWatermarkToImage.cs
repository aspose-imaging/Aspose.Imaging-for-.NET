using Aspose.Imaging.Brushes;
using System;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
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

            // Load an existing JPG image
            using (Image image = Image.Load(dataDir + "SampleTiff1.tiff"))
            {
                // Declare a String object with Watermark Text
                string theString = "45 Degree Rotated Text";

                // Create and initialize an instance of Graphics class and Initialize an object of SizeF to store image Size
                Graphics graphics = new Graphics(image);
                SizeF sz = graphics.Image.Size;

                // Creates an instance of Font, initialize it with Font Face, Size and Style
                Font font = new Font("Times New Roman", 20, FontStyle.Bold);

                // Create an instance of SolidBrush and set its various properties
                SolidBrush brush = new SolidBrush();
                brush.Color = Color.Red;
                brush.Opacity = 0;

                // Initialize an object of StringFormat class and set its various properties
                StringFormat format = new StringFormat();
                format.Alignment = StringAlignment.Center;
                format.FormatFlags = StringFormatFlags.MeasureTrailingSpaces;

                // Create an object of Matrix class for transformation
                Matrix matrix = new Matrix();

                // First a translation then a rotation                
                matrix.Translate(sz.Width / 2, sz.Height / 2);             
                matrix.Rotate(-45.0f);

                // Set the Transformation through Matrix
                graphics.Transform = matrix;

                // Draw the string on Image Save output to disk
                graphics.DrawString(theString, font, brush, 0, 0, format);
                image.Save(dataDir + "AddDiagonalWatermarkToImage_out.jpg");
            }

            Console.WriteLine("Finished example AddDiagonalWatermarkToImage");
        }
    }
}