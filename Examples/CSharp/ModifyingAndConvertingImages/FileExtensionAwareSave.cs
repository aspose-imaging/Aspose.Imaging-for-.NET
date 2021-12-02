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
    class FileExtensionAwareSave
    {
        public static void Run()
        {
            //ExStart:RotatingAnImage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_JPEG();
            string outputPath = dataDir + "output.png";

            Console.WriteLine("Running example FileExtensionAwareSave");
            // Loading and Rotating Image
            using (var image = Image.Load(dataDir + "aspose-logo.jpg"))
            {
                image.Save(outputPath);
            }

            File.Delete(outputPath);

            Console.WriteLine("Finished example FileExtensionAwareSave");
            //ExEnd:RotatingAnImage
        }
    }
}
