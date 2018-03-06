using System;
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
    public class ConvertWMFToPDF
    {
        public static void Run()
        {
            //ExStart:ConvertWMFToPDF
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Load an existing WMF image
            using (Image image = Image.Load(dataDir + "input.wmf"))
            {
                // Create an instance of EmfRasterizationOptions class and set different properties
                EmfRasterizationOptions emfRasterizationOptions = new EmfRasterizationOptions();
                emfRasterizationOptions.BackgroundColor = Color.WhiteSmoke;
                emfRasterizationOptions.PageWidth = image.Width;
                emfRasterizationOptions.PageHeight = image.Height;

                // Create an instance of PdfOptions class and provide rasterization option
                PdfOptions pdfOptions = new PdfOptions();
                pdfOptions.VectorRasterizationOptions = emfRasterizationOptions;

                // Call the save method, provide output path and PdfOptions to convert the WMF file to PDF and save the output
                image.Save(dataDir + "ConvertWMFToPDF_out.pdf", pdfOptions);
            }
            //ExEnd:ConvertWMFToPDF
        }
    }
}