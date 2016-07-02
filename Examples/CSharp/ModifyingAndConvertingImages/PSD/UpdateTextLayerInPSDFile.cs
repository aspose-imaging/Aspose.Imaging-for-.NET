using System.Diagnostics;
using Aspose.Imaging.FileFormats.Psd;
using Aspose.Imaging.FileFormats.Psd.Layers;
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
    class UpdateTextLayerInPSDFile
    {
        public static void Run()
        {
            // ExStart:UpdateTextLayerInPSDFile
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_PSD();

            // Load a PSD file as an image and caste it into PsdImage
            using (PsdImage image = (PsdImage)Image.Load(dataDir + "samplePsd.psd"))
            {
                PsdImage psdImage = image;

                TextLayer textLayer1 = psdImage.Layers[1] as TextLayer;
                TextLayer textLayer2 = psdImage.Layers[2] as TextLayer;

                Debug.Assert(textLayer2 != null, "textLayer2 != null");
                textLayer2.UpdateText("test update", new Point(100, 100), 72.0f, Color.Purple);

                psdImage.Save(dataDir + "UpdateTextLayerInPSDFile_out.psd", new PsdOptions { CompressionMethod = CompressionMethod.RLE });
            }
            // ExEnd:UpdateTextLayerInPSDFile
        }
    }
}