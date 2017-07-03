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
            // ExStart:SupportForJPEG-LSFormat
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_JPEG();
            string sourceJpegFileName = @"c:\aspose.work\lena24b.jls";
            string outputPngFileName = @"c:\aspose.work\\lena24b.png";
            string outputPngRectFileName = @"c:\aspose.work\\lena24b_rect.png";

            // Decoding
            using (JpegImage jpegImage = (JpegImage)Image.Load(sourceJpegFileName))
            {
                JpegOptions jpegOptions = jpegImage.JpegOptions;

                // You can read new options:
                System.Console.WriteLine("Compression type:           {0}", jpegOptions.CompressionType);
                System.Console.WriteLine("Allowed lossy error (NEAR): {0}", jpegOptions.JpegLsAllowedLossyError);
                System.Console.WriteLine("Interleaved mode (ILV):     {0}", jpegOptions.JpegLsInterleaveMode);
                System.Console.WriteLine("Horizontal sampling:        {0}", ArrayToString(jpegOptions.HorizontalSampling));
                System.Console.WriteLine("Vertical sampling:          {0}", ArrayToString(jpegOptions.VerticalSampling));

                // Save the original JPEG-LS image to PNG.
                jpegImage.Save(outputPngFileName, new PngOptions());

                // Save the bottom-right quarter of the original JPEG-LS to PNG
                Rectangle quarter = new Rectangle(jpegImage.Width / 2, jpegImage.Height / 2, jpegImage.Width / 2, jpegImage.Height / 2);
                jpegImage.Save(outputPngRectFileName, new PngOptions(), quarter);
            }
         
            }
        // ExEnd:SupportForJPEG-LSFormat
        }       
    }


