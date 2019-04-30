using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Cdr;
using Aspose.Imaging.FileFormats.Cmx;
using Aspose.Imaging.FileFormats.Emf;
using Aspose.Imaging.FileFormats.OpenDocument;
using Aspose.Imaging.FileFormats.Svg;
using Aspose.Imaging.FileFormats.Wmf;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.ModifyingAndConvertingImages
{
    class SupportOfSmoothingMode
    {
        public static void Run() {

            //ExStart:SupportOfSmoothingMode

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();


         string[] files = new string[] {
         "SmoothingTest.cdr",
         "SmoothingTest.cmx",
         "SmoothingTest.emf",
         "SmoothingTest.wmf",
         "SmoothingTest.odg",
         "SmoothingTest.svg"
        };
            SmoothingMode[] smoothingModes = new SmoothingMode[] {
                 SmoothingMode.AntiAlias, SmoothingMode.None
                };
            foreach (string fileName in files)
            {
                using (Image image = Image.Load(dataDir + fileName))
                {
                    VectorRasterizationOptions vectorRasterizationOptions;
                    if (image is CdrImage)
                    {
                        vectorRasterizationOptions = new CdrRasterizationOptions();
                    }
                    else if (image is CmxImage)
                    {
                        vectorRasterizationOptions = new CmxRasterizationOptions();
                    }
                    else if (image is EmfImage)
                    {
                        vectorRasterizationOptions = new EmfRasterizationOptions();
                    }
                    else if (image is WmfImage)
                    {
                        vectorRasterizationOptions = new WmfRasterizationOptions();
                    }
                    else if (image is OdgImage)
                    {
                        vectorRasterizationOptions = new OdgRasterizationOptions();
                    }
                    else if (image is SvgImage)
                    {
                        vectorRasterizationOptions = new SvgRasterizationOptions();
                    }
                    else
                    {
                        throw new Exception("This is image is not supported in this example");
                    }
                    vectorRasterizationOptions.PageSize = image.Size;
                    foreach (SmoothingMode smoothingMode in smoothingModes)
                    {
                       
                        string outputFileName = dataDir + "SM/image_" + smoothingMode + "_" + fileName + ".png";
                        vectorRasterizationOptions.SmoothingMode = smoothingMode;
                        image.Save(outputFileName, new PngOptions()
                        {
                            VectorRasterizationOptions = vectorRasterizationOptions
                        });
                    }
                }
            }

            //ExEnd:SupportOfSmoothingMode

        }
    }
}
