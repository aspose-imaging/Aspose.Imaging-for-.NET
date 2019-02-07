using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
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
            //ExStart:CroppingWMFFileWhileConvertingtoPNG
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Load an existing WMF image
            using (Image image = Image.Load(dataDir + "input.wmf"))
            {

                // Create an instance of EmfRasterizationOptions class and set different properties
                Aspose.Imaging.ImageOptions.EmfRasterizationOptions emfRasterization = new Aspose.Imaging.ImageOptions.EmfRasterizationOptions
                {
                    BackgroundColor = Color.WhiteSmoke,
                    PageWidth = 2000,
                    PageHeight = 2000
                };
                

                // Create an instance of PngOptions class and provide rasterization option
                ImageOptionsBase imageOptions = new PngOptions();
                imageOptions.VectorRasterizationOptions = emfRasterization;

                // Call the save method, provide output path and PngOptions to convert the cropped WMF file to PNG and save the output
                image.Save(dataDir + "ConvertWMFToPNG_out.png", imageOptions);
            }
            //ExEnd:CroppingWMFFileWhileConvertingtoPNG
        }
    }
}
