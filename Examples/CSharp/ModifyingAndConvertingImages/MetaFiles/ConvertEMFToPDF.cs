using System;
using System.IO;
using System.Drawing;
using Aspose.Imaging.CoreExceptions;
using Aspose.Imaging.FileFormats.Emf;
using Aspose.Imaging.ImageOptions;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference 
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it, and then add its reference to this project. For any issues, questions, or suggestions, 
please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.MetaFiles
{
    class ConvertEMFToPDF
    {
        public static void Run()
        {
            //ExStart:ConvertEMFToPDF
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_MetaFiles();

            string[] filePaths = {
                "Picture1.emf"
            };

            Console.WriteLine("Running example ConvertEMFToPDF");

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

                    EmfRasterizationOptions emfRasterization = new EmfRasterizationOptions
                    {
                        PageWidth = image.Width,
                        PageHeight = image.Height,
                        BackgroundColor = Color.WhiteSmoke
                    };
                    PdfOptions pdfOptions = new PdfOptions
                    {
                        VectorRasterizationOptions = emfRasterization
                    };
                    image.Save(outputStream, pdfOptions);
                }
            }

            Console.WriteLine("Finished example ConvertEMFToPDF");
            //ExEnd:ConvertEMFToPDF
        }
    }
}