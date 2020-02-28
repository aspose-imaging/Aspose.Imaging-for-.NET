using Aspose.Imaging.FileFormats.Djvu;
using Aspose.Imaging.FileFormats.Tiff.Enums;
using Aspose.Imaging.ImageOptions;
using System;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
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
                // Create an instance of TiffOptions with preset options and IntRange and initialize it with range of pages to be exported
                TiffOptions exportOptions = new TiffOptions(TiffExpectedFormat.TiffDeflateBw);
                IntRange range = new IntRange(0, 2);

                // Initialize an instance of DjvuMultiPageOptions while passing instance of IntRange and  Call Save method while passing instance of TiffOptions
                exportOptions.MultiPageOptions = new DjvuMultiPageOptions(range);
                image.Save(dataDir + "ConvertRangeOfDjVuPages_out.djvu", exportOptions);
            }

            Console.WriteLine("Finished example ConvertRangeOfDjVuPages");
        }
    }
}