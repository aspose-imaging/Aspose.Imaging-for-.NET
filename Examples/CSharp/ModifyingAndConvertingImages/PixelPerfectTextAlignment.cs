using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages
{
    class PixelPerfectTextAlignment
    {
        public static void Run()
        {
            Console.WriteLine("Running example PixelPerfectTextAlignment");

            string baseFolder = RunExamples.GetDataDir_CDR();
            string[] alignments = new[] { "Left", "Center", "Right" };
            foreach (var alignment in alignments)
            {
                DrawString(baseFolder, alignment);
            }

            Console.WriteLine("Finished example PixelPerfectTextAlignment");
        }

        private static void DrawString(string baseFolder, string align)
        {
            string fileName = "output_" + align + ".png";
            string outputFileName = Path.Combine(baseFolder, fileName);
            string[] fontNames = new[]
            {
                "Arial", "Times New Roman",
                "Bookman Old Style", "Calibri", "Comic Sans MS",
                "Courier New", "Microsoft Sans Serif", "Tahoma",
                "Verdana", "Proxima Nova Rg"
            };

            float[] fontSizes = new[] { 10f, 22f, 50f, 100f };
            int width = 3000;
            int height = 3500;

            using (System.IO.FileStream stream =
              new System.IO.FileStream(outputFileName, System.IO.FileMode.Create))
            {
                // Create an instance of PngOptions and set its various properties
                Aspose.Imaging.ImageOptions.PngOptions pngOptions
                    = new Aspose.Imaging.ImageOptions.PngOptions();

                // Set the source for PngOptions
                pngOptions.Source = new Aspose.Imaging.Sources.StreamSource(stream);

                // Create an instance of Image
                using (Aspose.Imaging.Image image
                   = Aspose.Imaging.Image.Create(pngOptions, width, height))
                {
                    // Create and initialize an instance of Graphics class
                    Aspose.Imaging.Graphics graphics = new Aspose.Imaging.Graphics(image);

                    // Clear graphics surface
                    graphics.Clear(Aspose.Imaging.Color.White);

                    // Create a SolidBrush object and set its various properties
                    Aspose.Imaging.Brushes.SolidBrush brush
                       = new Aspose.Imaging.Brushes.SolidBrush();
                    brush.Color = Color.Black;
                    float x = 10;
                    int lineX = 0;
                    float y = 10;
                    float w = width - 20;
                    var pen = new Pen(Color.Red, 1);

                    StringAlignment alignment = StringAlignment.Near;
                    switch (align)
                    {
                        case "Left":
                            alignment = StringAlignment.Near;
                            lineX = (int)Math.Round(x, 0);
                            break;

                        case "Center":
                            alignment = StringAlignment.Center;
                            lineX = (int)Math.Round(x + w / 2f, 0);
                            break;

                        case "Right":
                            alignment = StringAlignment.Far;
                            lineX = (int)(x + w);
                            break;
                    }

                    var stringFormat = new StringFormat(StringFormatFlags.ExactAlignment);
                    stringFormat.Alignment = alignment;
                    foreach (var fontName in fontNames)
                    {
                        foreach (var fontSize in fontSizes)
                        {
                            var font = new Font(fontName, fontSize);
                            string text = String.Format("This is font: {0}, size:{1}", fontName, fontSize);
                            var s = graphics.MeasureString(text, font, SizeF.Empty, null);
                            graphics.
                             DrawString(text, font, brush, new RectangleF(x, y, w, s.Height), stringFormat);

                            y += s.Height;
                        }

                        graphics.DrawLine(pen, new Point((int)(x), (int)y), new Point((int)(x + w), (int)y));
                    }

                    graphics.DrawLine(pen, new Point(lineX, 0), new Point(lineX, (int)y));

                    // Save all changes.
                    image.Save();
                }
            }

            File.Delete(outputFileName);
        }
    }
}