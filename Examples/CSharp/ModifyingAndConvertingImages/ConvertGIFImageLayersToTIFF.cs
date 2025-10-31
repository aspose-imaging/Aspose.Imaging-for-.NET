using Aspose.Imaging.FileFormats.Gif;
using Aspose.Imaging.FileFormats.Gif.Blocks;
using Aspose.Imaging.FileFormats.Tiff.Enums;
using Aspose.Imaging.ImageOptions;
using System;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API references 
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it, and then add its reference to this project. For any issues, questions, or suggestions, 
please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    class ConvertGIFImageLayersToTIFF
    {
        public static void Run()
        {
            Console.WriteLine("Running example ConvertGIFImageLayersToTIFF");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Load a GIF image.
            Image objImage = Image.Load(dataDir + "asposelogo.gif");
            using (GifImage gif = (GifImage)objImage)
            {
                // Iterate through the array of blocks in the GIF image.
                for (int i = 0; i < gif.Blocks.Length; i++)
                {
                    // Convert block to GifFrameBlock class instance.
                    GifFrameBlock gifBlock = gif.Blocks[i] as GifFrameBlock;

                    // If the block is not a GIF frame, ignore it.
                    if (gifBlock == null)
                    {
                        continue;
                    }

                    // Create an instance of the TiffOptions class and save the GIF frame as a TIFF image.
                    TiffOptions objTiff = new TiffOptions(TiffExpectedFormat.Default);
                    gifBlock.Save(dataDir + "asposelogo" + i + "_out.tif", objTiff);
                }
            }

            Console.WriteLine("Finished example ConvertGIFImageLayersToTIFF");
        }
    }
}