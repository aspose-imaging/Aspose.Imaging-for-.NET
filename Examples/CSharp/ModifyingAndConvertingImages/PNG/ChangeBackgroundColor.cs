// GIST-ID: c4c118bcc3fdcba56d26e07d0a857fb6
/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference 
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download the Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it, and then add its reference to this project. For any issues, questions, or suggestions, 
please feel free to contact us using https://forum.aspose.com/
*/

using System;
using Aspose.Imaging;

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.PNG
{
    class ChangeBackgroundColor
    {
        public static void Run()
        {
            Console.WriteLine("Running example ChangeBackgroundColor");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_PNG();

            // Create an instance of the Image class and load a PNG image.
            using (Image img = Image.Load(dataDir + "aspose_logo.png"))
            {
                // Create an instance of RasterImage and get the pixel array by calling LoadArgb32Pixels.
                RasterImage rasterImg = img as RasterImage;
                if (rasterImg != null)
                {
                    int[] pixels = rasterImg.LoadArgb32Pixels(img.Bounds);
                    if (pixels != null)
                    {
                        // Iterate through the pixel array, check if a pixel matches the transparent color, and change it to white.
                        for (int i = 0; i < pixels.Length; i++)
                        {
                            if (pixels[i] == rasterImg.TransparentColor.ToArgb())
                            {
                                pixels[i] = Color.White.ToArgb();
                            }
                        }
                        // Replace the pixel array in the image.
                        rasterImg.SaveArgb32Pixels(img.Bounds, pixels);
                    }
                }

                // Save the updated image to disk.
                if (rasterImg != null)
                    rasterImg.Save(dataDir + "ChangeBackgroundColor_out.jpg");
            }

            Console.WriteLine("Finished example ChangeBackgroundColor");
        }
    }
}