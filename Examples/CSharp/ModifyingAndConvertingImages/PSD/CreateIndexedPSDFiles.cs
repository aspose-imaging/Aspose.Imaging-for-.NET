using Aspose.Imaging.FileFormats.Psd;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Sources;
using System;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference 
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it, and then add its reference to this project. For any issues, questions, or suggestions 
please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.PSD
{
    class CreateIndexedPSDFiles
    {
        public static void Run()
        {
            Console.WriteLine("Running example CreateIndexedPSDFiles");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_PSD();

            // Create an instance of PsdOptions and set its properties
            var createOptions = new PsdOptions();
            createOptions.Source = new FileCreateSource(dataDir + "Newsample_out.psd", false);
            createOptions.ColorMode = ColorModes.Rgb;
            createOptions.Version = 5;

            // Create a new color palette containing RGB colors, set the Palette property, and specify the compression method
            Color[] palette = { Color.Red, Color.Green, Color.Blue };
            //createOptions.Palette = new PsdColorPalette(palette);
            createOptions.CompressionMethod = CompressionMethod.RLE;

            // Create a new PSD with the PsdOptions created previously
            using (var psd = Image.Create(createOptions, 500, 500))
            {
                // Draw some graphics over the newly created PSD
                var graphics = new Graphics(psd);
                graphics.Clear(Color.White);
                graphics.DrawEllipse(new Pen(Color.Red, 6), new Rectangle(0, 0, 400, 400));
                psd.Save(dataDir + "CreateIndexedPSDFiles_out.psd");
            }

            Console.WriteLine("Finished example CreateIndexedPSDFiles");
        }
    }
}