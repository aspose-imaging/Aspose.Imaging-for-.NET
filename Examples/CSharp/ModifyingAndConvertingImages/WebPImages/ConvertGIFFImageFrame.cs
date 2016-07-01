using Aspose.Imaging.FileFormats.Gif;
using Aspose.Imaging.FileFormats.Gif.Blocks;
using Aspose.Imaging.FileFormats.Webp;
using Aspose.Imaging;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.WebPImages
{
    class ConvertGIFFImageFrame
    {
        public static void Run()
        {
            // ExStart:ConvertGIFFImageFrame
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_WebPImages();

            // Load GIFF image into the instance of image class.
            using (Image image = Image.Load(dataDir + "asposelogo.gif"))
            {
                // Create an instance of GIFF image class.
                GifImage gif = image as GifImage;

                if (gif == null) return;

                // Load an existing WebP image into the instance of WebPImage class.
                using (WebPImage webp = new WebPImage(image.Width, image.Height, null))
                {
                    // Loop through the GIFF frames
                    for (int i = 0; i < gif.Blocks.Length; i++)
                    {
                        // Convert GIFF block to GIFF Frame
                        GifFrameBlock gifBlock = gif.Blocks[i] as GifFrameBlock;
                        if (gifBlock == null)
                        {
                            continue;
                        }

                        // Create an instance of WebP Frame instance by passing GIFF frame to class constructor.
                        WebPFrameBlock block = new WebPFrameBlock(gifBlock)
                        {
                            Top = (short)gifBlock.Top,
                            Left = (short)gifBlock.Left,
                            Duration = (short)gifBlock.ControlBlock.DelayTime
                        };

                        // Add WebP frame to WebP image block list
                        webp.AddBlock(block);
                    }

                    // Set Properties of WebP image.
                    webp.Options.AnimBackgroundColor = 0xff; // Black
                    webp.Options.AnimLoopCount = 0; // Infinity
                    webp.Options.Quality = 50;
                    webp.Options.Lossless = false;

                    // Save WebP image.
                    webp.Save(dataDir + "ConvertGIFFImageFrame_out.webp");
                }
            }
            // ExEnd:ConvertGIFFImageFrame
        }
    }
}