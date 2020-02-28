/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

using System;
namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.PNG
{
    class ChangeBackgroundColor
    {
        public static void Run()
        {
            Console.WriteLine("Running example ChangeBackgroundColor");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_PNG();
 
            // Create an instance of Image class and load a PNG image
            using (Image img = Image.Load(dataDir + "aspose_logo.png"))
            {
                // Create an instance of RasterImage and get the pixels array by calling method LoadArgb32Pixels.
                RasterImage rasterImg = img as RasterImage;
                if (rasterImg != null)
                {
                    int[] pixels = rasterImg.LoadArgb32Pixels(img.Bounds);
                    if (pixels != null)
                    {
                        // Iterate through the pixel array and Check the pixel information that if it is a transparent color pixel and Change the pixel color to white
                        for (int i = 0; i < pixels.Length; i++)
                        {
                            if (pixels[i] == rasterImg.TransparentColor.ToArgb())
                            {
                                pixels[i] = Color.White.ToArgb();
                            }
                        }
                        // Replace the pixel array into the image.
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