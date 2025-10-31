/*
This project uses the automatic package‑restore feature of NuGet to resolve the Aspose.Imaging for .NET API
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information.
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/,
install it, and then add its reference to this project. For any issues, questions, or suggestions,
please feel free to contact us using https://forum.aspose.com/
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
            // Load an existing image into an instance of the RasterImage class.
            using (RasterImage rasterImage = (RasterImage)Image.Load(dataDir + "aspose-logo.jpg"))
            {
                // Before cropping, cache the image for better performance.
                if (!rasterImage.IsCached)
                {
                    rasterImage.CacheData();
                }

                // Define shift values for all four sides.
                int leftShift = 10;
                int rightShift = 10;
                int topShift = 10;
                int bottomShift = 10;

                // Apply cropping based on the shift values. The Crop method shifts the image bounds toward
                // the center of the image, and the result is saved to disk.
                rasterImage.Crop(leftShift, rightShift, topShift, bottomShift);
                rasterImage.Save(dataDir + "CroppingByShifts_out.jpg");
            }

            Console.WriteLine("Running example CroppingByShifts");
            //ExEnd:CroppingByShifts
        }        
    }
}