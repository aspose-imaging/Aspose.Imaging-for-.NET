// GIST-ID: 2c872364943e3b2f2256414328a6da93
/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference 
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it, and then add its reference to this project. For any issues, questions, or suggestions 
please feel free to contact us using https://forum.aspose.com/
*/

using System;
namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.JPEG
{
    class CroppingByRectangle
    {
        public static void Run()
        {
            //ExStart:CroppingByRectangle
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_JPEG();

            Console.WriteLine("Running example CroppingByRectangle");
            // Load an existing image into an instance of the RasterImage class.
            using (RasterImage rasterImage = (RasterImage)Image.Load(dataDir + "aspose-logo.jpg"))
            {
                if (!rasterImage.IsCached)
                {
                    rasterImage.CacheData();
                }

                // Create an instance of the Rectangle class with the desired size, perform the crop operation, and save the results to disk.
                Rectangle rectangle = new Rectangle(20, 20, 20, 20);
                rasterImage.Crop(rectangle);
                rasterImage.Save(dataDir + "CroppingByRectangle_out.jpg");
            }

            Console.WriteLine("Finished example CroppingByRectangle");
            //ExEnd:CroppingByRectangle
        }        
    }
}