using Aspose.Imaging.FileFormats.Bmp;
using Aspose.Imaging.FileFormats.Tiff;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Sources;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    class ExtractTIFFFramesToBMPImageFormat
    {
        public static void Run()
        {
            //ExStart:ExtractTIFFFramesToBMPImageFormat
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            using (TiffImage multiImage = (TiffImage)Image.Load(dataDir + "SampleTiff1.tiff"))
            {
                // Create an instance of int to keep track of frames in TiffImage
                int frameCounter = 0;

                // Iterate over the TiffFrames in TiffImage
                foreach (TiffFrame tiffFrame in multiImage.Frames)
                {
                    multiImage.ActiveFrame = tiffFrame;

                    // Load Pixels of TiffFrame into an array of Colors
                    Color[] pixels = multiImage.LoadPixels(tiffFrame.Bounds);

                    // Create an instance of bmpCreateOptions
                    BmpOptions bmpCreateOptions = new BmpOptions();
                    bmpCreateOptions.BitsPerPixel = 24;

                    // Set the Source of bmpCreateOptions as FileCreateSource by specifying the location where output will be saved
                    bmpCreateOptions.Source = new FileCreateSource(string.Format("{0}\\ConcatExtractTIFFFramesToBMP_out{1}.bmp", dataDir, frameCounter), false);
                    
                    // Create a new bmpImage
                    using (BmpImage bmpImage = (BmpImage)Image.Create(bmpCreateOptions, tiffFrame.Width, tiffFrame.Height))
                    {
                        // Save the bmpImage with pixels from TiffFrame
                        bmpImage.SavePixels(tiffFrame.Bounds, pixels);
                        bmpImage.Save();
                    }
                    frameCounter++;
                }
            }
            //ExEnd:ExtractTIFFFramesToBMPImageFormat
        }
    }
}