using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.SVG
{
    class UnifyExtractionOfRasterImagesEmbeddedInVectorFormats
    {
        public static void Run()
        {
            Console.WriteLine("Running example UnifyExtractionOfRasterImagesEmbeddedInVectorFormats");
            
            string dataDir = RunExamples.GetDataDir_SVG();            
            string fileName = Path.Combine(dataDir, "test2.svg");
            
            var outputFolder = dataDir;
            List<string> files = new List<string>();                        

            using (Image image = Image.Load(fileName))
            {
                var images = ((VectorImage)image).GetEmbeddedImages();
                int i = 0;
                foreach (EmbeddedImage im in images)
                {
                    string outFileName = string.Format("svg_image{0}{1}", i++, GetExtension(im.Image.FileFormat));
                    string outFilePath = Path.Combine(outputFolder, outFileName);
                    files.Add(outFilePath);
                    using (im)
                    {
                        im.Image.Save(outFilePath);
                    }
                }
            }

            foreach (string file in files)
            {
                File.Delete(file);
            }

            Console.WriteLine("Finished example UnifyExtractionOfRasterImagesEmbeddedInVectorFormats");
        }

        private static string GetExtension(FileFormat format)
        {
            switch (format)
            {
                case FileFormat.Jpeg:
                    return ".jpg";
                case FileFormat.Png:
                    return ".png";
                case FileFormat.Bmp:
                    return ".bmp";

                default:
                    return "." + format.ToString();
            }
        }
    }
}