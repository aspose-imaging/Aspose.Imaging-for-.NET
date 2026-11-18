using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Tiff.Enums;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharp.ModifyingAndConvertingImages
{
    internal class _3DLutCubeSupport
    {
        public static void Run()
        {
            Console.WriteLine("Running example _3DLutCubeSupport");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            Aspose.Imaging.Rectangle rectangle = new Aspose.Imaging.Rectangle(0, 0, 720, 960);

            using (Aspose.Imaging.RasterImage image =
                   (Aspose.Imaging.RasterImage)Aspose.Imaging.Image.Load(dataDir + "multipage.tiff"))
            {
                image.ApplyCubeLut(dataDir + "bleach-bypass.cube", rectangle);
                image.Save(dataDir + "result-rectangle.tiff");
            }            

            rectangle = new Aspose.Imaging.Rectangle(0, 0, 720, 960);
            var cubeLut = Aspose.Imaging.Lut.CubeLut.CubeLut.Load(dataDir +"bleach-bypass.cube");

            using (var image = (RasterImage)Image.Load(dataDir + "multipage.tiff"))
            {
                image.ApplyCubeLut(cubeLut, rectangle);
                image.Save(dataDir + "result-rectangle.tiff");
            }

            File.Delete(dataDir + "result-rectangle.tiff");            

            Console.WriteLine("Finished example _3DLutCubeSupport");
        }
    }
}
