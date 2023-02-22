using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Png;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.PNG
{
    internal class KeepTransparencyWhenIndexingPngImage
    {
        public static void Run()
        {
            Console.WriteLine("Running example KeepTransparencyWhenIndexingPngImage");
            
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_PNG();

            using (RasterImage image = (RasterImage)Image.Load(dataDir + "template.png"))
            {
                PngOptions options = new PngOptions()
                {
                    CompressionLevel = 8,
                    ColorType = PngColorType.IndexedColor,
                    Palette = ColorPaletteHelper.GetCloseTransparentImagePalette(image, 256),
                    FilterType = PngFilterType.Avg,
                };

                image.Save(dataDir + "result.png", options);
            }

            File.Delete(dataDir + "result.png");

            Console.WriteLine("Finished example KeepTransparencyWhenIndexingPngImage");
        }
    }
}
