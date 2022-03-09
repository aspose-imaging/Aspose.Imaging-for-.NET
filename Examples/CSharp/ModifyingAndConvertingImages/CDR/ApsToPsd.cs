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

            //Export vector image to PSD format keeping vector shapes

            //Aspose.Imaging allows to export vector image formats such as CDR, EMF, EPS, ODG, SVG, WMF to the PSD format, 
            //while keeping vector properties of the original, utilizing PSD Shapes, Paths //and Vector Masks.
            //Currently, export of not very complex shapes is supported, whithout texture brushes or open shapes with stroke, 
            //which will be improved in the upcoming releases.
            //Example

            //Export from the CDR format to the PSD format preserving vector 
            //properties is as simple as the following snippet:

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
