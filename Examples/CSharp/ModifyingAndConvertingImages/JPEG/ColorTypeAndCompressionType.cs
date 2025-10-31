/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference 
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it, and then add its reference to this project. For any issues, questions, or suggestions, 
please feel free to contact us using https://forum.aspose.com/
*/

using Aspose.Imaging.FileFormats.Jpeg;
using Aspose.Imaging.ImageOptions;

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.JPEG
{
    class ColorTypeAndCompressionType 
    {
        public static void Run()
        {
             
            //ExStart:ColorTypeAndCompressionType 
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_JPEG();
          
            using (var original = Image.Load(dataDir + "ColorGif.gif"))
            {
                var jpegOptions = new JpegOptions()
                {
                    ColorType = JpegCompressionColorMode.Grayscale,
                    CompressionType = JpegCompressionMode.Progressive,
                };
                original.Save("D:/temp/result.jpg", jpegOptions);
            }
            //ExEnd:ColorTypeAndCompressionType 
        }
    }
}