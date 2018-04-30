using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Psd;
using System.Diagnostics;

namespace CSharp.ModifyingAndConvertingImages.PSD
{
    class SupportLayerForPSD
    {
        public static void Run() {
            //ExStart:SupportLayerForPSD
            string sourceFileName = "dropShadow.psd";
            string output = "dropShadow.png";

            using (
                   PsdImage image =
                                    (PsdImage)
                                    Aspose.Imaging.Image.Load(
                                        sourceFileName,
                                        new Aspose.Imaging.ImageLoadOptions.PsdLoadOptions()
                                        {
                                            LoadEffectsResource = true,
                                            UseDiskForLoadEffectsResource = true
                                        }))
            {
                Debug.Assert(image.Layers[2] != null, "Layer with effects resource was not recognized");

                image.Save(output, new Aspose.Imaging.ImageOptions.PngOptions()
                {
                    ColorType =
                                            Aspose.Imaging.FileFormats.Png
                                            .PngColorType
                                            .TruecolorWithAlpha
                });
            }

            //ExEnd:SupportLayerForPSD

        }
   }
}