using Aspose.Imaging.ImageOptions;
using System;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
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

            // Create an instance of Image class by loading an existing .
            using (Image image = Image.Load(dataDir + "input.wmf"))
            {
                // Create an instance of EmfRasterizationOptions class.
                WmfRasterizationOptions options = new WmfRasterizationOptions();
                options.PageWidth = image.Width;
                options.PageHeight = image.Height;

                // Call save method to convert WMF to SVG format by passing output file name and SvgOptions class instance.
                image.Save(dataDir + "ConvertWMFMetaFileToSVG_out.svg", new SvgOptions { VectorRasterizationOptions = options });
            }

            Console.WriteLine("Finished example ConvertWMFMetaFileToSVG");
        }
    }
}