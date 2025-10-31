using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Png;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Masking;
using Aspose.Imaging.Masking.Options;
using Aspose.Imaging.Masking.Result;
using Aspose.Imaging.Shapes;
using Aspose.Imaging.Sources;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CSharp.ModifyingAndConvertingImages
{
    class ManualImageMasking
    {
        public static void Run()
        {
            //ExStart:ManualImageMasking
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            Console.WriteLine("Running the example ManualImageMasking");
            string sourceFileName = dataDir + "Colored by Faith_small.png";
            string outputFileName = dataDir + "Colored by Faith_small_manual.png";
            GraphicsPath manualMask = new GraphicsPath();
            Figure firstFigure = new Figure();
            firstFigure.AddShape(new EllipseShape(new RectangleF(100, 30, 40, 40)));
            firstFigure.AddShape(new RectangleShape(new RectangleF(10, 200, 50, 30)));
            manualMask.AddFigure(firstFigure);
            GraphicsPath subPath = new GraphicsPath();
            Figure secondFigure = new Figure();
            secondFigure.AddShape(
                new PolygonShape(
                    new PointF[] { new PointF(310, 100), new PointF(350, 200), new PointF(250, 200) },
                    true));
            secondFigure.AddShape(new PieShape(new RectangleF(10, 10, 80, 80), 30, 120));
            subPath.AddFigure(secondFigure);
            manualMask.AddPath(subPath);
            using (RasterImage image = (RasterImage)Image.Load(sourceFileName))
            {
                MaskingOptions maskingOptions = new MaskingOptions()
                {
                    Method = SegmentationMethod.Manual,
                    Args = new ManualMaskingArgs
                    {
                        Mask = manualMask
                    },
                    Decompose = false,
                    ExportOptions = new PngOptions()
                    {
                        ColorType = PngColorType.TruecolorWithAlpha,
                        Source = new StreamSource(new MemoryStream())
                    },
                };
                MaskingResult maskingResults = new ImageMasking(image).Decompose(maskingOptions);
                using (Image resultImage = maskingResults[1].GetImage())
                {
                    resultImage.Save(outputFileName);
                }
            }

            Console.WriteLine("Finished the example ManualImageMasking");
        }
    }
}