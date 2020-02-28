using System;
using Aspose.Imaging.ImageOptions;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    public class ConvertWMFToWebp
    {
        public static void Run()
        {
            Console.WriteLine("Running example ConvertWMFToWebp");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Load an existing WMF image
            using (Image image = Image.Load(dataDir + "input.wmf"))
            {
                // Calculate new Webp image height
                double k = (image.Width * 1.00) / image.Height;

                // Create an instance of EmfRasterizationOptions class and set different properties
                WmfRasterizationOptions emfRasterization = new WmfRasterizationOptions
                {
                    BackgroundColor = Color.WhiteSmoke,
                    PageWidth = 400,
                    PageHeight = (int)Math.Round(400 / k),
                    BorderX = 5,
                    BorderY = 10
                };

                // Create an instance of WebPOptions class and provide rasterization option
                ImageOptionsBase imageOptions = new WebPOptions();
                imageOptions.VectorRasterizationOptions = emfRasterization;

                // Call the save method, provide output path and WebPOptions to convert the WMF file to Webp and save the output
                image.Save(dataDir + "ConvertWMFToWebp_out.webp", imageOptions);
            }

            Console.WriteLine("Finished example ConvertWMFToWebp");
        }
    }
}