using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Wmf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.ModifyingAndConvertingImages
{
    class CropWMFFile
    {
        public static void Run()
        {
            Console.WriteLine("Running example CropWMFFile");

            // Path to the data directory that contains the source files.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Load the WMF image, crop it, and save the result.
            using (WmfImage image = Image.Load(dataDir + "test.wmf") as WmfImage)
            {
                image.Crop(new Rectangle(10, 10, 100, 150));
                Console.WriteLine(image.Width);
                Console.WriteLine(image.Height);
                image.Save(dataDir + "test.wmf_crop.wmf");
            }

            Console.WriteLine("Finished example CropWMFFile");
        }
    }
}