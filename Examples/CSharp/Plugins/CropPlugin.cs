using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Plugins
{
    internal class CropPlugin
    {
        static string templatesFolder = RunExamples.GetDataDir_PNG();
        string dataDir = RunExamples.GetDataDir_PNG();

        public static void Run()
        {
            Console.WriteLine("Running example Crop Plugin");
            Run2();
            Console.WriteLine("Finished example Crop Plugin");
        }

        //-----------------------------------------------------------------
        // Crop plug-in license use examples
        //-----------------------------------------------------------------
        static void Run2()
        {
            // Valid crop licesing usage example
            License license = new License();
            try
            {
                license.SetLicense(Path.Combine(Path.Combine(templatesFolder, "License/PlugIn"), "Aspose.Imaging.Crop.NET.lic"));
            }
            catch
            {
            }

            string OutputDirectory = templatesFolder;

            using (var image = (RasterImage)Image.Load(Path.Combine(templatesFolder, "template.png")))
            {
                var filePath = Path.Combine(OutputDirectory, "licensed_tiger0.jpg");

                image.Crop(new Rectangle(0, 0, image.Width >> 1, image.Height >> 1));

                image.Save(filePath, new JpegOptions());
                File.Delete(filePath);
            }

            // Unlicensed use of resize with crop license
            using (Image image = Image.Load(Path.Combine(templatesFolder, "template.png")))
            {
                var filePath = Path.Combine(OutputDirectory, "trial_tiger0.jpg");

                image.Resize(image.Width << 1, image.Height << 1);

                image.Save(filePath, new JpegOptions());
                File.Delete(filePath);
            }
        }
    }
}
