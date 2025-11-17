// GIST-ID: 9267552fd27cf53d363c87198d678559
//-----------------------------------------------------------------------------------------------------------
// <copyright file="OptimizationStrategyInTiff.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="28.02.2020 15:07:58">
//     Copyright (c) 2001-2012 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Tiff.Enums;
using Aspose.Imaging.ImageOptions;
using System;
using System.IO;

namespace CSharp.ModifyingAndConvertingImages.MemoryStrategies
{
    class OptimizationStrategyInTiff
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            Console.WriteLine("Running the example OptimizationStrategyInTiff");

            using (Image image = Image.Load(Path.Combine(dataDir, "sample.tif"), new LoadOptions { BufferSizeHint = 10 }))
            {
                image.Save(Path.Combine(dataDir, "optimizationStrategy_tiff_out.tiff"), new TiffOptions(TiffExpectedFormat.Default));
            }

            Console.WriteLine("Finished the example OptimizationStrategyInTiff");
        }
    }
}