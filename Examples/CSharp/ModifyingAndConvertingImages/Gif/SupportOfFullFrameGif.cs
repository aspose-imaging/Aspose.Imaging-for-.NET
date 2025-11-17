// GIST-ID: 1dfd00f0bdb5f61fd8a714c375e14723
//-----------------------------------------------------------------------------------------------------------
// <copyright file="SupportOfFullFrameGif.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="25.05.2020 11:32:56">
//     Copyright (c) 2001-2012 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Tiff.Enums;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.Gif
{
    class SupportOfFullFrameGif
    {
        public static void Run()
        {
            Console.WriteLine("Running example SupportOfFullFrameGif");
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();
            string fileName = "Animation.gif";
            string inputFilePath = Path.Combine(dataDir, fileName);
            string outputFilePath = inputFilePath + "_FullFrame.tif";
            string outputFilePath1 = inputFilePath + "_NonFullFrame.tif";
            using (Image image = Image.Load(inputFilePath))
            {
                image.Save(outputFilePath, new TiffOptions(TiffExpectedFormat.TiffDeflateRgb) { MultiPageOptions = new MultiPageOptions(new IntRange(2, 5)), FullFrame = true });
                image.Save(outputFilePath1, new TiffOptions(TiffExpectedFormat.TiffDeflateRgb) { MultiPageOptions = new MultiPageOptions(new IntRange(2, 5)) });
            }

            File.Delete(outputFilePath);
            File.Delete(outputFilePath1);

            Console.WriteLine("Finished example SupportOfFullFrameGif");
        }
    }
}