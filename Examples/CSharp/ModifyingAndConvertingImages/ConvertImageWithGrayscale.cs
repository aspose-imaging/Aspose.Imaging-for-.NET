using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aspose.Imaging.Exif;
using Aspose.Imaging.FileFormats.Jpeg;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging;
using Aspose.Imaging.ImageOptions;
namespace CSharp.ModifyingAndConvertingImages
{
    class ConvertImageWithGrayscale
    {
        public static void Run()
        {
            Console.WriteLine("Running example ConvertImageWithGrayscale");

            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            JpegCompressionColorMode[] colorTypes = new JpegCompressionColorMode[]
            {
               JpegCompressionColorMode.Grayscale,
               JpegCompressionColorMode.YCbCr,
               JpegCompressionColorMode.Rgb,
               JpegCompressionColorMode.Cmyk,
               JpegCompressionColorMode.Ycck,
            };

            string[] sourceFileNames = new string[]
           {
              "Grayscale.jpg",
              "Grayscale.jpg",
              "Grayscale.jpg",
              "Grayscale.jpg",
              "Grayscale.jpg",
            };

            JpegOptions options = new JpegOptions();
            options.BitsPerChannel = 12;

            for (int i = 0; i < colorTypes.Length; ++i)
            {
                options.ColorType = colorTypes[i];
                string fileName = colorTypes[i] + " 12-bit.jpg";
                using (Image image = Image.Load(dataDir + sourceFileNames[i]))
                {
                    image.Save(dataDir + fileName, options);
                }
            }

            Console.WriteLine("Finished example ConvertImageWithGrayscale");
        }

    }
}
