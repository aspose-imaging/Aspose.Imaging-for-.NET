// GIST-ID: a34e8cb9f75682a68e1d83f503a78a69
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Imaging.FileFormats.Png;
using Aspose.Imaging.ImageOptions;
using System.IO;

namespace CSharp.ModifyingAndConvertingImages.Remove_background
{
    internal class RemoveBackgroundVectors
    {
        public static void Run()
        {
            Console.WriteLine("Running example RemoveBackgroundVectors");

            // Path to the documents directory.
            string dataDir = RunExamples.GetDataDir_RemoveBacground();

            var fileNames = new string[] { "golfer.emf" };
            var rbs = new RemoveBackgroundSettings[]
            {
                 new RemoveBackgroundSettings()
                 {
                     DetectionLevel = 30
                 },
                 new RemoveBackgroundSettings()
                 {
                     Bounds = new RectangleF(0, 1000, 5000, 4000)
                 },
                 new RemoveBackgroundSettings()
                 {
                     DetectionLevel = 10
                 },
                 new RemoveBackgroundSettings()
                 {

                 },
                 new RemoveBackgroundSettings()
                 {

                 },
                 new RemoveBackgroundSettings()
                 {

                 },
                 new RemoveBackgroundSettings()
                 {
                     Color1 = Color.Blue
                 },
                 new RemoveBackgroundSettings()
                 {

                 }
            };

            for (int i = 0; i < fileNames.Length; i++)
            {
                RemoveBackgroundExample(fileNames[i], dataDir, rbs[i]);
            }

            Console.WriteLine("Finished example RemoveBackgroundVectors");
        }

        private static void RemoveBackgroundExample(string fileName, string dataDir, RemoveBackgroundSettings settings)
        {
            var baseFolder = dataDir;
            var inputFilePath = Path.Combine(baseFolder, fileName);
            var outFilePath = Path.Combine(baseFolder, "output");
            if (!Directory.Exists(outFilePath))
            {
                Directory.CreateDirectory(outFilePath);
            }

            using (var image = Image.Load(inputFilePath))
            {
                var options = new PngOptions()
                {
                    ColorType = PngColorType.TruecolorWithAlpha,
                    VectorRasterizationOptions = new VectorRasterizationOptions()
                    {
                        BackgroundColor = Color.Transparent,
                        PageSize = image.Size
                    }
                };

                var vectorImage = image as VectorImage;
                if (vectorImage != null)
                {
                    vectorImage.RemoveBackground(settings);
                }

                image.Save(Path.Combine(outFilePath, fileName + ".png"), options);
                File.Delete(Path.Combine(outFilePath, fileName + ".png"));
            }
        }
    }
}