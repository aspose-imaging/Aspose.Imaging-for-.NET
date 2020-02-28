/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

using System;
namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.JPEG
{
    class CroppingByShifts
    {
        public static void Run()
        {
            //ExStart:CroppingByShifts
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_JPEG();

            Console.WriteLine("Running example CroppingByShifts");
            // Load an existing image into an instance of RasterImage class
            using (RasterImage rasterImage = (RasterImage)Image.Load(dataDir + "aspose-logo.jpg"))
            {
                // Before cropping, the image should be cached for better performance
                if (!rasterImage.IsCached)
                {
                    rasterImage.CacheData();
                }

                // Define shift values for all four sides
                int leftShift = 10;
                int rightShift = 10;
                int topShift = 10;
                int bottomShift = 10;

                // Based on the shift values, apply the cropping on image Crop method will shift the image bounds toward the center of image and Save the results to disk
                rasterImage.Crop(leftShift, rightShift, topShift, bottomShift);
                rasterImage.Save(dataDir + "CroppingByShifts_out.jpg");
            }

            Console.WriteLine("Running example CroppingByShifts");
            //ExEnd:CroppingByShifts
        }        
    }
}

