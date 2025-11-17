// GIST-ID: 12cc627520b497a70957db3c128a5241
using Aspose.Imaging;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Sources;
using System;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information.
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/,
install it, and then add its reference to this project. For any issues, questions, or suggestions,
please feel free to contact us using https://forum.aspose.com/.
*/

namespace Aspose.Imaging.Examples.CSharp.DrawingAndFormattingImages
{
    class CombineImages
    {
        public static void Run()
        {
            Console.WriteLine("Running example CombineImages");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DrawingAndFormattingImages();

            // Create an instance of JpegOptions and set its various properties.
            JpegOptions imageOptions = new JpegOptions();

            // Create an instance of FileCreateSource and assign it to the Source property.
            imageOptions.Source = new FileCreateSource(dataDir + "Two_images_result_out.bmp", false);

            // Create an instance of Image and define the canvas size.
            using (var image = Image.Create(imageOptions, 600, 600))
            {
                // Create and initialise an instance of Graphics, clear the image surface with white colour, and draw images.
                var graphics = new Graphics(image);
                graphics.Clear(Color.White);
                graphics.DrawImage(Image.Load(dataDir + "sample_1.bmp"), 0, 0, 600, 300);
                graphics.DrawImage(Image.Load(dataDir + "File1.bmp"), 0, 300, 600, 300);
                image.Save();
            }

            Console.WriteLine("Finished example CombineImages");
        }
    }
}