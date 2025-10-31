using Aspose.Imaging;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Sources;
using System;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information.
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/,
install it, and then add its reference to this project. For any issues, questions, or suggestions,
please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.DrawingAndFormattingImages
{
    public class CreatingAnImageBySettingPath
    {
        public static void Run()
        {
            Console.WriteLine("Running example CreatingAnImageBySettingPath");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DrawingAndFormattingImages();

            // Create an instance of BmpOptions and set its properties.
            BmpOptions ImageOptions = new BmpOptions();
            ImageOptions.BitsPerPixel = 24;

            // Define the source property for the BmpOptions instance.
            // The second boolean parameter determines whether the file is temporary or not.
            ImageOptions.Source = new FileCreateSource(dataDir + "CreatingAnImageBySettingPath_out.bmp", false);

            // Create an Image instance using the BmpOptions object.
            using (Image image = Image.Create(ImageOptions, 500, 500))
            {
                image.Save(dataDir + "CreatingAnImageBySettingPath1_out.bmp");
            }

            Console.WriteLine("Finished example CreatingAnImageBySettingPath");
        }
    }
}