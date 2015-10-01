using Aspose.Imaging;

namespace Aspose.Imaging.Examples.Export
{
    class ExportPsdLayersToImages
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Aspose.Imaging.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            //Load an existing image
            using (Image image = Image.Load(dataDir + "sample.psd"))
            {
                var psdImage = (FileFormats.Psd.PsdImage)image;
                var pngOptions = new ImageOptions.PngOptions();
                pngOptions.ColorType = FileFormats.Png.PngColorType.TruecolorWithAlpha;

                for (int i = 0; i < psdImage.Layers.Length; i++)
                {
                    psdImage.Layers[i].Save(dataDir + "layer-" + i +".png", pngOptions);
                }
            }
        }
    }
}
