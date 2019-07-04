using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Psd;
using Aspose.Imaging.FileFormats.Psd.Layers.FillLayers;
using Aspose.Imaging.FileFormats.Psd.Layers.FillSettings;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.ModifyingAndConvertingImages.PSD
{
    class SupportOfGradientFillLayer
    {
        public static void Run()
        {

            //ExStart:SupportOfGradientFillLayer
            string dataDir = RunExamples.GetDataDir_PSD();
            string sourceFileName = dataDir + "ComplexGradientFillLayer.psd";
            string outputFile = dataDir + "ComplexGradientFillLayer_output.psd";

            var im = (PsdImage)Image.Load(sourceFileName);

            using (im)
            {
                foreach (var layer in im.Layers)
                {
                    if (layer is FillLayer)
                    {
                        var fillLayer = (FillLayer)layer;

                        if (fillLayer.FillSettings.FillType != FillType.Gradient)
                        {
                            throw new Exception("Wrong Fill Layer");
                        }

                        var settings = (IGradientFillSettings)fillLayer.FillSettings;

                        if (
                            Math.Abs(settings.Angle - 45) > 0.25 ||
                            settings.Dither != true ||
                            settings.AlignWithLayer != false ||
                            settings.Reverse != false ||
                            Math.Abs(settings.HorizontalOffset - (-39)) > 0.25 ||
                            Math.Abs(settings.VerticalOffset - (-5)) > 0.25 ||
                            settings.TransparencyPoints.Length != 3 ||
                            settings.ColorPoints.Length != 2 ||
                            Math.Abs(100.0 - settings.TransparencyPoints[0].Opacity) > 0.25 ||
                            settings.TransparencyPoints[0].Location != 0 ||
                            settings.TransparencyPoints[0].MedianPointLocation != 50 ||
                            settings.ColorPoints[0].Color != Color.FromArgb(203, 64, 140) ||
                            settings.ColorPoints[0].Location != 0 ||
                            settings.ColorPoints[0].MedianPointLocation != 50)
                        {
                            throw new Exception("Gradient Fill was not read correctly");
                        }

                        settings.Angle = 0.0;
                        settings.Dither = false;
                        settings.AlignWithLayer = true;
                        settings.Reverse = true;
                        settings.HorizontalOffset = 25;
                        settings.VerticalOffset = -15;

                        var colorPoints = new List<IGradientColorPoint>(settings.ColorPoints);
                        var transparencyPoints = new List<IGradientTransparencyPoint>(settings.TransparencyPoints);

                        colorPoints.Add(new GradientColorPoint()
                        {
                            Color = Color.Violet,
                            Location = 4096,
                            MedianPointLocation = 75
                        });

                        colorPoints[1].Location = 3000;

                        transparencyPoints.Add(new GradientTransparencyPoint()
                        {
                            Opacity = 80.0,
                            Location = 4096,
                            MedianPointLocation = 25
                        });

                        transparencyPoints[2].Location = 3000;

                        settings.ColorPoints = colorPoints.ToArray();
                        settings.TransparencyPoints = transparencyPoints.ToArray();
                        fillLayer.Update();

                        im.Save(outputFile, new PsdOptions(im));

                        break;
                    }
                }
            }


            //ExEnd:SupportOfGradientFillLayer
        }
    }
}
