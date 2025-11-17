// GIST-ID: 9b07facf3b639495573de98396eaa609
using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CSharp.ModifyingAndConvertingImages.SVG
{
    class SVGToEMFConversion
    {
        public static void Run()
        {

            //ExStart:SVGToEMFConversion
            string dataDir = RunExamples.GetDataDir_SVG();
            string[] testFiles = new string[] { "mysvg.svg" };

            string outputPath = Path.Combine(dataDir, "output");

            if (!Directory.Exists(outputPath))
            {
                Directory.CreateDirectory(outputPath);
            }

            Console.WriteLine("Running example SVGToEMFConversion");

            foreach (string fileName in testFiles)
            {
                string inputFileName = Path.Combine(dataDir, fileName);
                string outputFileName = Path.Combine(outputPath, fileName + ".emf");
                using (Image image = Image.Load(inputFileName))
                {
                    image.Save(
                        outputFileName,
                        new EmfOptions
                        {
                            VectorRasterizationOptions =
                                new SvgRasterizationOptions { PageSize = image.Size }
                        });
                }
            }

            Console.WriteLine("Finished example SVGToEMFConversion");
        }
    }
}