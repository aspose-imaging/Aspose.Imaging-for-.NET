using Aspose.Imaging.FileFormats.Gif;
using Aspose.Imaging.FileFormats.Gif.Blocks;
using Aspose.Imaging.FileFormats.Tiff.Enums;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    class ConvertGIFImageLayersToTIFF
    {
        public static void Run()
        {
            // To get proper output please apply a valid Aspose.Imaging License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");

            // ExStart:ConvertGIFImageLayersToTIFF
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Load a GIF image
            Image objImage = Image.Load(dataDir + "asposelogo.gif");

            // Convert the image to GIF image
            using (GifImage gif = (GifImage)objImage)
            {
                // iterate through arry of blocks in the GIF image
                for (int i = 0; i < gif.Blocks.Length; i++)
                {
                    // convert block to GifFrameBlock class instance
                    GifFrameBlock gifBlock = gif.Blocks[i] as GifFrameBlock;

                    // Check if gif block is then ignore it
                    if (gifBlock == null)
                    {
                        continue;
                    }

                    // Create an instance of TIFF Option class
                    TiffOptions objTiff = new TiffOptions(TiffExpectedFormat.Default);

                    // Save the GIFF block as TIFF image
                    gifBlock.Save(dataDir + "asposelogo"  + i + "_out.tif", objTiff);

                }
            }
            // ExEnd:ConvertGIFImageLayersToTIFF
        }
    }
}