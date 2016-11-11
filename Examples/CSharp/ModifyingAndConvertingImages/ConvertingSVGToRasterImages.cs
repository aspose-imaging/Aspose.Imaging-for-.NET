using Aspose.Imaging.FileFormats.Svg;
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
    public class ConvertingSVGToRasterImages
    {
        public static void Run()
        {
            // ExStart:ApplyingMotionWienerFilter
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Load the image
            using (SvgImage image = (SvgImage)Image.Load(dataDir + "aspose_logo.Svg"))
            {
                // Create an instance of PNG options and Save the results to disk
                PngOptions pngOptions = new PngOptions();
                image.Save(dataDir + "ConvertingSVGToRasterImages_out.png", pngOptions);
            }
            // ExEnd:ApplyingMotionWienerFilter
        }
    }
}