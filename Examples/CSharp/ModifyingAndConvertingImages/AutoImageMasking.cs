using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Png;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Masking;
using Aspose.Imaging.Masking.Options;
using Aspose.Imaging.Masking.Result;
using Aspose.Imaging.Sources;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace CSharp.ModifyingAndConvertingImages
{
    class AutoImageMasking
    {
        public static void Run()
        {

            //ExStart:AutoImageMasking
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            string sourceFileName = dataDir + "Colored by Faith_small.psd";
            string inputPointsFileName = dataDir + "Colored by Faith_small.dat";
            AutoMaskingArgs maskingArgs = new AutoMaskingArgs();
            FillInputPoints(inputPointsFileName, maskingArgs);
            string outputFileName = dataDir + "Colored by Faith_small_auto.png";
            using (RasterImage image = (RasterImage)Image.Load(sourceFileName))
            {
                MaskingOptions maskingOptions = new MaskingOptions()
                {
                    Method = SegmentationMethod.GraphCut,
                    Args = maskingArgs,
                    Decompose = false,
                    ExportOptions =
                  new PngOptions()
                  {
                      ColorType = PngColorType.TruecolorWithAlpha,
                      Source = new StreamSource(new MemoryStream())
                  },
                };
                MaskingResult[] maskingResults = new ImageMasking(image).Decompose(maskingOptions);
                using (Image resultImage = maskingResults[1].GetImage())
                {
                    resultImage.Save(outputFileName);
                }
            }



            //ExEnd:AutoImageMasking

        }

        //ExStart:FillInputPoints
        private static void FillInputPoints(string filePath, AutoMaskingArgs autoMaskingArgs)
        {
            BinaryFormatter serializer = new BinaryFormatter();
            using (Stream stream = File.OpenRead(filePath))
            {
                bool hasObjectRectangles = (bool)serializer.Deserialize(stream);
                bool hasObjectPoints = (bool)serializer.Deserialize(stream);
                autoMaskingArgs.ObjectsRectangles = null;
                autoMaskingArgs.ObjectsPoints = null;

                if (hasObjectRectangles)
                {
                    autoMaskingArgs.ObjectsRectangles = ((System.Drawing.Rectangle[])serializer.Deserialize(stream))
                        .Select(rect => new Aspose.Imaging.Rectangle(rect.X, rect.Y, rect.Width, rect.Height))
                        .ToArray();
                }

                if (hasObjectPoints)
                {
                    autoMaskingArgs.ObjectsPoints = ((System.Drawing.Point[][])serializer.Deserialize(stream))
                        .Select(pointArray => pointArray
                            .Select(point => new Aspose.Imaging.Point(point.X, point.Y))
                            .ToArray())
                        .ToArray();
                }
            }
        }
        //ExEnd:FillInputPoints
    }
}
