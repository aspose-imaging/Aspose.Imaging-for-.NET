using Aspose.Imaging.Examples.CSharp;
using System;
using System.IO;
using System.Xml.Linq;
using Aspose.Imaging;
using Aspose.Imaging.ImageOptions;

namespace CSharp.ModifyingAndConvertingImages.PNG
{
    internal class AddAlphaBlendingForImage
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_PNG();

            Console.WriteLine("Running example AddAlphaBlendingForImage");

            using (var background = Aspose.Imaging.Image.Load(Path.Combine(dataDir, @"image0.png")) as RasterImage)
            {
                using (var overlay = Image.Load(Path.Combine(dataDir, @"aspose_logo.png")) as RasterImage)
                {
                    var center = new Point((background.Width - overlay.Width) / 2, (background.Height - overlay.Height) / 2);
                    background.Blend(center, overlay, overlay.Bounds, 127);
                    background.Save(Path.Combine(dataDir, @"blended.png"), new PngOptions() { ColorType = Aspose.Imaging.FileFormats.Png.PngColorType.TruecolorWithAlpha});
                    File.Delete(Path.Combine(dataDir, @"blended.png"));
                }
            }

            Console.WriteLine("Finished example AddAlphaBlendingForImage");
        }
    }
}
