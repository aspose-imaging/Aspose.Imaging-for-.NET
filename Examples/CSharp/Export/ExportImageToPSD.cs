using System.IO;

using Aspose.Imaging;

namespace Aspose.Imaging.Examples.Export
{
    public class ExportImageToPSD
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Aspose.Imaging.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            //Load an existing image
            using (Aspose.Imaging.Image image = Aspose.Imaging.Image.Load(dataDir + "sample.bmp"))
            {
                //Create an instance of PsdOptions and set it’s various properties
                Aspose.Imaging.ImageOptions.PsdOptions psdOptions = new Aspose.Imaging.ImageOptions.PsdOptions();
                psdOptions.ColorMode = Aspose.Imaging.FileFormats.Psd.ColorModes.Rgb;
                psdOptions.CompressionMethod = Aspose.Imaging.FileFormats.Psd.CompressionMethod.Raw;
                psdOptions.Version = 4;

                //Save image to disk in PSD format
                image.Save(dataDir + "output.psd", psdOptions);

                // Display Status.
                System.Console.WriteLine("Export to PSD performed successfully.");
            }
        }
    }
}