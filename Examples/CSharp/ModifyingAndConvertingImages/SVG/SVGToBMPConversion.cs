// GIST-ID: d1b68d25fd7f3a668c2a07c05ee717ab
using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.ModifyingAndConvertingImages.SVG
{
    class SVGToBMPConversion
    {
        public static void Run()
        {
            Console.WriteLine("Running example: SVGToBMPConversion");

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_SVG();

            using (Image image = Image.Load(dataDir + "test.svg"))
            {
                BmpOptions options = new BmpOptions();
                SvgRasterizationOptions svgOptions = new SvgRasterizationOptions();

                svgOptions.PageWidth = 100;
                svgOptions.PageHeight = 200;

                options.VectorRasterizationOptions = svgOptions;

                image.Save(dataDir + "test.svg_out.bmp", options);
            }

            Console.WriteLine("Finished example: SVGToBMPConversion");
        }
    }
}