using Aspose.Imaging.ImageOptions;
using System;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API 
reference when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it, and then add its reference to this project. For any issues, questions, or suggestions, 
please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    class ExpandOrCropAnImage
    {
        public static void Run()
        {
            Console.WriteLine("Running example ExpandOrCropAnImage");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Load an image into an Image instance and cache its data.
            using (RasterImage rasterImage = (RasterImage)Image.Load(dataDir + "aspose-logo.jpg"))
            {
                rasterImage.CacheData();
                // Create a Rectangle that defines the X, Y, width, and height of the region, then save the output image.
                Rectangle destRect = new Rectangle { X = -200, Y = -200, Width = 300, Height = 300 };
                rasterImage.Save(dataDir + "Grayscaling_out.jpg", new JpegOptions(), destRect);
            }

            Console.WriteLine("Finished example ExpandOrCropAnImage");
        }
    }
}