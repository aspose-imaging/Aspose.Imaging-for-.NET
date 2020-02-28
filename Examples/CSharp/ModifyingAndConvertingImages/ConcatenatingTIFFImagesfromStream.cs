using System.IO;
using Aspose.Imaging.FileFormats.Tiff;
using System;

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    public class ConcatenatingTIFFImagesfromStream
    {
        public static void Run()
        {
            Console.WriteLine("Running example ConcatenatingTIFFImagesfromStream");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Create instances of FileStream and initialize with Tiff images
            FileStream fileStream = new FileStream(dataDir + "TestDemo.tif", FileMode.Open);
            FileStream fileStream1 = new FileStream(dataDir + "sample.tif", FileMode.Open);

            // Create an instance of TiffImage and load the destination image from filestream
            using (TiffImage image = (TiffImage) Image.Load(fileStream))
            {
                // Create an instance of TiffImage and load the source image from filestream
                using (TiffImage image1 = (TiffImage) Image.Load(fileStream1))
                {
                    // Create an instance of TIffFrame and copy active frame of source image
                    TiffFrame frame = TiffFrame.CopyFrame(image1.ActiveFrame);

                    // Add copied frame to destination image
                    image.AddFrame(frame);
                }

                // Save the image with changes
                image.Save(dataDir + "ConcatenatingTIFFImagesfromStream_out.tif");

                // Close the FileStreams
                fileStream.Close();
                fileStream1.Close();
            }

            Console.WriteLine("Finished example ConcatenatingTIFFImagesfromStream");
        }
    }
}