// GIST-ID: 23e6877cffc6247e54359c40bbc46dcc
using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Psd;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.CDR
{
    class ApsToPsd
    {
        public static void Run()
        {
            Console.WriteLine("Running example ApsToPsd");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CDR();

            string inputFileName = dataDir + "SimpleShapes.cdr";

            // Export vector image to PSD format while keeping vector shapes.

            // Aspose.Imaging allows exporting vector image formats such as CDR, EMF, EPS, ODG, SVG, and WMF
            // to the PSD format while preserving the original's vector properties using PSD shapes,
            // paths, and vector masks.

            // Currently, export of moderately complex shapes is supported, without texture brushes or
            // open shapes with stroke. This functionality will be improved in upcoming releases.

            // Example: export from the CDR format to the PSD format preserving vector properties.

            using (Image image = Image.Load(inputFileName))
            {
                PsdOptions imageOptions = new PsdOptions()
                {
                    VectorRasterizationOptions = new VectorRasterizationOptions(),
                    VectorizationOptions = new PsdVectorizationOptions()
                    {
                        VectorDataCompositionMode = VectorDataCompositionMode.SeparateLayers
                    }
                };
                imageOptions.VectorRasterizationOptions.PageWidth = image.Width;
                imageOptions.VectorRasterizationOptions.PageHeight = image.Height;

                image.Save(dataDir + "result.psd", imageOptions);
            }

            File.Delete(dataDir + "result.psd");

            Console.WriteLine("Finished example ApsToPsd");
        }
    }
}