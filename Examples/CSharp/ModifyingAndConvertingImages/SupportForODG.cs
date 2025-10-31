/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information.
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/,
install it, and then add its reference to this project. For any issues, questions, or suggestions,
please feel free to contact us using https://forum.aspose.com/.
*/

using Aspose.Imaging.ImageOptions;

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    class SupportForODG
    {
        public static void Run()
        {
            // To get proper output, please apply a valid Aspose.Imaging license.
            // You can purchase a full license or obtain a 30‑day temporary license from https://www.aspose.com/purchase/default.aspx.

            //ExStart:SupportForODG
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();
            string[] files = new string[2] { "example.odg", "example1.odg" };
            string folder = @"F:\Aspose Work\";
            OdgRasterizationOptions rasterizationOptions = new OdgRasterizationOptions();
            foreach (string file in files)
            {
                string fileName = System.IO.Path.Combine(folder, file);
                using (Image image = Image.Load(fileName))
                {
                    rasterizationOptions.PageSize = image.Size;
                    string outFileName = fileName.Replace(".odg", ".png");
                    image.Save(outFileName,
                        new PngOptions
                        {
                            VectorRasterizationOptions = rasterizationOptions
                        });

                    outFileName = fileName.Replace(".odg", ".pdf");

                    image.Save(outFileName,
                        new PdfOptions
                        {
                            VectorRasterizationOptions = rasterizationOptions
                        });
                }
            }
            //ExEnd:SupportForODG
        }
    }
}