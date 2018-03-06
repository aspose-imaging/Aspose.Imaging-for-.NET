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
    public class ResizeWMFFile
    {
        public static void Run()
        {
            //ExStart:ResizeWMFFile
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Load an existing WMF image
            using (Image image = Image.Load(dataDir + "input.wmf"))
            {
                // Call the resize method of Image class and width,height values and Calculate new PNG image height
                image.Resize(100, 100);
                double k = (image.Width * 1.00) / image.Height;

                // Create an instance of EmfRasterizationOptions class and set different properties
                EmfRasterizationOptions emfRasterization = new EmfRasterizationOptions
                {
                    BackgroundColor = Color.WhiteSmoke,
                    PageWidth = 100,
                    PageHeight = (int)Math.Round(100 / k),
                    BorderX = 5,
                    BorderY = 10
                };

                // Create an instance of PngOptions class and provide rasterization option
                ImageOptionsBase imageOptions = new PngOptions();
                imageOptions.VectorRasterizationOptions = emfRasterization;

                // Call the save method, provide output path and PngOptions to convert the WMF file to PNG and save the output
                image.Save(dataDir + "CreateEMFMetaFileImage_out.png", imageOptions);
                //ExStart:ResizeWMFFile
            }
        }
    }
}