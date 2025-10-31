using Aspose.Imaging.FileFormats.Gif;
using Aspose.Imaging.FileFormats.Gif.Blocks;
using Aspose.Imaging.FileFormats.Webp;
using System;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API references 
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it, and then add its reference to this project. For any issues, questions, or suggestions, 
please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.WebPImages
{
    class ConvertGIFFImageFrame
    {
        public static void Run()
        {
            Console.WriteLine("Running example ConvertGIFFImageFrame");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_WebPImages();

            // Load the GIF image into an Image instance.
            using (Image image = Image.Load(dataDir + "asposelogo.gif"))
            {
                // Create an instance of the GIF image class.
                GifImage gif = image as GifImage;

                if (gif == null) return;

                // Create a new WebP image with the same dimensions.
                using (WebPImage webp = new WebPImage(image.Width, image.Height, null))
                {
                    // Loop through the GIF frames.
                    for (int i = 0; i < gif.Blocks.Length; i++)
                    {
                        // Convert GIF block to a GIF frame.
                        GifFrameBlock gifBlock = gif.Blocks[i] as GifFrameBlock;
                        if (gifBlock == null)
                        {
                            continue;
                        }

                        // Create a WebP frame by passing the GIF frame to the constructor.
                        WebPFrameBlock block = new WebPFrameBlock(gifBlock)
                        {
                            Top = (short)gifBlock.Top,
                            Left = (short)gifBlock.Left,
                            Duration = (short)gifBlock.ControlBlock.DelayTime
                        };

                        // Add the WebP frame to the WebP image block list.
                        webp.AddBlock(block);
                    }

                    // Set properties of the WebP image.
                    webp.Options.AnimBackgroundColor = 0xff; // Black
                    webp.Options.AnimLoopCount = 0; // Infinity
                    webp.Options.Quality = 50;
                    webp.Options.Lossless = false;

                    // Save the WebP image.
                    webp.Save(dataDir + "ConvertGIFFImageFrame_out.webp");
                }
            }

            Console.WriteLine("Finished example ConvertGIFFImageFrame");
        }
    }
}