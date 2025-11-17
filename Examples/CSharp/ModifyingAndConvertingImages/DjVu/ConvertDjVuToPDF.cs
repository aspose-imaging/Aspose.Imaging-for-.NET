// GIST-ID: 8cb4d54ade9d8cceaa0f3bba804db38d
using Aspose.Imaging.FileFormats.Djvu;
using Aspose.Imaging.FileFormats.Pdf;
using Aspose.Imaging.ImageOptions;
using System;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API
reference when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information.
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/,
install it, and then add its reference to this project. For any issues, questions, or suggestions,
please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.DjVu
{
    public class ConvertDjVuToPDF
    {
        public static void Run()
        {
            Console.WriteLine("Running example ConvertDjVuToPDF");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DjVu();

            // Load a DjVu image.
            using (DjvuImage image = (DjvuImage)Image.Load(dataDir + "Sample.djvu"))
            {
                // Create an instance of PdfOptions and initialize the metadata for the PDF document.
                PdfOptions exportOptions = new PdfOptions();
                exportOptions.PdfDocumentInfo = new PdfDocumentInfo();

                // Create an instance of IntRange and initialize it with the range of DjVu pages to be exported.
                IntRange range = new IntRange(0, 5); // Export first 5 pages.

                // Initialize an instance of DjvuMultiPageOptions with the range of DjVu pages to be exported
                // and save the result in PDF format.
                exportOptions.MultiPageOptions = new DjvuMultiPageOptions(range);
                image.Save(dataDir + "ConvertDjVuToPDFFormat_out.pdf", exportOptions);
            }

            Console.WriteLine("Finished example ConvertDjVuToPDF");
        }
    }
}