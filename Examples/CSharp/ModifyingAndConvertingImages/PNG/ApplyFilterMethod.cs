using Aspose.Imaging.FileFormats.Png;
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
    class ApplyFilterMethod
    {
        public static void Run()
        {            
            //ExStart:ApplyFilterMethod
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_PNG();

            using (PngImage png = (PngImage)Image.Load(dataDir + "aspose_logo.png"))
            {
                // Create an instance of PngOptions, Set the PNG filter method and Save changes to the disc
                PngOptions options = new PngOptions();
                options.FilterType = PngFilterType.Paeth;
                png.Save(dataDir + "ApplyFilterMethod_out.jpg", options);
            }
            //ExEnd:ApplyFilterMethod
        }
    }
}