using Aspose.Imaging;
using Aspose.Imaging.FileFormats.Djvu;
using Aspose.Imaging.FileFormats.Png;
using Aspose.Imaging.ImageOptions;
using System;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information.
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, install it, and then add its reference to this project. For any issues, questions, or suggestions, please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.DjVu
{
    public class ConvertSpecificPortionOfDjVuPage
    {
        public static void Run()
        {
            Console.WriteLine("Running example ConvertSpecificPortionOfDjVuPage");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DjVu();

            // Load a DjVu image.
            using (DjvuImage image = (DjvuImage)Image.Load(dataDir + "Sample.djvu"))
            {
                // Create an instance of PngOptions and set ColorType to Grayscale.
                PngOptions exportOptions = new PngOptions();
                exportOptions.ColorType = PngColorType.Grayscale;

                // Create an instance of Rectangle that specifies the portion on the DjVu page.
                Rectangle exportArea = new Rectangle(0, 0, 500, 500);

                // Specify the DjVu page index and initialize an instance of DjvuMultiPageOptions,
                // passing the page index and the rectangle that defines the area to be exported.
                int exportPageIndex = 2;
                exportOptions.MultiPageOptions = new DjvuMultiPageOptions(exportPageIndex, exportArea);
                image.Save(dataDir + "ConvertSpecificPortionOfDjVuPage_out.djvu", exportOptions);
            }

            Console.WriteLine("Finished example ConvertSpecificPortionOfDjVuPage");
        }
    }
}