/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.JPEG
{
    class CroppingByRectangle
    {
        public static void Run()
        {
            //ExStart:CroppingByRectangle
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_JPEG();

            // Load an existing image into an instance of RasterImage class
            using (RasterImage rasterImage = (RasterImage)Image.Load(dataDir + "aspose-logo.jpg"))
            {
                if (!rasterImage.IsCached)
                {
                    rasterImage.CacheData();
                }

                // Create an instance of Rectangle class with desired size, Perform the crop operation on object of Rectangle class and Save the results to disk
                Rectangle rectangle = new Rectangle(20, 20, 20, 20);
                rasterImage.Crop(rectangle);
                rasterImage.Save(dataDir + "CroppingByRectangle_out.jpg");
            }
            //ExEnd:CroppingByRectangle
        }        
    }
}
