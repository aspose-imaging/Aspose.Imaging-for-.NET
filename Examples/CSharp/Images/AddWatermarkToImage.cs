using System.IO;

using Aspose.Imaging;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.FileFormats.Tiff;
using Aspose.Imaging.FileFormats.Tiff.Enums;
using Aspose.Imaging.Sources;

namespace Aspose.Imaging.Examples.Images
{
    public class AddFramesToTIFFImage
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = Aspose.Imaging.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            TiffOptions outputSettings = new TiffOptions(TiffExpectedFormat.Default);
            outputSettings.BitsPerSample = new ushort[] { 1 };
            outputSettings.Compression = TiffCompressions.CcittFax3;
            outputSettings.Photometric = TiffPhotometrics.MinIsWhite;
            outputSettings.Source = new StreamSource(new MemoryStream());
            int newWidth = 500;
            int newHeight = 500;
            string path = dataDir + "output.tif";
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