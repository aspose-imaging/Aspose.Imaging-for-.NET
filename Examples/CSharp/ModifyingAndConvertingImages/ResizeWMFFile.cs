using System;
using Aspose.Imaging.ImageOptions;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference 
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it, and then add its reference to this project. For any issues, questions, or suggestions, 
please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    public class ResizeWMFFile
    {
        public static void Run()
        {
            Console.WriteLine("Running example ResizeWMFFile");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Load an existing WMF image.
            using (Image image = Image.Load(dataDir + "input.wmf"))
            {
                // Call the Resize method of the Image class with width and height values,
                // and calculate the new PNG image height.
                image.Resize(100, 100);
                double k = (image.Width * 1.00) / image.Height;

                // Create an instance of WmfRasterizationOptions and set its properties.
                WmfRasterizationOptions emfRasterization = new WmfRasterizationOptions
                {
                    BackgroundColor = Color.WhiteSmoke,
                    PageWidth = 100,
                    PageHeight = (int)Math.Round(100 / k),
                    BorderX = 5,
                    BorderY = 10
                };

                // Create an instance of PngOptions and provide the rasterization options.
                ImageOptionsBase imageOptions = new PngOptions();
                imageOptions.VectorRasterizationOptions = emfRasterization;

                // Save the image, providing the output path and PngOptions to convert the WMF file to PNG.
                image.Save(dataDir + "CreateEMFMetaFileImage_out.png", imageOptions);
                //ExStart:ResizeWMFFile
            }

            Console.WriteLine("Finished example ResizeWMFFile");
        }
    }
}