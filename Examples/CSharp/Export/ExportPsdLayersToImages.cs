using Aspose.Imaging;

namespace Aspose.Imaging.Examples.CSharp.Export
{
    class ExportPsdLayersToImages
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Export("ExportPsdLayersToImages");

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
