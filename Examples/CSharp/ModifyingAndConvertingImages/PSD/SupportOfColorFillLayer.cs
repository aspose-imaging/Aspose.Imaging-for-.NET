using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Psd;
using Aspose.Imaging.FileFormats.Psd.Layers.FillLayers;
using Aspose.Imaging.FileFormats.Psd.Layers.FillSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.ModifyingAndConvertingImages.PSD
{
    class SupportOfColorFillLayer
    {

        public static void Run() {

            //ExStart:SupportOfColorFillLayer
            string dataDir = RunExamples.GetDataDir_PSD();


            string sourceFileName = dataDir+ "ColorFillLayer.psd";
            string exportPath = dataDir + "ColorFillLayer_output.psd";
            string exportPathPng = dataDir + "ColorFillLayer_output.png";

            var im = (PsdImage)Image.Load(sourceFileName);

            using (im)
            {
                foreach (var layer in im.Layers)
                {
                    if (layer is FillLayer)
                    {
                        var fillLayer = (FillLayer)layer;

                        if (fillLayer.FillSettings.FillType != FillType.Color)
                        {
                            throw new Exception("Wrong Fill Layer");
                        }

                        var settings = (IColorFillSettings)fillLayer.FillSettings;

                        settings.Color = Color.Red;
                        fillLayer.Update();
                        im.Save(exportPath);
                        break;
                    }
                }
            }

            //ExEnd:SupportOfColorFillLayer
        }
    }
}
