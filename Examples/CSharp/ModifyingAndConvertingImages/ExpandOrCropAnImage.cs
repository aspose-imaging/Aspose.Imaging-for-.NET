using Aspose.Imaging.ImageOptions;
using Aspose.Imaging;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    class ExpandOrCropAnImage
    {
        public static void Run()
        {
            // To get proper output please apply a valid Aspose.Imaging License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");

            // ExStart:ExpandOrCropAnImage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Load an image in an instance of Image
            using (RasterImage rasterImage = (RasterImage)Image.Load(dataDir + "aspose-logo.jpg"))
            {
                // setting for image data to be cashed
                rasterImage.CacheData();

                // Create an instance of Rectangle class and define X,Y and Width, height of the rectangle.
                Rectangle destRect = new Rectangle() { X = -200, Y = -200, Width = 300, Height = 300 };

                // Save output image by passing output file name, image options and rectangle object.
                rasterImage.Save(dataDir + "Grayscaling_out.jpg", new JpegOptions(), destRect);
            }
            // ExEnd:ExpandOrCropAnImage
        }
    }
}