// GIST-ID: 249092b937c32fbb051170324e39a070
/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information.
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, install it, and then add its reference to this project. For any issues, questions, or suggestions, please feel free to contact us via https://forum.aspose.com/
*/

using System.IO;
using Aspose.Imaging.FileFormats.Jpeg;
using Aspose.Imaging.ImageOptions;

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.JPEG
{
    class SupportForCMYKAndYCCKColorModesInJPEGLosslessUsingRGBProfile
    {
        public static void Run()
        {
            // ExStart:SupportForCMYKAndYCCKColorModesInJPEGLosslessUsingRGBProfile
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_JPEG();
            MemoryStream jpegStream = new MemoryStream();
            FileStream rgbProfileStream = new FileStream("eciRGB_v2.icc", FileMode.Open);
            FileStream cmykProfileStream = new FileStream("ISOcoated_v2_FullGamut4.icc", FileMode.Open);
            Sources.StreamSource rgbColorProfile = new Sources.StreamSource(rgbProfileStream);
            Sources.StreamSource cmykColorProfile = new Sources.StreamSource(cmykProfileStream);

            try
            {
                // Save to JPEG lossless CMYK
                using (JpegImage image = (JpegImage)Image.Load("056.jpg"))
                {
                    JpegOptions options = new JpegOptions();
                    options.ColorType = JpegCompressionColorMode.Cmyk;
                    options.CompressionType = JpegCompressionMode.Lossless;

                    // The custom profiles will be used.
                    options.RgbColorProfile = rgbColorProfile;
                    options.CmykColorProfile = cmykColorProfile;

                    image.Save(jpegStream, options);
                }

                // Load from JPEG lossless CMYK
                jpegStream.Position = 0;
                rgbProfileStream.Position = 0;
                cmykProfileStream.Position = 0;
                using (JpegImage image = (JpegImage)Image.Load(jpegStream))
                {
                    image.RgbColorProfile = rgbColorProfile;
                    image.CmykColorProfile = cmykColorProfile;
                    image.Save("056_cmyk_custom_profiles.png", new PngOptions());
                }
            }
            finally
            {
                jpegStream.Dispose();
                rgbProfileStream.Dispose();
                cmykProfileStream.Dispose();
            }
            // ExEnd:SupportForCMYKAndYCCKColorModesInJPEGLosslessUsingRGBProfile

        }
    }
}