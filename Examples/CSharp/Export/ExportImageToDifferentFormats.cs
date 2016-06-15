using System.IO;

using Aspose.Imaging;

namespace Aspose.Imaging.Examples.CSharp.Export
{
    public class ExportImageToDifferentFormats
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Export("ExportImageToDifferentFormats");

            //Load an existing image (of type Gif) in an instance of the Image class
            using (Aspose.Imaging.Image image = Aspose.Imaging.Image.Load(dataDir + "sample.gif"))
            {
                //Export to BMP file format using the default options
                image.Save(dataDir + "output.bmp", new Aspose.Imaging.ImageOptions.BmpOptions());

                //Export to JPEG file format using the default options
                image.Save(dataDir + "output.jpeg", new Aspose.Imaging.ImageOptions.JpegOptions());

                //Export to PNG file format using the default options
                image.Save(dataDir + "output.png", new Aspose.Imaging.ImageOptions.PngOptions());

                //Export to TIFF file format using the default options
                image.Save(dataDir + "output.tiff", new Aspose.Imaging.ImageOptions.TiffOptions(Aspose.Imaging.FileFormats.Tiff.Enums.TiffExpectedFormat.Default));
            }

            // Display Status.
            System.Console.WriteLine("Conversion performed successfully.");
        }
    }
}
