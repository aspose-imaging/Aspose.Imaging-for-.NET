﻿using Aspose.Imaging.FileFormats.Tiff;
using Aspose.Imaging.ImageOptions;
using System;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    class SavingEachFrameInOtherRasterImageFormat
    {
        public static void Run()
        {
            Console.WriteLine("Running example SavingEachFrameInOtherRasterImageFormat");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Create an instance of TiffImage and load the file from disc
            using (var multiImage = (TiffImage)Image.Load(dataDir + "SampleTiff1.tiff"))
            {
                // Initialize a variable to keep track of the frames in the image
                int i = 0;

                // Iterate over the tiff frame collection and Save the frame directly on disc in PNG format
                foreach (var tiffFrame in multiImage.Frames)
                {
                    tiffFrame.Save(dataDir + i + "_out.png", new PngOptions());
                }
            }

            Console.WriteLine("Finished example SavingEachFrameInOtherRasterImageFormat");
        }
    }
}