using System.IO;
using Aspose.Imaging.FileFormats.Jpeg;
using Aspose.Imaging.Sources;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    public class ColorConversionUsingICCProfiles
    {
        public static void Run()
        {
            // ExStart:ColorConversionUsingICCProfiles
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Load an existing JPG image
            using (JpegImage image = (JpegImage)Image.Load(dataDir + "aspose-logo_tn.jpg"))
            {
                StreamSource rgbprofile = new StreamSource(File.OpenRead(dataDir + "rgb.icc"));
                StreamSource cmykprofile = new StreamSource(File.OpenRead(dataDir + "cmyk.icc"));
                image.RgbColorProfile = rgbprofile;
                image.CmykColorProfile = cmykprofile;
                Color[] colors = image.LoadPixels(new Rectangle(0, 0, image.Width, image.Height));
            }
            // ExStart:ColorConversionUsingICCProfiles
        }
    }
}