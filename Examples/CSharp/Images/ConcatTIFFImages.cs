using System.IO;

using Aspose.Imaging;
using Aspose.Imaging.FileFormats.Tiff;

namespace Aspose.Imaging.Examples.Images
{
    public class ConcatTIFFImages
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = Aspose.Imaging.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            //Create a copy of original image to avoid any alteration
            File.Copy(dataDir + "demo.tif", dataDir + "TestDemo.tif", true);

            //Create an instance of TiffImage and load the copied destination image
            using (TiffImage image = (TiffImage)Aspose.Imaging.Image.Load(dataDir + "TestDemo.tif"))
            {
                //Create an instance of TiffImage and load the source image
                using (TiffImage image1 = (TiffImage)Aspose.Imaging.Image.Load(dataDir + "sample.tif"))
                {
                    // Create an instance of TIffFrame and copy active frame of source image
                    TiffFrame frame = TiffFrame.CopyFrame(image1.ActiveFrame);
                    
                    // Add copied frame to destination image
                    image.AddFrame(frame);
                    
                    // save the image with changes.
                    image.Save();
                }
            }

            // Display Status.
            System.Console.WriteLine("Concatenation of TIF files done successfully.");
        }
    }
}