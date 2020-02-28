using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.ModifyingAndConvertingImages
{
    class SupportOfDIB
    {
        public static void Run()
        {

            Console.WriteLine("Running example SupportOfDIB");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            using (Image image = Image.Load(dataDir + "sample.dib"))
            {

                Console.WriteLine(image.FileFormat); // Output is "Bmp"
                image.Save(dataDir + "sample.png", new PngOptions());

            }

            Console.WriteLine("Finished example SupportOfDIB");
        }
    }
}