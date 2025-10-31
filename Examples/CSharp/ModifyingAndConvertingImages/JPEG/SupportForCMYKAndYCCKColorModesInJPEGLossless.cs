/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference 
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it, and then add its reference to this project. For any issues, questions, or suggestions, 
please feel free to contact us using https://forum.aspose.com/
*/

using System.IO;
using Aspose.Imaging.FileFormats.Jpeg;
using Aspose.Imaging.ImageOptions;

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.JPEG
{
    class SupportForCMYKAndYCCKColorModesInJPEGLossless
    {
        public static void Run()
        {
            // ExStart:SupportForCMYKAndYCCKColorModesInJPEGLossless
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_JPEG();
            MemoryStream jpegStream = new MemoryStream();

            try
            {
                // Save to JPEG Lossless CMYK
                using (JpegImage image = (JpegImage)Image.Load("056.jpg"))
                {
                    JpegOptions options = new JpegOptions
                    {
                        ColorType = JpegCompressionColorMode.Cmyk,
                        CompressionType = JpegCompressionMode.Lossless,
                        // The default profiles will be used.
                        RgbColorProfile = null,
                        CmykColorProfile = null
                    };

                    image.Save(jpegStream, options);
                }

                // Load from JPEG Lossless CMYK
                jpegStream.Position = 0;
                using (JpegImage image = (JpegImage)Image.Load(jpegStream))
                {
                    image.Save("056_cmyk.png", new PngOptions());
                }
            }
            finally
            {
                jpegStream.Dispose();
            }
            // ExEnd:SupportForCMYKAndYCCKColorModesInJPEGLossless
        }
    }
}