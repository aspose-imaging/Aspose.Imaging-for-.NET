using Aspose.Imaging.FileFormats.Bmp;
using Aspose.Imaging.FileFormats.Tiff;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Sources;
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
    class ExtractTIFFFramesToBMPImageFormat
    {
        public static void Run()
        {
            Console.WriteLine("Running example ExtractTIFFFramesToBMPImageFormat");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            using (TiffImage multiImage = (TiffImage)Image.Load(dataDir + "SampleTiff1.tiff"))
            {
                // Create an integer variable to keep track of frames in the TiffImage.
                int frameCounter = 0;

                // Iterate over the TiffFrames in the TiffImage.
                foreach (TiffFrame tiffFrame in multiImage.Frames)
                {
                    multiImage.ActiveFrame = tiffFrame;

                    // Load pixels of the TiffFrame into an array of colors.
                    Color[] pixels = multiImage.LoadPixels(tiffFrame.Bounds);

                    // Create a BmpOptions object.
                    BmpOptions bmpCreateOptions = new BmpOptions();
                    bmpCreateOptions.BitsPerPixel = 24;

                    // Set the source of the BmpOptions to a FileCreateSource that specifies where the output will be saved.
                    bmpCreateOptions.Source = new FileCreateSource(string.Format("{0}\\ConcatExtractTIFFFramesToBMP_out{1}.bmp", dataDir, frameCounter), false);
                    
                    // Create a new BmpImage.
                    using (BmpImage bmpImage = (BmpImage)Image.Create(bmpCreateOptions, tiffFrame.Width, tiffFrame.Height))
                    {
                        // Save the BmpImage with pixels from the TiffFrame.
                        bmpImage.SavePixels(tiffFrame.Bounds, pixels);
                        bmpImage.Save();
                    }
                    frameCounter++;
                }
            }

            Console.WriteLine("Finished example ExtractTIFFFramesToBMPImageFormat");
        }
    }
}