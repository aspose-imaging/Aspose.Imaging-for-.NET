// GIST-ID: cec93d0d381642fe9f74340f6f8bbc1b
using Aspose.Imaging.FileFormats.Djvu;
using Aspose.Imaging.FileFormats.Tiff.Enums;
using Aspose.Imaging.ImageOptions;
using System;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference 
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it, and then add its reference to this project. For any issues, questions, or suggestions, 
please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.DjVu
{
    public class ConvertRangeOfDjVuPages
    {
        public static void Run()
        {
            Console.WriteLine("Running example ConvertRangeOfDjVuPages");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DjVu();

            // Load a DjVu image
            using (DjvuImage image = (DjvuImage)Image.Load(dataDir + "Sample.djvu"))
            {
                // Create an instance of TiffOptions with preset options and an IntRange, and initialize it with the range of pages to be exported
                TiffOptions exportOptions = new TiffOptions(TiffExpectedFormat.TiffDeflateBw);
                IntRange range = new IntRange(0, 2);

                // Initialize an instance of DjvuMultiPageOptions by passing the IntRange, and call Save method passing the TiffOptions
                exportOptions.MultiPageOptions = new DjvuMultiPageOptions(range);
                image.Save(dataDir + "ConvertRangeOfDjVuPages_out.djvu", exportOptions);
            }

            Console.WriteLine("Finished example ConvertRangeOfDjVuPages");
        }
    }
}