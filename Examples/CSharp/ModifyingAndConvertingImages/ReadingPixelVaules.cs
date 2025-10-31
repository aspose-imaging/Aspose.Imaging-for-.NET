using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.ModifyingAndConvertingImages
{
    class ReadingPixelVaules
    {
        public static void Run()
        {
            // ExStart:ReadingPixelValues
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();
            // string dir = @"c:\aspose.work\IMAGINGNET\2934\";
            string fileName = "16bit Uncompressed, BigEndian, Rgb, Contiguous Gamma1.0.tif";

            // ICC profile is not applied for 16‑bit color components at the moment, so disable that option explicitly.
            LoadOptions loadOptions = new LoadOptions();
            loadOptions.UseIccProfileConversion = false;

            Rectangle desiredArea = new Rectangle(470, 1350, 30, 30);

            using (RasterImage image = (RasterImage)Image.Load(dataDir + fileName, loadOptions))
            {
                long[] colors64Bit = image.LoadArgb64Pixels(image.Bounds);

                ushort alpha, red, green, blue;
                for (int y = desiredArea.Top; y < desiredArea.Bottom; ++y)
                {
                    for (int x = desiredArea.Left; x < desiredArea.Right; ++x)
                    {
                        int offset = y * image.Width + x;
                        long color64 = colors64Bit[offset];

                        alpha = (ushort)((color64 >> 48) & 0xffff);
                        red = (ushort)((color64 >> 32) & 0xffff);
                        green = (ushort)((color64 >> 16) & 0xffff);
                        blue = (ushort)(color64 & 0xffff);

                        Console.WriteLine("A={0}, R={1}, G={2}, B={3}", alpha, red, green, blue);
                    }
                }
            }
            // ExEnd:ReadingPixelValues
        }
    }
}