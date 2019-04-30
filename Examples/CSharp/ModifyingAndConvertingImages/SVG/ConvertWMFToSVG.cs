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

            //ExStart:ConvertWMFToSVG
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_SVG();

            string inputFileName = dataDir + "thistlegirl_wmfsample.wmf";
            string outputFileNameSvg = dataDir + "thistlegirl_wmfsample.svg";


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
            //ExEnd:ConvertWMFToSVG


        }
    }
}
