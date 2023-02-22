using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Tiff;
using Aspose.Imaging.FileFormats.Tiff.Enums;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Imaging.Sources;
using Aspose.Imaging.FileFormats.Png;


namespace CSharp.Plugins
{
    internal class ResizePlugin
    {
        static string templatesFolder = RunExamples.GetDataDir_PNG();
        string dataDir = RunExamples.GetDataDir_PNG();

        public static void Run()
        {
            Console.WriteLine("Running example Resize Plugin");
            Run3();
            Console.WriteLine("Finished example Resize Plugin");
        }


        //------------------------------------------------------------------------------
        // Resize plug-in license use examples
        //------------------------------------------------------------------------------
        static void Run3()
        {
            // Valid resize license use example
            License license = new License();
            try
            {
                license.SetLicense(Path.Combine(Path.Combine(templatesFolder, "License/PlugIn"), "Aspose.Imaging.Resize.NET.lic"));
            }
            catch
            {
            }

            string OutputDirectory = templatesFolder;
            if (!Directory.Exists(OutputDirectory))
            {
                Directory.CreateDirectory(OutputDirectory);
            }
            using (Image image = Image.Load(Path.Combine(templatesFolder, "template.png")))
            {
                var filePath = Path.Combine(OutputDirectory, "licensed_tiger0.jpg");

                image.Resize(image.Width << 1, image.Height << 1);

                image.Save(filePath, new JpegOptions());
                File.Delete(filePath);
            }

            // Unlicensed use of flip rotate with resize license
            using (Image image = Image.Load(Path.Combine(templatesFolder, "template.png")))
            {
                var filePath = Path.Combine(OutputDirectory, "trial_tiger0.jpg");

                image.RotateFlip(RotateFlipType.Rotate180FlipXY);

                image.Save(filePath, new JpegOptions());
                File.Delete(filePath);
            }
        }
    }
}
