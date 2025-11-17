// GIST-ID: b84ec9a95a83dd4d7d4e1a87e2d6fe45
using Aspose.Imaging;
using Aspose.Imaging.ImageOptions;
using System;
using System.Drawing;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference 
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it, and then add its reference to this project. For any issues, questions, or suggestions, 
please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    public class ExportTextAsShape
    {
        public static void Run()
        {
            Console.WriteLine("Running example ExportTextAsShape");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();
            using (Image image = Image.Load(dataDir + "Picture1.emf"))
            {
                EmfRasterizationOptions emfRasterizationOptions = new EmfRasterizationOptions();
                emfRasterizationOptions.BackgroundColor = Color.White;
                emfRasterizationOptions.PageWidth = image.Width;
                emfRasterizationOptions.PageHeight = image.Height;
                image.Save(dataDir + "TextAsShapes_out.svg", new SvgOptions
                {
                    VectorRasterizationOptions = emfRasterizationOptions,
                    TextAsShapes = true
                });

                image.Save(dataDir + "TextAsShapesFalse_out.svg", new SvgOptions
                {
                    VectorRasterizationOptions = emfRasterizationOptions,
                    TextAsShapes = false
                });
            }

            Console.WriteLine("Finished example ExportTextAsShape");
        }
    }
}