using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Psd;
using Aspose.Imaging.FileFormats.Psd.Layers.FillLayers;
using Aspose.Imaging.FileFormats.Psd.Layers.FillSettings;
using Aspose.Imaging.FileFormats.Psd.Layers.LayerResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.ModifyingAndConvertingImages.PSD
{
    class SupportOfGdFlResource
    {
        public static void Run() {

            //ExStart:SupportOfGdFlResource
            string dataDir = RunExamples.GetDataDir_PSD();
            string sourceFileName = dataDir + "ComplexGradientFillLayer.psd";
            string exportPath = dataDir + "ComplexGradientFillLayer_after.psd";

            var im = (PsdImage)Image.Load(sourceFileName);

            using (im)
            {
                foreach (var layer in im.Layers)
                {
                    if (layer is FillLayer)
                    {
                        var fillLayer = (FillLayer)layer;

                        var resources = fillLayer.Resources;

                        foreach (var res in resources)
                        {
                            if (res is GdFlResource)
                            {
                                // Reading
                                var resource = (GdFlResource)res;

                                if (resource.AlignWithLayer != false ||
                                (Math.Abs(resource.Angle - 45.0) > 0.001) ||
                                resource.Dither != true ||
                                resource.Reverse != false ||
                                resource.Color != Color.Empty ||
                                Math.Abs(resource.HorizontalOffset - (-39)) > 0.001 ||
                                Math.Abs(resource.VerticalOffset - (-5)) > 0.001 ||
                                resource.TransparencyPoints.Length != 3 ||
                                resource.ColorPoints.Length != 2)
                                {
                                    throw new Exception("Resource Parameters were read wrong");
                                }

                                var transparencyPoints = resource.TransparencyPoints;

                                if (Math.Abs(100.0 - transparencyPoints[0].Opacity) > 0.25 ||
                                transparencyPoints[0].Location != 0 ||
                                transparencyPoints[0].MedianPointLocation != 50 ||
                                Math.Abs(50.0 - transparencyPoints[1].Opacity) > 0.25 ||
                                transparencyPoints[1].Location != 2048 ||
                                transparencyPoints[1].MedianPointLocation != 50 ||
                                Math.Abs(100.0 - transparencyPoints[2].Opacity) > 0.25 ||
                                transparencyPoints[2].Location != 4096 ||
                                transparencyPoints[2].MedianPointLocation != 50)
                                {
                                    throw new Exception("Gradient Transparency Points were read Wrong");
                                }

                                var colorPoints = resource.ColorPoints;

                                if (colorPoints[0].Color != Color.FromArgb(203, 64, 140) ||
                                colorPoints[0].Location != 0 ||
                                colorPoints[0].MedianPointLocation != 50 ||
                                colorPoints[1].Color != Color.FromArgb(203, 0, 0) ||
                                colorPoints[1].Location != 4096 ||
                                colorPoints[1].MedianPointLocation != 50)
                                {
                                    throw new Exception("Gradient Color Points were read Wrong");
                                }

                                // Editing
                                resource.Angle = 30.0;
                                resource.Dither = false;
                                resource.AlignWithLayer = true;
                                resource.Reverse = true;
                                resource.HorizontalOffset = 25;
                                resource.VerticalOffset = -15;

                                var newColorPoints = new List<IGradientColorPoint>(resource.ColorPoints);
                                var newTransparencyPoints = new List<IGradientTransparencyPoint>(resource.TransparencyPoints);

                                newColorPoints.Add(new GradientColorPoint()
                                {
                                    Color = Color.Violet,
                                    Location = 4096,
                                    MedianPointLocation = 75
                                });

                                colorPoints[1].Location = 3000;

                                newTransparencyPoints.Add(new GradientTransparencyPoint()
                                {
                                    Opacity = 80.0,
                                    Location = 4096,
                                    MedianPointLocation = 25
                                });

                                transparencyPoints[2].Location = 3000;

                                resource.ColorPoints = newColorPoints.ToArray();
                                resource.TransparencyPoints = newTransparencyPoints.ToArray();

                                im.Save(exportPath);
                            }

                            break;
                        }

                        break;
                    }
                }
            }

            //ExEnd:SupportOfGdFlResource

        }
    }
}
