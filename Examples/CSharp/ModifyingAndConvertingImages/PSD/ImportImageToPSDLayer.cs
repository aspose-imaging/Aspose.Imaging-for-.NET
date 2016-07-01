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
    class ImportImageToPSDLayer
    {
        public static void Run()
        {
            // ExStart:ImportImageToPSDLayer
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_PSD();

            // Load a PSD file as an image and caste it into PsdImage
            using (PsdImage image = (PsdImage)Image.Load(dataDir + "samplePsd.psd"))
            {
                // Extract a layer from PSDImage
                Layer layer = image.Layers[1];

                // Load the image that is needed to be imported into the PSD file.
                using (RasterImage drawImage = (RasterImage)Image.Load(dataDir + "aspose_logo.png"))
                {
                    // Call DrawImage method of the Layer class and pass the image instance.
                    layer.DrawImage(new Point(10, 10), drawImage);
                }

                // Save the results to output path.
                image.Save(dataDir + "ImportImageToPSDLayer_out.psd", new PsdOptions());
            }
            // ExEnd:ImportImageToPSDLayer
        }
    }
}