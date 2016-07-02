using Aspose.Imaging.ImageOptions;
using Aspose.Imaging;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.WebPImages
{
    class ExportToWebP
    {
        public static void Run()
        {
            // ExStart:ExportToWebP
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_WebPImages();

            // Create an instance of image class.
            using (Image image = Image.Load(dataDir + "SampleImage1.bmp"))
            {
                // Create an instance of WebPOptions class
                WebPOptions options = new WebPOptions();

                // Set Quality
                options.Quality = 50;

                // Set LossLess property
                options.Lossless = false;

                // Save the image in WebP format.
                image.Save(dataDir+ "ExportToWebP_out.webp", options);
            }
            // ExEnd:ExportToWebP
        }
    }
}