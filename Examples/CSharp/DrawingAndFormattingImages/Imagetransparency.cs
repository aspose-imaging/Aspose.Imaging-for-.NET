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
    class Imagetransparency
    {
        public static void Run()
        {
            // ExStart:Imagetransparency
            // The path to the documents directory.
           
            string dataDir = RunExamples.GetDataDir_DrawingAndFormattingImages();

           string filePath = "Flower.png"; // specify your path
           using (PngImage image = (PngImage)Image.Load(filePath))
{
          float opacity = image.ImageOpacity; // opacity = 0,470798
          Console.WriteLine(opacity);
         if (opacity == 0)
{
// The image is fully transparent.
}
}
        
            }
            // ExEnd:Imagetransparency
        }
    }

