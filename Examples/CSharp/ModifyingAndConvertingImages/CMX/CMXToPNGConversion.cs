// GIST-ID: b68c26bbcad18022185d482650264be4
using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.ModifyingAndConvertingImages.CMX
{
    class CMXToPNGConversion
    {
        public static void Run()
        {
            Console.WriteLine("Running example CMXToPNGConversion");
            // The path to the directory that contains the input files.
            string dataDir = RunExamples.GetDataDir_CMX();

            string[] fileNames = new string[] {
                "Rectangle.cmx",
                "Rectangle+Fill.cmx",
                "Ellipse.cmx",
                "Ellipse+fill.cmx",
                "brushes.cmx",
                "outlines.cmx",
                "order.cmx",
                "many_images.cmx",
            };
            foreach (string fileName in fileNames)
            {
                using (Image image = Image.Load(dataDir + fileName))
                {
                    image.Save(
                        dataDir + fileName + ".docpage.png",
                        new PngOptions
                        {
                            VectorRasterizationOptions =
                                new CmxRasterizationOptions()
                                {
                                    Positioning = PositioningTypes.DefinedByDocument,
                                    SmoothingMode = SmoothingMode.AntiAlias
                                }
                        });
                }
            }

            Console.WriteLine("Finished example CMXToPNGConversion");
        }
    }

}