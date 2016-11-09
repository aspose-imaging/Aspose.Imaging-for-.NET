using System.IO;
using Aspose.Imaging.CoreExceptions;
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
    class ConvertEMFToPDF
    {
        public static void Run()
        {
            // ExStart:ConvertEMFToPDF
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_MetaFiles();

            string[] filePaths = {
                "Picture1.emf"
            };

            foreach (string filePath in filePaths)
            {
                string outPath = dataDir + filePath + "_out.pdf";
                using (var image = (EmfImage)Image.Load(dataDir + filePath))
                using (FileStream outputStream = new FileStream(outPath, FileMode.Create))
                {
                    if (!image.Header.EmfHeader.Valid)
                    {
                        throw new ImageLoadException(string.Format("The file {0} is not valid", outPath));
                    }

                    EmfRasterizationOptions emfRasterization = new EmfRasterizationOptions();
                    emfRasterization.PageWidth = image.Width;
                    emfRasterization.PageHeight = image.Height;
                    emfRasterization.BackgroundColor = Color.WhiteSmoke;
                    PdfOptions pdfOptions = new PdfOptions();
                    pdfOptions.VectorRasterizationOptions = emfRasterization;
                    image.Save(outputStream, pdfOptions);
                }
            }
            // ExEnd:ConvertEMFToPDF
        }
    }
}