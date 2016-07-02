using System.IO;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.FileFormats.Tiff;
using Aspose.Imaging.FileFormats.Tiff.Enums;
using Aspose.Imaging.Sources;
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
    public class AddFramesToTIFFImage
    {
        public static void Run()
        {
            // To get proper output please apply a valid Aspose.Imaging License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");

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
                            frame = new TiffFrame(new TiffOptions(outputSettings) /*ensure options are cloned for each frame*/,
                                newWidth, newHeight);
                            // If there is a TIFF image loaded you need to enumerate the frames and perform the following
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
        }
    }
}