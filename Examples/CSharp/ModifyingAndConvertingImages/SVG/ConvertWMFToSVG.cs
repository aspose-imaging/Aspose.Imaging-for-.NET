// GIST-ID: d153e2747a579cbbe1e8c49704bc7b4a
using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.ModifyingAndConvertingImages.SVG
{
    class ConvertWMFToSVG
    {
        public static void Run()
        {
            // Path to the documents directory.
            string dataDir = RunExamples.GetDataDir_SVG();

            string inputFileName = dataDir + "thistlegirl_wmfsample.wmf";
            string outputFileNameSvg = dataDir + "thistlegirl_wmfsample.svg";

            Console.WriteLine("Running example ConvertWMFToSVG");

            using (Image image = Image.Load(inputFileName))
            {
                WmfRasterizationOptions rasterizationOptions = new WmfRasterizationOptions();
                rasterizationOptions.BackgroundColor = Color.WhiteSmoke;
                rasterizationOptions.PageWidth = image.Width;
                rasterizationOptions.PageHeight = image.Height;

                image.Save(outputFileNameSvg, new SvgOptions()
                {
                    VectorRasterizationOptions = rasterizationOptions
                });
            }

            Console.WriteLine("Finished example ConvertWMFToSVG");
        }
    }
}