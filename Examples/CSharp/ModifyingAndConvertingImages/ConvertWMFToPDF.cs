// GIST-ID: 8e18a167a440369ba4ba36442c9b8be4
using System;
using Aspose.Imaging.ImageOptions;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference 
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it, and then add its reference to this project. For any issues, questions, or suggestions, 
please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    public class ConvertWMFToPDF
    {
        public static void Run()
        {
            Console.WriteLine("Running example ConvertWMFToPDF");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Load an existing WMF image
            using (Image image = Image.Load(dataDir + "input.wmf"))
            {
                // Create an instance of WmfRasterizationOptions and set various properties
                WmfRasterizationOptions emfRasterizationOptions = new WmfRasterizationOptions();
                emfRasterizationOptions.BackgroundColor = Color.WhiteSmoke;
                emfRasterizationOptions.PageWidth = image.Width;
                emfRasterizationOptions.PageHeight = image.Height;

                // Create an instance of PdfOptions and provide the rasterization options
                PdfOptions pdfOptions = new PdfOptions();
                pdfOptions.VectorRasterizationOptions = emfRasterizationOptions;

                // Save the image as a PDF using the specified options
                image.Save(dataDir + "ConvertWMFToPDF_out.pdf", pdfOptions);
            }

            Console.WriteLine("Finished example ConvertWMFToPDF");
        }
    }
}