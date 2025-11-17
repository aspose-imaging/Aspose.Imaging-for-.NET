// GIST-ID: 272127e44ac3c63fe428fa0d25ceb2a1
using System.IO;
using Aspose.Imaging.FileFormats.Emf;
using Aspose.Imaging.ImageOptions;
using System;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference 
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it, and then add its reference to this project. For any issues, questions, or suggestions 
please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.MetaFiles
{
    class CroppingByRectangleEMFImage
    {
        public static void Run()
        {
            //ExStart:CroppingByRectangleEMFImage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_MetaFiles();

            // Create an instance of rasterization options.
            EmfRasterizationOptions emfRasterizationOptions = new EmfRasterizationOptions();
            emfRasterizationOptions.BackgroundColor = Color.WhiteSmoke;

            // Create an instance of PDF options.
            PdfOptions pdfOptions = new PdfOptions();
            pdfOptions.VectorRasterizationOptions = emfRasterizationOptions;

            Console.WriteLine("Running example CroppingByRectangleEMFImage");
            // Load an existing image into an instance of the EMF class.
            using (EmfImage image = (EmfImage)Image.Load(dataDir + "Picture1.emf"))
            {
                using (FileStream outputStream = new FileStream(dataDir + "CroppingByRectangleEMFImage_out.pdf", FileMode.Create))
                {
                    // Create a Rectangle with the desired size, crop the image, set page dimensions, and save the result to disk.
                    image.Crop(new Rectangle(30, 50, 100, 150));
                    pdfOptions.VectorRasterizationOptions.PageWidth = image.Width;
                    pdfOptions.VectorRasterizationOptions.PageHeight = image.Height;
                    image.Save(outputStream, pdfOptions);
                }
            }

            Console.WriteLine("Finished example CroppingByRectangleEMFImage");
            //ExEnd:CroppingByRectangleEMFImage
        }
    }
}