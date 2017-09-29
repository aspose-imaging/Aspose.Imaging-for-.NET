/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

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
                // Save to JPEG Lossless CMYK
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

                // Load from JPEG Lossless CMYK
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