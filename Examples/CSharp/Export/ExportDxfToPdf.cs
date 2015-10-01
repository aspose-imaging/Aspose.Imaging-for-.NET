using Aspose.Imaging;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.FileFormats.Cad;

namespace Aspose.Imaging.Examples.Export
{
    class ExportDxfToPdf
    {
        static void Main()
        {
            // The path to the documents directory.
            string dataDir = Aspose.Imaging.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

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
