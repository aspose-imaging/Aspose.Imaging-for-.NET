// GIST-ID: 9a457e803b3ae070644aa1fb1a33214b
using System;
using System.IO;
using Aspose.Imaging.FileFormats.Tiff;
using Aspose.Imaging.FileFormats.Tiff.Enums;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Sources;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference 
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it, and then add its reference to this project. For any issues, questions, or suggestions 
please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    public class AddFramesToTIFFImage
    {
        public static void Run()
        {
            Console.WriteLine("Running example AddFramesToTIFFImage");
            // To get proper output, please apply a valid Aspose.Imaging license. You can purchase a full license 
            // or get a 30‑day temporary license from https://releases.aspose.com/.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();
            TiffOptions outputSettings = new TiffOptions(TiffExpectedFormat.Default);
            outputSettings.BitsPerSample = new ushort[] { 1 };
            outputSettings.Compression = TiffCompressions.CcittFax3;
            outputSettings.Photometric = TiffPhotometrics.MinIsWhite;
            outputSettings.Source = new StreamSource(new MemoryStream());
            int newWidth = 500;
            int newHeight = 500;
            string path = dataDir + "AddFramesToTIFFImage_out.tif";
            using (TiffImage tiffImage = (TiffImage)Image.Create(outputSettings, newWidth, newHeight))
            {
                int index = 0;
                foreach (var file in Directory.GetFiles(dataDir, "*.jpg"))
                {
                    using (RasterImage ri = (RasterImage)Image.Load(file))
                    {
                        ri.Resize(newWidth, newHeight, ResizeType.NearestNeighbourResample);
                        TiffFrame frame = tiffImage.ActiveFrame;
                        if (index > 0)
                        {
                            frame = new TiffFrame(new TiffOptions(outputSettings) /* ensure options are cloned for each frame */,
                                newWidth, newHeight);
                            // If there is a TIFF image loaded, you need to enumerate the frames and perform the following:
                            // frame = TiffFrame.CreateFrameFrom(sourceFrame, outputSettings);
                        }

                        frame.SavePixels(frame.Bounds, ri.LoadPixels(ri.Bounds));
                        if (index > 0)
                        {
                            tiffImage.AddFrame(frame);
                        }
                        index++;
                    }
                }
                tiffImage.Save(path);
            }

            Console.WriteLine("Finished example AddFramesToTIFFImage");
        }
    }
}