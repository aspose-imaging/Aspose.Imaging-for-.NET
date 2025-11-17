// GIST-ID: 654ea61d1c2a0d20585b54cce3d7e2a2
using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.ModifyingAndConvertingImages
{
    class ConvertWMFToPNG
    {
        public static void Run()
        {
            Console.WriteLine("Running example ConvertWMFToPNG");

            // Path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            string inputFileName = dataDir + "thistlegirl_wmfsample.wmf";
            string outputFileNamePng = dataDir + "thistlegirl_wmfsample.png";

            using (Image image = Image.Load(inputFileName))
            {
                WmfRasterizationOptions rasterizationOptions = new WmfRasterizationOptions
                {
                    BackgroundColor = Color.WhiteSmoke,
                    PageWidth = image.Width,
                    PageHeight = image.Height
                };

                image.Save(outputFileNamePng, new PngOptions { VectorRasterizationOptions = rasterizationOptions });
            }

            Console.WriteLine("Finished example ConvertWMFToPNG");
        }
    }
}