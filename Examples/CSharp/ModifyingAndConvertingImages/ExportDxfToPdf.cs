using Aspose.Imaging.ImageOptions;
using Aspose.Imaging;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    class ExportDxfToPdf
    {
        public static void Run()
        {
            // To get proper output please apply a valid Aspose.Imaging License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");

            // ExStart:ExportDxfToPdf
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            using (Image cadImage = Image.Load(dataDir + "conic_pyramid.dxf"))
            {
                CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
                rasterizationOptions.PageWidth = 500;
                rasterizationOptions.PageHeight = 500;
                rasterizationOptions.TypeOfEntities = TypeOfEntities.Entities3D;

                // RasterizationOptions.ScaleMethod = ScaleType.GrowToFit;

                rasterizationOptions.Layouts = new[] { "Model" };
                PdfOptions pdfOptions = new PdfOptions();
                pdfOptions.VectorRasterizationOptions = rasterizationOptions;
                cadImage.Save(dataDir + "_output.pdf", pdfOptions);
            }
            // ExEnd:ExportDxfToPdf
        }
    }
}
