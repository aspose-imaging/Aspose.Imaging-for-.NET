using System;
using System.IO;
using Aspose.Imaging;
using Aspose.Imaging.FileFormats.Tiff;

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    public class ConcatenatingTIFFImagesfromStream
    {
        public static void Run()
        {
            Console.WriteLine("Running example ConcatenatingTIFFImagesfromStream");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Create FileStream instances and initialize them with TIFF images.
            FileStream fileStream = new FileStream(dataDir + "TestDemo.tif", FileMode.Open);
            FileStream fileStream1 = new FileStream(dataDir + "sample1.tif", FileMode.Open);

            // Load the destination image from the first filestream.
            using (TiffImage image = (TiffImage)Image.Load(fileStream))
            {
                // Load the source image from the second filestream.
                using (TiffImage image1 = (TiffImage)Image.Load(fileStream1))
                {
                    // Create a TiffFrame and copy the active frame of the source image.
                    TiffFrame frame = TiffFrame.CopyFrame(image1.ActiveFrame);

                    // Add the copied frame to the destination image.
                    image.AddFrame(frame);
                }

                // Save the image with the added frame.
                image.Save(dataDir + "ConcatenatingTIFFImagesfromStream_out.tif");

                // Close the FileStreams.
                fileStream.Close();
                fileStream1.Close();
            }

            Console.WriteLine("Finished example ConcatenatingTIFFImagesfromStream");
        }
    }
}