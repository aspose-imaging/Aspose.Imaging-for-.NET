using Aspose.Imaging;
using Aspose.Imaging.ImageOptions;
using System;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API 
reference when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq 
for more information. If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET 
from https://releases.aspose.com/, install it, and then add its reference to this project. For any issues, 
questions, or suggestions, please feel free to contact us via https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    public class AddSignatureToImage
    {
        public static void Run()
        {
            Console.WriteLine("Running example AddSignatureToImage");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Create an instance of Image and load the primary image.
            using (Image canvas = Image.Load(dataDir + "SampleTiff1.tiff"))
            {
                // Create another instance of Image and load the secondary image containing the signature graphics.
                using (Image signature = Image.Load(dataDir + "signature.gif"))
                {
                    // Create an instance of the Graphics class and initialize it with the primary image.
                    Graphics graphics = new Graphics(canvas);

                    // Draw the secondary image at the bottom‑right corner of the primary image.
                    graphics.DrawImage(signature, new Point(canvas.Height - signature.Height, canvas.Width - signature.Width));
                    canvas.Save(dataDir + "AddSignatureToImage_out.png", new PngOptions());
                }
            }

            Console.WriteLine("Finished example AddSignatureToImage");
        }
    }
}