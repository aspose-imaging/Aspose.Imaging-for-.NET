// GIST-ID: 63a39d1a7ab1cf1d40bfb5520bbf7343
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
            // Loading and saving the image.
            using (var image = Image.Load(dataDir + "aspose-logo.jpg"))
            {
                image.Save(outputPath);
            }

            // Delete the temporary file.
            File.Delete(outputPath);

            Console.WriteLine("Finished example FileExtensionAwareSave");
            //ExEnd:RotatingAnImage
        }
    }
}