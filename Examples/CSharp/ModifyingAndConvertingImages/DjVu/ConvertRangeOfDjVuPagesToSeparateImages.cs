using Aspose.Imaging.FileFormats.Djvu;
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
    public class ConvertRangeOfDjVuPagesToSeparateImages
    {
        public static void Run()
        {
            // ExStart:ConvertRangeOfDjVuPagesToSeparateImages
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DjVu();

            // Load a DjVu image
            using (DjvuImage image = (DjvuImage)Image.Load(dataDir + "Sample.djvu"))
            {
                // Create an instance of BmpOptions and Set BitsPerPixel for resultant images
                BmpOptions exportOptions = new BmpOptions();
                exportOptions.BitsPerPixel = 32;

                // Create an instance of IntRange and initialize it with range of pages to be exported
                IntRange range = new IntRange(0, 2);
                int counter = 0;
                foreach (var i in range.Range)
                {
                    // Save each page in separate file, as BMP do not support layering
                    exportOptions.MultiPageOptions = new DjvuMultiPageOptions(range.GetArrayOneItemFromIndex(counter));
                    image.Save(dataDir + string.Format("{0}_out.bmp", counter++), exportOptions);
                }
            }
            // ExEnd:ConvertRangeOfDjVuPagesToSeparateImages
        }
    }
}