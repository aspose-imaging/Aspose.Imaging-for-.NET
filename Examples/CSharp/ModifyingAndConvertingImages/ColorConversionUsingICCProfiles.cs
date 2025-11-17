// GIST-ID: 7ad99e72d4e4f1adcc0b1970404fa080
using System;
using System.Drawing;
using System.IO;
using Aspose.Imaging;
using Aspose.Imaging.FileFormats.Jpeg;
using Aspose.Imaging.Sources;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information.
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/,
install it, and then add its reference to this project. For any issues, questions, or suggestions,
please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    public class ColorConversionUsingICCProfiles
    {
        public static void Run()
        {
            Console.WriteLine("Running example ColorConversionUsingICCProfiles");
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

            Console.WriteLine("Finished example ColorConversionUsingICCProfiles");
        }
    }
}