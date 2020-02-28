using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Emf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.ModifyingAndConvertingImages
{
    class CropEMFFile
    {
        public static void Run()
        {
            Console.WriteLine("Running example CropEMFFile");

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            using (EmfImage image = Image.Load(dataDir + "test.emf") as EmfImage)
            {
                image.Crop(new Rectangle(10, 10, 100, 150));
                Console.WriteLine(image.Width);
                Console.WriteLine(image.Height);
                image.Save(dataDir + "test.emf_crop.emf");
            }

            Console.WriteLine("Finished example CropEMFFile");
        }

    }
}
