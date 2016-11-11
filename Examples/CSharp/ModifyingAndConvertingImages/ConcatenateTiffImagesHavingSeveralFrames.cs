using System;
using System.Collections.Generic;
using Aspose.Imaging.FileFormats.Tiff;
using Aspose.Imaging.FileFormats.Tiff.Enums;
using Aspose.Imaging.ImageOptions;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    public class ConcatenateTiffImagesHavingSeveralFrames
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            List<string> files = new List<string>(new[] { dataDir + "TestDemo.tiff", dataDir + "sample.tiff" });
            TiffOptions createOptions = new TiffOptions(TiffExpectedFormat.Default);
            createOptions.BitsPerSample = new ushort[] { 1 };
            createOptions.Orientation = TiffOrientations.TopLeft;
            createOptions.Photometric = TiffPhotometrics.MinIsBlack;
            createOptions.Compression = TiffCompressions.CcittFax3;
            createOptions.FillOrder = TiffFillOrders.Lsb2Msb;

            // Create a new image by passing the TiffOptions and size of first frame, we will remove the first frame at the end, cause it will be empty
            TiffImage output = null;
            try
            {
                List<TiffImage> images = new List<TiffImage>();
                try
                {
                    foreach (var file in files)
                    {
                        // Create an instance of TiffImage and load the source image
                        TiffImage input = (TiffImage)Image.Load(file);
                        images.Add(input); // Do not dispose before data is fetched. Data is fetched on 'Save' later.
                        foreach (var frame in input.Frames)
                        {
                            if (output == null)
                            {
                                // Create a new tiff image with first frame defined.
                                output = new TiffImage(TiffFrame.CopyFrame(frame));
                            }
                            else
                            {
                                // Add copied frame to destination image
                                output.AddFrame(TiffFrame.CopyFrame(frame));
                            }
                        }
                    }

                    if (output != null)
                    {
                        // Save the result
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
            }
            catch (Exception ex)
            {

            }
        }
    }
}