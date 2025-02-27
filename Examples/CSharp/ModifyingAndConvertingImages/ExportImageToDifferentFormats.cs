using System;
using Aspose.Imaging.FileFormats.Tiff.Enums;
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
    public class ExportImageToDifferentFormats
    {
        public static void Run()
        {
            Console.WriteLine("Running example ExportImageToDifferentFormats");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Load an existing image (of type Gif) in an instance of the Image class
            using (Image image = Image.Load(dataDir + "sample.gif"))
            {
                //Export to BMP, JPEG, PNG and TIFF file format using the default options
                image.Save(dataDir + "_output.bmp", new BmpOptions());
                image.Save(dataDir + "_output.jpeg", new JpegOptions());
                image.Save(dataDir + "_output.png", new PngOptions());
                image.Save(dataDir + "_output.tiff", new TiffOptions(TiffExpectedFormat.Default));
            }

            Console.WriteLine("Finished example ExportImageToDifferentFormats");
        }
    }
}
