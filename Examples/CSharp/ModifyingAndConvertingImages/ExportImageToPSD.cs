using System;
using Aspose.Imaging.FileFormats.Psd;
using Aspose.Imaging.ImageOptions;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    public class ExportImageToPSD
    {
        public static void Run()
        {
            Console.WriteLine("Running example ExportImageToPSD");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();
           
            // Load an existing image
            using (Image image = Image.Load(dataDir + "sample.bmp"))
            {
                // Create an instance of PsdOptions, Set it’s various properties Save image to disk in PSD format
                PsdOptions psdOptions = new PsdOptions();
                psdOptions.ColorMode = ColorModes.Rgb;
                psdOptions.CompressionMethod = CompressionMethod.Raw;
                psdOptions.Version = 4;
                image.Save(dataDir + "ExportImageToPSD_output.psd", psdOptions);               
            }

            Console.WriteLine("Finished example ExportImageToPSD");
        }
    }
}