using Aspose.Imaging.FileFormats.Psd;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Sources;
using Aspose.Imaging;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.PSD
{
    class CreateIndexedPSDFiles
    {
        public static void Run()
        {
            // ExStart:CreateIndexedPSDFiles
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_PSD();

            // Create an instance of PsdOptions and set it's properties
            var createOptions = new PsdOptions();
            // Set source
            createOptions.Source = new FileCreateSource(dataDir + "Newsample_out.psd", false);
            // Set ColorMode to Indexed
            createOptions.ColorMode = ColorModes.Indexed;
            // Set PSD file version
            createOptions.Version = 5;
            // Create a new color patelle having RGB colors
            Color[] palette = { Color.Red, Color.Green, Color.Blue };
            // Set Palette property to newly created palette
            createOptions.Palette = new PsdColorPalette(palette);
            // Set compression method
            createOptions.CompressionMethod = CompressionMethod.RLE;

            // Create a new PSD with PsdOptions created previously
            using (var psd = PsdImage.Create(createOptions, 500, 500))
            {
                // Draw some graphics over the newly created PSD
                var graphics = new Graphics(psd);
                graphics.Clear(Color.White);
                graphics.DrawEllipse(new Pen(Color.Red, 6), new Rectangle(0, 0, 400, 400));
                psd.Save(dataDir + "CreateIndexedPSDFiles_out.psd");
            }
            // ExEnd:CreateIndexedPSDFiles
        }
    }
}