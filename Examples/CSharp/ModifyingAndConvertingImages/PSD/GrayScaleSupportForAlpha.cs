using Aspose.Imaging.FileFormats.Bmp;
using Aspose.Imaging.FileFormats.Png;
using Aspose.Imaging.FileFormats.Psd;
using Aspose.Imaging.FileFormats.Psd.Resources;
using Aspose.Imaging.ImageOptions;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.PSD
{
    class GrayScaleSupportForAlpha
    {
        public static void Run()
        {
            // ExStart:GrayScaleSupportForAlpha
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_PSD();

            // Load a PSD in an instance of PsdImage
            using (Image image = Image.Load(dataDir+"File.psd"))
            {
                // Cast image object to PSD image
                PsdImage psdImage = (PsdImage)image;

                // Create an instance of PngOptions class
                PngOptions pngOptions = new PngOptions();
                pngOptions.ColorType = PngColorType.TruecolorWithAlpha;
                image.Save(dataDir+"result.png", pngOptions);
            }
            // ExEnd:GrayScaleSupportForAlpha
        }
    }
}