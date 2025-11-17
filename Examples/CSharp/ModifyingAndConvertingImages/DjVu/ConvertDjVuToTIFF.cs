// GIST-ID: 8ef8a04a67af476785b615d50ef49f88
using Aspose.Imaging.FileFormats.Djvu;
using Aspose.Imaging.FileFormats.Tiff.Enums;
using Aspose.Imaging.ImageOptions;
using System;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference 
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it, and then add its reference to this project. For any issues, questions, or suggestions 
please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.DjVu
{
    public class ConvertDjVuToTIFF
    {
        public static void Run()
        {
            Console.WriteLine("Running example ConvertDjVuToTIFF");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DjVu();

            // Load a DjVu image.
            using (DjvuImage image = (DjvuImage)Image.Load(dataDir + "Sample.djvu"))
            {
                // Create an instance of TiffOptions and use preset options for Black and White with Deflate compression.
                TiffOptions exportOptions = new TiffOptions(TiffExpectedFormat.TiffDeflateBw);

                // Initialize the DjvuMultiPageOptions and call the Save method while passing the instance of TiffOptions.
                exportOptions.MultiPageOptions = new DjvuMultiPageOptions();
                image.Save(dataDir + "ConvertDjVuToTIFFFormat_out.tiff", exportOptions);
            }

            Console.WriteLine("Finished example ConvertDjVuToTIFF");
        }
    }
}