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
    class ExpandOrCropAnImage
    {
        public static void Run()
        {
            //ExStart:ExpandOrCropAnImage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Load an image in an instance of Image and Setting for image data to be cashed
            using (RasterImage rasterImage = (RasterImage)Image.Load(dataDir + "aspose-logo.jpg"))
            {
                rasterImage.CacheData();
                // Create an instance of Rectangle class and define X,Y and Width, height of the rectangle, and Save output image
                Rectangle destRect = new Rectangle { X = -200, Y = -200, Width = 300, Height = 300 };
                rasterImage.Save(dataDir + "Grayscaling_out.jpg", new JpegOptions(), destRect);
            }
            //ExEnd:ExpandOrCropAnImage
        }
    }
}