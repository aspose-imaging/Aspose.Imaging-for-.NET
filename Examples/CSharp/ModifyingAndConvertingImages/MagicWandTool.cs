// GIST-ID: 086de41b1c8b059d902ee9885527707a
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Imaging.MagicWand.ImageMasks;
using Aspose.Imaging.MagicWand;

namespace CSharp.ModifyingAndConvertingImages
{
    public class MagicWandTool
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_PNG();

            Console.WriteLine("Running example MagicWand");

            using (RasterImage image = (RasterImage)Image.Load(Path.Combine(dataDir, @"src.png")))
            {
                // Create a new mask using the Magic Wand tool based on the tone and color of pixel {845, 128}.
                Aspose.Imaging.MagicWand.MagicWandTool.Select(image, new MagicWandSettings(845, 128))
                    // Union the existing mask with the mask created by the Magic Wand tool at the specified coordinates.
                    .Union(new MagicWandSettings(416, 387))
                    // Invert the current mask.
                    .Invert()
                    // Subtract the mask created by the Magic Wand tool (threshold set to 69) from the existing mask.
                    .Subtract(new MagicWandSettings(1482, 346) { Threshold = 69 })
                    // Subtract four specified rectangular masks from the existing mask, one by one.
                    .Subtract(new RectangleMask(0, 0, 800, 150))
                    .Subtract(new RectangleMask(0, 380, 600, 220))
                    .Subtract(new RectangleMask(930, 520, 110, 40))
                    .Subtract(new RectangleMask(1370, 400, 120, 200))
                    // Feather the mask using the specified settings.
                    .GetFeathered(new FeatheringSettings() { Size = 3 })
                    // Apply the mask to the image.
                    .Apply();

                image.Save(Path.Combine(dataDir, @"result.png"));
                File.Delete(Path.Combine(dataDir, @"result.png"));
            }

            Console.WriteLine("Finished example MagicWand");
        }
    }
}