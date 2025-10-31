/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information.
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/,
install it, and then add its reference to this project. For any issues, questions, or suggestions,
please feel free to contact us using https://forum.aspose.com/
*/

using Aspose.Imaging.FileFormats.Jpeg;
using Aspose.Imaging.FileFormats.Png;
using Aspose.Imaging.ImageOptions;

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.JPEG
{
    class SupportForJPEGBITS
    {
        public static void Run()
        {
            // ExStart:SupportForJPEGBITS
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_JPEG();
            int bpp = 2; // Set 2 bits per sample to see the difference in size and quality

            // The original PNG with 8 bits per sample.
            string originPngFileName = System.IO.Path.Combine(dataDir, "lena_16g_lin.png");

            // The output JPEG-LS with 2 bits per sample.
            string outputJpegFileName = "lena24b " + bpp + "-bit Gold.jls";

            using (PngImage pngImage = (PngImage)Image.Load(originPngFileName))
            {
                JpegOptions jpegOptions = new JpegOptions();
                jpegOptions.BitsPerChannel = (byte)bpp;
                jpegOptions.CompressionType = JpegCompressionMode.JpegLs;
                pngImage.Save(outputJpegFileName, jpegOptions);
            }

            // The output PNG is produced from JPEG-LS to check the image visually.
            string outputPngFileName = "lena24b " + bpp + "-bit Gold.png";
            using (JpegImage jpegImage = (JpegImage)Image.Load(outputJpegFileName))
            {
                jpegImage.Save(outputPngFileName, new PngOptions());
            }
            // ExEnd:SupportForJPEGBITS
        }
    }
}