using Aspose.Imaging.FileFormats.Png;
using Aspose.Imaging.FileFormats.Psd;
using Aspose.Imaging.ImageOptions;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    class ExportPsdLayersToImages
    {
        public static void Run()
        {
            // ExStart:ExportPsdLayersToImages
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();
         
            // Load an existing image
            using (Image image = Image.Load(dataDir + "samplePsd.psd"))
            {
                var psdImage = (PsdImage)image;
                var pngOptions = new PngOptions();
                pngOptions.ColorType = PngColorType.TruecolorWithAlpha;
                for (int i = 0; i < psdImage.Layers.Length; i++)
                {
                    psdImage.Layers[i].Save(dataDir + "layer-" + i +"_out.png", pngOptions);
                }
            }
            // ExEnd:ExportPsdLayersToImages
        }
    }
}
