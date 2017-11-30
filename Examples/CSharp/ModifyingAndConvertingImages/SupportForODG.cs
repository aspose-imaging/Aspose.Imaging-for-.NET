/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    class SupportForODG
    {
        public static void Run()
        {
            // To get proper output please apply a valid Aspose.Imaging License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");

            
            //ExStart:SupportForODG
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();
            string[] files = new string[2] { "example.odg", "example1.odg" };
            string folder = @"F:\\Aspose Work\\";
            MetafileRasterizationOptions rasterizationOptions = new MetafileRasterizationOptions();
            foreach (string file in files)
            {
                string fileName = Path.Combine(folder, file);
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
