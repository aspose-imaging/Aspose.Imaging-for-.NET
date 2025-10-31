using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.PNG
{
    internal class PngCompressionLevelExample
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_PNG();

            Console.WriteLine("Running example PngCompressionLevelExample");

            using (Image image = Image.Load(Path.Combine(dataDir, @"aspose_logo.png")))
            {
                for (int compression = 0; compression <= 10; compression++)
                {
                    string outputFile = Path.Combine(dataDir, string.Format(@"compressionTest{0}.png", compression));

                    image.Save(outputFile, new PngOptions()
                    {
                        PngCompressionLevel = (PngCompressionLevel)compression
                    });

                    File.Delete(outputFile);
                }
            }

            Console.WriteLine("Finished example PngCompressionLevelExample");
        }
    }
}