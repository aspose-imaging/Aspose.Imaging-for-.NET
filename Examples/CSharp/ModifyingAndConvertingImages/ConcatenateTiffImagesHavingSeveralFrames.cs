// GIST-ID: 18f596fba6d942e8d5bf62bd47f6b7e1
using System;
using System.Collections.Generic;
using Aspose.Imaging.FileFormats.Tiff;
using Aspose.Imaging.FileFormats.Tiff.Enums;
using Aspose.Imaging.ImageOptions;

/*
This project uses the automatic package restore feature of NuGet to resolve Aspose.Imaging for .NET API references 
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/, 
install it, and then add its reference to this project. For any issues, questions, or suggestions, 
please feel free to contact us using https://forum.aspose.com/
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    public class ConcatenateTiffImagesHavingSeveralFrames
    {
        public static void Run()
        {
            Console.WriteLine("Running example ConcatenateTiffImagesHavingSeveralFrames");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            List<string> files = new List<string>(new[] { dataDir + "TestDemo.tiff", dataDir + "sample.tiff" });
            TiffOptions createOptions = new TiffOptions(TiffExpectedFormat.Default);
            createOptions.BitsPerSample = new ushort[] { 1 };
            createOptions.Orientation = TiffOrientations.TopLeft;
            createOptions.Photometric = TiffPhotometrics.MinIsBlack;
            createOptions.Compression = TiffCompressions.CcittFax3;
            createOptions.FillOrder = TiffFillOrders.Lsb2Msb;

            // Create a new image by passing the TiffOptions and the size of the first frame; 
            // we will remove the first frame at the end because it will be empty.
            TiffImage output = null;
            try
            {
                List<TiffImage> images = new List<TiffImage>();
                try
                {
                    foreach (var file in files)
                    {
                        // Create an instance of TiffImage and load the source image.
                        TiffImage input = (TiffImage)Image.Load(file);
                        images.Add(input); // Do not dispose before data is fetched. Data is fetched on 'Save' later.
                        foreach (var frame in input.Frames)
                        {
                            if (output == null)
                            {
                                // Create a new TIFF image with the first frame defined.
                                output = new TiffImage(TiffFrame.CopyFrame(frame));
                            }
                            else
                            {
                                // Add the copied frame to the destination image.
                                output.AddFrame(TiffFrame.CopyFrame(frame));
                            }
                        }
                    }

                    if (output != null)
                    {
                        // Save the result.
                        output.Save(dataDir + "ConcatenateTiffImagesHavingSeveralFrames_out.tif", createOptions);
                    }
                }
                finally
                {
                    foreach (TiffImage image in images)
                    {
                        image.Dispose();
                    }
                }

                Console.WriteLine("Finished example ConcatenateTiffImagesHavingSeveralFrames");
            }
            catch (Exception ex)
            {
                // Exception handling can be implemented as needed.
            }
        }
    }
}