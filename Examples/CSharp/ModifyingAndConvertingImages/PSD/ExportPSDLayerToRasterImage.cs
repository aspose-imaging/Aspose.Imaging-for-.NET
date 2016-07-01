using Aspose.Imaging.FileFormats.Png;
using Aspose.Imaging.FileFormats.Psd;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.PSD
{
    class ExportPSDLayerToRasterImage
    {
        public static void Run()
        {
            // ExStart:ExportPSDLayerToRasterImage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_PSD();

            // Create an instance of Image class and load PSD file as image.
            using (Image image = Image.Load(dataDir + "samplePsd.psd"))
            {
                // Cast image object to PSD image
                var psdImage = (PsdImage)image;

                // Create an instance of PngOptions class
                var pngOptions = new PngOptions();
                pngOptions.ColorType = PngColorType.TruecolorWithAlpha;

                // Loop through the list of layers
                for (int i = 0; i < psdImage.Layers.Length; i++)
                {
                    // convert and save the layer to PNG file format.
                    psdImage.Layers[i].Save(string.Format("layer_out{0}.png", i + 1), pngOptions);
                }
            }
            // ExEnd:ExportPSDLayerToRasterImage
        }
    }
}