using Aspose.Imaging;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.FileFormats.Cad;

namespace Aspose.Imaging.Examples.CSharp.Export
{
    class ExportDxfToPdf
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Export("ExportDxfToPdf");

            using (CadImage cadImage = (CadImage)Image.Load(dataDir + "conic_pyramid.dxf"))
            {
                CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
                rasterizationOptions.PageWidth = 500;
                rasterizationOptions.PageHeight = 500;
                rasterizationOptions.TypeOfEntities = TypeOfEntities.Entities3D;

                //rasterizationOptions.ScaleMethod = ScaleType.GrowToFit;

                rasterizationOptions.Layouts = new string[] { "Model" };
                PdfOptions pdfOptions = new PdfOptions();
                pdfOptions.VectorRasterizationOptions = rasterizationOptions;
                cadImage.Save(dataDir + "output.pdf", pdfOptions);
            }
        }

      
    }
}
