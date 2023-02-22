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
    internal class ConversionPlugin
    {
        static string templatesFolder = RunExamples.GetDataDir_PNG();
        string dataDir = RunExamples.GetDataDir_PNG();

        public static void Run()
        {
            Console.WriteLine("Running example Conversion Plugin");
            Run1();
            Console.WriteLine("Finished example Conversion Plugin");
        }

        //------------------------------------------------------------------------
        //  Conversion plug-in use sample
        //------------------------------------------------------------------------
        static void Run1()
        {
            // Conversion plug-in licensed use example
            License license = new License();
            try
            {
                license.SetLicense(Path.Combine(Path.Combine(templatesFolder, "License/PlugIn"), "Aspose.Imaging.Conversion.NET.lic"));
            }
            catch
            {
            }

            string OutputDirectory = templatesFolder;

            using (Image image = Image.Load(Path.Combine(templatesFolder, "template.png")))
            {
                var filePath = Path.Combine(templatesFolder, "licensed_tiger0.jpg");
                image.Save(filePath, new JpegOptions());
                File.Delete(filePath);
            }

            // Unlicensed use of resize with conversion license
            using (Image image = Image.Load(Path.Combine(templatesFolder, "template.png")))
            {
                var filePath = Path.Combine(templatesFolder, "trial_tiger0.jpg");

                image.Resize(image.Width << 1, image.Height << 1);

                image.Save(filePath, new JpegOptions());
                File.Delete(filePath);
            }
        }
    }
}
