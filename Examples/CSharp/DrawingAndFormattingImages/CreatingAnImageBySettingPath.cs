using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Sources;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.DrawingAndFormattingImages
{
    public class CreatingAnImageBySettingPath
    {
        public static void Run()
        {
            //ExStart:CreatingAnImageBySettingPath
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DrawingAndFormattingImages();
            
            // Creates an instance of BmpOptions and set its various properties
            BmpOptions ImageOptions = new BmpOptions();
            ImageOptions.BitsPerPixel = 24;

            // Define the source property for the instance of BmpOptions  Second boolean parameter determines if the file is temporal or not
            ImageOptions.Source = new FileCreateSource(dataDir + "CreatingAnImageBySettingPath_out.bmp", false);

            // Creates an instance of Image and call Create method by passing the BmpOptions object
            using (Image image = Image.Create(ImageOptions, 500, 500))
            {
                image.Save(dataDir + "CreatingAnImageBySettingPath1_out.bmp");
            }
            //ExEnd:CreatingAnImageBySettingPath
        }
    }
}