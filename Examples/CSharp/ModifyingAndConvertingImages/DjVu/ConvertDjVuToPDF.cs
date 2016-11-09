using Aspose.Imaging.FileFormats.Djvu;
using Aspose.Imaging.FileFormats.Pdf;
using Aspose.Imaging.ImageOptions;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.DjVu
{
    public class ConvertDjVuToPDF
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DjVu();

            // Load a DjVu image
            using (DjvuImage image = (DjvuImage)Image.Load(dataDir + "Sample.djvu"))
            {
                // Create an instance of PdfOptions and Initialize the metadata for Pdf document
                PdfOptions exportOptions = new PdfOptions();
                exportOptions.PdfDocumentInfo = new PdfDocumentInfo();
                
                // Create an instance of IntRange and initialize it with the range of DjVu pages to be exported
                IntRange range = new IntRange(0, 5); // Export first 5 pages

                // Initialize an instance of DjvuMultiPageOptions with range of DjVu pages to be exported and Save the result in PDF format
                exportOptions.MultiPageOptions = new DjvuMultiPageOptions(range);
                image.Save(dataDir + "ConvertDjVuToPDFFormat_out.pdf", exportOptions);
            }
        }
    }
}