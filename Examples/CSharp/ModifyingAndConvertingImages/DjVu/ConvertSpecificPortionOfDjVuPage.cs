using Aspose.Imaging.FileFormats.Djvu;
using Aspose.Imaging.FileFormats.Png;
using Aspose.Imaging.ImageOptions;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.DjVu
{
    public class ConvertSpecificPortionOfDjVuPage
    {
        public static void Run()
        {
            //ExStart:ConvertSpecificPortionOfDjVuPage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DjVu();

            // Load a DjVu image
            using (DjvuImage image = (DjvuImage)Image.Load(dataDir + "Sample.djvu"))
            {
                // Create an instance of PngOptions and Set ColorType to Grayscale
                PngOptions exportOptions = new PngOptions();
                exportOptions.ColorType = PngColorType.Grayscale;
                
                // Create an instance of Rectangle and specify the portion on DjVu page
                Rectangle exportArea = new Rectangle(0, 0, 500, 500);

                // Specify the DjVu page index and Initialize an instance of DjvuMultiPageOptions while passing index of DjVu page index and instance of Rectangle covering the area to be exported               
                int exportPageIndex = 2;
                exportOptions.MultiPageOptions = new DjvuMultiPageOptions(exportPageIndex, exportArea);
                image.Save(dataDir + "ConvertSpecificPortionOfDjVuPage_out.djvu", exportOptions);
            }
            //ExEnd:ConvertSpecificPortionOfDjVuPage
        }
    }
}