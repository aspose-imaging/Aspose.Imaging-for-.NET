// GIST-ID: b9dacb192a5004f58a7eaa95db960d35
using Aspose.Imaging.ImageOptions;
using System;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference 
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it and then add its reference to this project. For any issues, questions, or suggestions 
please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    public class ConvertWMFMetaFileToSVG
    {
        public static void Run()
        {
            Console.WriteLine("Running example ConvertWMFMetaFileToSVG");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Create an instance of the Image class by loading an existing image.
            using (Image image = Image.Load(dataDir + "input.wmf"))
            {
                // Create an instance of the WmfRasterizationOptions class.
                WmfRasterizationOptions options = new WmfRasterizationOptions();
                options.PageWidth = image.Width;
                options.PageHeight = image.Height;

                // Call the Save method to convert WMF to SVG format by passing the output file name and an SvgOptions instance.
                image.Save(dataDir + "ConvertWMFMetaFileToSVG_out.svg", new SvgOptions { VectorRasterizationOptions = options });
            }

            Console.WriteLine("Finished example ConvertWMFMetaFileToSVG");
        }
    }
}