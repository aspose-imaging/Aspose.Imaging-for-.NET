using System.IO;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Sources;

namespace Aspose.Imaging.Examples.CSharp.DrawingAndFormattingImages
{
    public class CreatingAnImageBySettingPath
    {
        public static void Run()
        {
            // ExStart:CreatingAnImageBySettingPath
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DrawingAndFormattingImages();
            
            // Creates an instance of BmpOptions and set its various properties
            BmpOptions ImageOptions = new BmpOptions();
            ImageOptions.BitsPerPixel = 24;

            // Define the source property for the instance of BmpOptions
            // Second boolean parameter determines if the file is temporal or not
            ImageOptions.Source = new FileCreateSource(dataDir + "CreatingAnImageBySettingPath_out.bmp", false);

            // Creates an instance of Image and call Create method by passing the BmpOptions object
            using (Image image = Image.Create(ImageOptions, 500, 500))
            {
                image.Save(dataDir + "CreatingAnImageBySettingPath1_out.bmp");
            }
            // ExEnd:CreatingAnImageBySettingPath
        }
    }
}