using System;
using Aspose.Imaging.FileFormats.Tiff.Enums;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
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
            // To get proper output please apply a valid Aspose.Imaging License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");

            // ExStart:ExportImageToDifferentFormats
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Load an existing image (of type Gif) in an instance of the Image class
            using (Image image = Image.Load(dataDir + "sample.gif"))
            {
                // Export to BMP file format using the default options
                image.Save(dataDir + "_output.bmp", new BmpOptions());

                // Export to JPEG file format using the default options
                image.Save(dataDir + "_output.jpeg", new JpegOptions());

                // Export to PNG file format using the default options
                image.Save(dataDir + "_output.png", new PngOptions());

                // Export to TIFF file format using the default options
                image.Save(dataDir + "_output.tiff", new TiffOptions(TiffExpectedFormat.Default));
            }
            // ExStart:ExportImageToDifferentFormats
            // Display Status.
            Console.WriteLine("Conversion performed successfully.");
        }
    }
}
