using Aspose.Imaging.ImageOptions;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.PNG
{
    class CompressingFiles
    {
        public static void Run()
        {
            // ExStart:CompressingFiles
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_PNG();
 
            // Load an image from file (or stream)
            using (Image image = Image.Load(dataDir + "aspose_logo.png"))
            {
                // Loop over possible CompressionLevel range
                for (int i = 0; i <= 9; i++)
                {
                    // Create an instance of PngOptions for each resultant PNG, Set CompressionLevel and  Save result on disk
                    PngOptions options = new PngOptions();
                    options.CompressionLevel = i;
                    image.Save(i + "_out.png", options);
                }
            }
            // ExEnd:CompressingFiles
        }
    }
}