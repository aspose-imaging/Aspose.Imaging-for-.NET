using Aspose.Imaging.FileFormats.Djvu;
using Aspose.Imaging.ImageOptions;
using System;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information.
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, install it, and then add its reference to this project. For any issues, questions, or suggestions, please feel free to contact us via https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.DjVu
{
    public class ConvertRangeOfDjVuPagesToSeparateImages
    {
        public static void Run()
        {
            Console.WriteLine("Running example ConvertRangeOfDjVuPagesToSeparateImages");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DjVu();

            // Load a DjVu image
            using (DjvuImage image = (DjvuImage)Image.Load(dataDir + "Sample.djvu"))
            {
                // Create an instance of BmpOptions and set BitsPerPixel for the resultant images
                BmpOptions exportOptions = new BmpOptions();
                exportOptions.BitsPerPixel = 32;

                // Create an instance of IntRange and initialize it with the range of pages to be exported
                IntRange range = new IntRange(0, 2);
                int counter = 0;
                foreach (var i in range.Range)
                {
                    // Save each page in a separate file, as BMP does not support layering
                    exportOptions.MultiPageOptions = new DjvuMultiPageOptions(range.GetArrayOneItemFromIndex(counter));
                    image.Save(dataDir + string.Format("{0}_out.bmp", counter++), exportOptions);
                }
            }

            Console.WriteLine("Finished example ConvertRangeOfDjVuPagesToSeparateImages");
        }
    }
}