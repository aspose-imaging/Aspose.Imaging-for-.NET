// GIST-ID: a8a9e6e02cd79c2ab1886dd3c115ad7e
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
            // Path to the directory that contains the sample documents.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Load an existing WMF image.
            using (WmfImage image = (WmfImage)Image.Load(dataDir + "File.wmf"))
            {
                image.Crop(new Rectangle(10, 10, 70, 70));
                
                // Create a WmfRasterizationOptions object and configure its properties.
                Aspose.Imaging.ImageOptions.WmfRasterizationOptions emfRasterization = new Aspose.Imaging.ImageOptions.WmfRasterizationOptions
                {
                    BackgroundColor = Color.WhiteSmoke,
                    PageWidth = 1000,
                    PageHeight = 1000
                };
                

                // Create a PngOptions instance and assign the rasterization options.
                ImageOptionsBase imageOptions = new PngOptions();
                imageOptions.VectorRasterizationOptions = emfRasterization;

                // Save the cropped image as PNG using the specified options.
                image.Save(dataDir + "ConvertWMFToPNG_out.png", imageOptions);
            }

            Console.WriteLine("Finished example CroppingWMFFileWhileConvertingtoPNG");
        }
    }
}