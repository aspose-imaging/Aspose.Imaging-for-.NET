using Aspose.Imaging.FileFormats.Tiff.Enums;
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
    class AdjustContrast
    {
        public static void Run()
        {
            // To get proper output please apply a valid Aspose.Imaging License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            // ExStart:AdjustBrightness
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Load an image in an instance of Image
            using (Image image = Image.Load(dataDir + "aspose-logo.jpg"))
            {
                // Cast object of Image to RasterImage
                RasterImage rasterImage = (RasterImage)image;

                // Check if RasterImage is cached and Cache RasterImage for better performance
                if (!rasterImage.IsCached)
                {                  
                    rasterImage.CacheData();
                }

                // Adjust the contrast
                rasterImage.AdjustContrast(10);

                // Create an instance of TiffOptions for the resultant image, Set various properties for the object of TiffOptions and Save the resultant image to TIFF format
                TiffOptions tiffOptions = new TiffOptions(TiffExpectedFormat.Default);
                tiffOptions.BitsPerSample = new ushort[] { 8, 8, 8 };
                tiffOptions.Photometric = TiffPhotometrics.Rgb;
                rasterImage.Save(dataDir + "AdjustContrast_out.tiff", tiffOptions);
            }
            // ExEnd:TiffOptionsConfiguration
        }
    }
}
