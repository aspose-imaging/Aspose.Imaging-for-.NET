/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.JPEG
{
    class SupportForJPEG
    {
        public static void Run()
        {
            // ExStart:SupportFor2-7BitsJPEG
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_JPEG();
            int bpp = 2; // Set 2 bits per sample to see the difference in size and quality

            // The origin PNG with 8 bits per sample
            string originPngFileName = "lena24b.png";

            // The output JPEG-LS with 2 bits per sample.
            string outputJpegFileName = "lena24b " + bpp + "-bit Gold.jls";

            using (PngImage pngImage = (PngImage)Image.Load(originPngFileName))
            {
                JpegOptions jpegOptions = new JpegOptions();
                jpegOptions.BitsPerChannel = (byte)bpp;
                jpegOptions.CompressionType = JpegCompressionMode.JpegLs;
                pngImage.Save(outputJpegFileName, jpegOptions);
            }

            // The output PNG is produced from JPEG-LS to check image visually.
            string outputPngFileName = "lena24b " + bpp + "-bit Gold.png";
            using (JpegImage jpegImage = (JpegImage)Image.Load(outputJpegFileName))
            {
                jpegImage.Save(outputPngFileName, new PngOptions());
            }
            }
        // ExEnd:SupportFor2-7BitsJPEG
        }       
    }


