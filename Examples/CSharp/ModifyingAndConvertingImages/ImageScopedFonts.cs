using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages
{
    class ImageScopedFonts
    {
        public static void Run()
        {
            Console.WriteLine("Running example ImageScopedFonts");
            string dataDir = RunExamples.GetDataDir_MetaFiles();
            string[] files = new string[] { "missing-font.emf", "missing-font.odg", "missing-font.wmf", "missing-font.svg" };

            string outputFilePath = Path.Combine(dataDir, "img4.tif.500ms.png");

            foreach (var file in files)
            {
                string outputPath = Path.Combine(dataDir, file + ".png");                
                CustomFontSourceTest(dataDir, dataDir, file, Path.Combine(dataDir, "Fonts"));
                File.Delete(outputPath);
            }                        

            Console.WriteLine("Finished example ImageScopedFonts");
        }

        public static void CustomFontSourceTest(string inputPath, string outputPath, string fileName, string fontPath)
        {
            var loadOptions = new Aspose.Imaging.LoadOptions();
            loadOptions.AddCustomFontSource(GetFontSource, fontPath);
            using (var img = Image.Load(Path.Combine(inputPath, fileName), loadOptions))
            {
                Aspose.Imaging.ImageOptions.VectorRasterizationOptions vectorRasterizationOptions =
                    (Aspose.Imaging.ImageOptions.VectorRasterizationOptions)img.GetDefaultOptions(new object[] { Color.White, img.Width, img.Height });
                vectorRasterizationOptions.TextRenderingHint = Aspose.Imaging.TextRenderingHint.SingleBitPerPixel;
                vectorRasterizationOptions.SmoothingMode = Aspose.Imaging.SmoothingMode.None;

                img.Save(Path.Combine(outputPath, fileName + ".png"), new Aspose.Imaging.ImageOptions.PngOptions
                {
                    VectorRasterizationOptions = vectorRasterizationOptions
                });
            }
        }

        // The custom fonts provider example. 
        public static Aspose.Imaging.CustomFontHandler.CustomFontData[] GetFontSource(params object[] args)
        {
            string fontsPath = string.Empty;
            if (args.Length > 0)
            {
                fontsPath = args[0].ToString();
            }

            var customFontData = new List<Aspose.Imaging.CustomFontHandler.CustomFontData>();
            foreach (var font in Directory.GetFiles(fontsPath))
            {
                customFontData.Add(new Aspose.Imaging.CustomFontHandler.CustomFontData(Path.GetFileNameWithoutExtension(font), File.ReadAllBytes(font)));
            }

            return customFontData.ToArray();
        }
    }
}
