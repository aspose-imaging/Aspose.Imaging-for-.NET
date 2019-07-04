using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Png;
using Aspose.Imaging.FileFormats.Psd;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.ModifyingAndConvertingImages.PSD
{
    class RenderingOfRotatedTextLayerByTransformMatrix
    {

        public static void Run() {

            //ExStart:RenderingOfRotatedTextLayerByTransformMatrix
            string dataDir = RunExamples.GetDataDir_PSD();

            string sourceFileName = dataDir + "TransformedText.psd";
            string exportPath = dataDir + "TransformedTextExport.psd";
            string exportPathPng = dataDir +  "TransformedTextExport.png";

            var im = (PsdImage)Image.Load(sourceFileName);

            using (im)
            {
                im.Save(exportPath);
                im.Save(exportPathPng, new PngOptions() { ColorType = PngColorType.TruecolorWithAlpha });
            }
            //ExEnd:RenderingOfRotatedTextLayerByTransformMatrix

        }
    }
}
