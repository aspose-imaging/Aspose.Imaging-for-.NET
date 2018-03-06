/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    class Grayscaling
    {
        public static void Run()
        {
            // To get proper output please apply a valid Aspose.Imaging License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");

            //ExStart:Grayscaling
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();
           
            // Load an image in an instance of Image
            using (Image image = Image.Load(dataDir + "aspose-logo.jpg"))
            {
                // Cast the image to RasterCachedImage and Check if image is cached
                RasterCachedImage rasterCachedImage = (RasterCachedImage)image;               
                if (!rasterCachedImage.IsCached)
                {
                    // Cache image if not already cached
                    rasterCachedImage.CacheData();
                }

                // Transform image to its grayscale representation and Save the resultant image
                rasterCachedImage.Grayscale();
                rasterCachedImage.Save(dataDir + "Grayscaling_out.jpg");
            }
            //ExEnd:Grayscaling
        }
    }
}
