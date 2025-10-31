using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.OpenDocument;
using Aspose.Imaging.FileFormats.Tiff;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages
{
    internal class UnifyUsageOfCommonOperations
    {
        public static void Run()
        {
            Console.WriteLine("Running example UnifyUsageOfCommonOperations");
            string dataDir = RunExamples.GetDataDir_CDR();
            string fileName = "test.cdr";
            string inputFileName = Path.Combine(dataDir, fileName);

            string outputFileNamePng = Path.Combine(dataDir, "output.png");

            var filePath = inputFileName;
            var outFilePath = outputFileNamePng;
            using (var image = Image.Load(filePath))
            {
                if (image is OdImage)
                {
                    image.Crop(new Rectangle(92, 179, 260, 197));
                }
                else
                {
                    image.Crop(new Rectangle(88, 171, 250, 190));
                }

                image.Save(outFilePath, new PngOptions()
                {
                    VectorRasterizationOptions = new VectorRasterizationOptions()
                    {
                        PageSize = image.Size,
                        TextRenderingHint = TextRenderingHint.SingleBitPerPixel,
                        SmoothingMode = SmoothingMode.None
                    }
                });

                File.Delete(outFilePath);
            }

            Console.WriteLine("Finished example UnifyUsageOfCommonOperations");
        }
    }
}