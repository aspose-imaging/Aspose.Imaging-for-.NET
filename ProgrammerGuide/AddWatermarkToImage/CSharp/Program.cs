//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Imaging. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Imaging;

namespace AddWatermarkToImage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //Create an instance of Image and load an existing image.
            using (Image image = Image.Load(dataDir + "sample.bmp"))
            {
                //Create and initialize an instance of Graphics class.
                Graphics graphics = new Graphics(image);

                //Creates an instance of Font.
                Aspose.Imaging.Font font = new Aspose.Imaging.Font("Times New Roman", 16, FontStyle.Bold);

                //Create an instance of SolidBrush and set its various properties.
                Aspose.Imaging.Brushes.SolidBrush brush = new Aspose.Imaging.Brushes.SolidBrush();
                brush.Color = Color.Black;
                brush.Opacity = 100;

                //Draw a String using the SolidBrush object and Font, at specific Point.
                graphics.DrawString("Aspose.Imaging for .Net", font, brush, new PointF(image.Width / 2, image.Height / 2));

                // save the image with changes.
                image.Save(dataDir + "out.bmp");

                // Display Status.
                System.Console.WriteLine("Watermark added successfully.");
            }
        }
    }
}