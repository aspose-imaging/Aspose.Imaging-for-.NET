using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.MagicWand.ImageMasks;
using Aspose.Imaging.MagicWand;
using Aspose.Imaging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Imaging.FileFormats.Png;
using Aspose.Imaging.Shapes;
using Aspose.Imaging.Watermark.Options;
using Aspose.Imaging.Watermark;

namespace CSharp.ModifyingAndConvertingImages
{
    internal class RemoveWatermarkFilter
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_PNG();

            Console.WriteLine("Running example RemoveWatermarkFilter");

            using (var image = Image.Load(Path.Combine(dataDir, @"ball.png")))
            {
                var pngImage = (PngImage)image;

                var mask = new GraphicsPath();
                var firstFigure = new Figure();
                firstFigure.AddShape(new EllipseShape(new RectangleF(350, 170, 570 - 350, 400 - 170)));
                mask.AddFigure(firstFigure);

                var options = new ContentAwareFillWatermarkOptions(mask)
                {
                    MaxPaintingAttempts = 1
                };

                var result = WatermarkRemover.PaintOver(pngImage, options);

                result.Save(Path.Combine(dataDir, @"result.png"));
                File.Delete(Path.Combine(dataDir, @"result.png"));
            }

            Console.WriteLine("Finished example RemoveWatermarkFilter");
        }
    }
}