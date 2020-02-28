using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Wmf;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.ModifyingAndConvertingImages
{
    class CroppingWMFFileWhileConvertingtoPNG
    {
        public static void Run()
        {
            Console.WriteLine("Running example CroppingWMFFileWhileConvertingtoPNG");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Load an existing WMF image
            using (WmfImage image = (WmfImage)Image.Load(dataDir + "File.wmf"))
            {
                image.Crop(new Rectangle(10, 10, 70, 70));
                
                // Create an instance of EmfRasterizationOptions class and set different properties
                Aspose.Imaging.ImageOptions.WmfRasterizationOptions emfRasterization = new Aspose.Imaging.ImageOptions.WmfRasterizationOptions
                {
                    BackgroundColor = Color.WhiteSmoke,
                    PageWidth = 1000,
                    PageHeight = 1000
                };
                

                // Create an instance of PngOptions class and provide rasterization option
                ImageOptionsBase imageOptions = new PngOptions();
                imageOptions.VectorRasterizationOptions = emfRasterization;

                // Call the save method, provide output path and PngOptions to convert the cropped WMF file to PNG and save the output
                image.Save(dataDir + "ConvertWMFToPNG_out.png", imageOptions);
            }

            Console.WriteLine("Finished example CroppingWMFFileWhileConvertingtoPNG");
        }
    }
}
