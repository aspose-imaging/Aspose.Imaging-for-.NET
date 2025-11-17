// GIST-ID: 19774949b419ca960a759498dbba8ed1
using Aspose.Imaging.FileFormats.Svg;
using Aspose.Imaging.ImageOptions;
using System;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API 
when the project is built. Please see https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more 
information. If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET from 
https://releases.aspose.com/, install it, and then add its reference to this project. For any issues, 
questions, or suggestions, please feel free to contact us via https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    public class ConvertingSVGToRasterImages
    {
        public static void Run()
        {
            Console.WriteLine("Running example ConvertingSVGToRasterImages");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Load the image
            using (SvgImage image = (SvgImage)Image.Load(dataDir + "aspose_logo.Svg"))
            {
                // Create an instance of PNG options and save the results to disk
                PngOptions pngOptions = new PngOptions();
                image.Save(dataDir + "ConvertingSVGToRasterImages_out.png", pngOptions);
            }

            Console.WriteLine("Finished example ConvertingSVGToRasterImages");
        }
    }
}