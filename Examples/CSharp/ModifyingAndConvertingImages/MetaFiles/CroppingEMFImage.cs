// GIST-ID: d4f913a811c8e1a318eeb2359a448921
using System;
using System.IO;
using System.Drawing;
using Aspose.Imaging.FileFormats.Emf;
using Aspose.Imaging.ImageOptions;

 /*
 This project uses the Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API references 
 when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
 If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, 
 install it, and then add its reference to this project. For any issues, questions, or suggestions, 
 please feel free to contact us using https://forum.aspose.com/
 */

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.MetaFiles
{
    class CroppingEMFImage
    {
        public static void Run()
        {
            //ExStart:CroppingEMFImage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_MetaFiles();

            // Create an instance of rasterization options.
            EmfRasterizationOptions emfRasterizationOptions = new EmfRasterizationOptions();
            emfRasterizationOptions.BackgroundColor = Color.WhiteSmoke;

            // Create an instance of PDF options.
            PdfOptions pdfOptions = new PdfOptions();
            pdfOptions.VectorRasterizationOptions = emfRasterizationOptions;

            Console.WriteLine("Running example CroppingEMFImage");

            // Load an existing image into an instance of the EMF class.
            using (EmfImage image = (EmfImage)Image.Load(dataDir + "Picture1.emf"))
            {
                using (FileStream outputStream = new FileStream(dataDir + "CroppingEMFImage_out.pdf", FileMode.Create))
                {
                    // Based on the shift values, apply the cropping on the image; the Crop method will shift the image bounds toward the center.
                    image.Crop(30, 40, 50, 60);

                    // Set height and width and save the results to disk.
                    pdfOptions.VectorRasterizationOptions.PageWidth = image.Width;
                    pdfOptions.VectorRasterizationOptions.PageHeight = image.Height;
                    image.Save(outputStream, pdfOptions);
                }
            }

            Console.WriteLine("Finished example CroppingEMFImage");
            //ExEnd:CroppingEMFImage
        }      
    }
}