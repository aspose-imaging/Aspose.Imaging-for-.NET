using System.IO;
using Aspose.Imaging.FileFormats.Emf;
using Aspose.Imaging.ImageOptions;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
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

            // Create an instance of Rasterization options
            EmfRasterizationOptions emfRasterizationOptions = new EmfRasterizationOptions();
            emfRasterizationOptions.BackgroundColor = Color.WhiteSmoke;

            // Create an instance of PNG options
            PdfOptions pdfOptions = new PdfOptions();
            pdfOptions.VectorRasterizationOptions = emfRasterizationOptions;

            // Load an existing image into an instance of EMF class
            using (EmfImage image = (EmfImage)Image.Load(dataDir + "Picture1.emf"))
            {
                using (FileStream outputStream = new FileStream(dataDir + "CroppingByRectangleEMFImage_out.pdf", FileMode.Create))
                {
                    // Create an instance of Rectangle class with desired size and Perform the crop operation on object of Rectangle class and Set height and width and Save the results to disk
                    image.Crop(new Rectangle(30, 50, 100, 150));
                    pdfOptions.VectorRasterizationOptions.PageWidth = image.Width;
                    pdfOptions.VectorRasterizationOptions.PageHeight = image.Height;
                    image.Save(outputStream, pdfOptions);
                }
            }
            //ExEnd:CroppingByRectangleEMFImage
        }
    }
}