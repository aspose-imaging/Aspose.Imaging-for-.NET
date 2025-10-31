//-----------------------------------------------------------------------------------------------------------
// <copyright file="OptimizationStrategyInDithering.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="11.09.2019 13:59:14">
//     Copyright (c) 2001-2012 Aspise Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.MemoryStrategies
{
    class OptimizationStrategyInDithering
    {
        public static void Run()
        {
            Console.WriteLine("Running example OptimizationStrategyInDithering");
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            string fileName = "SampleTiff1.tiff";
            string output = "SampleTiff1.out.tiff";
            string inputFileName = Path.Combine(dataDir, fileName);

            Console.WriteLine("Memory optimization in dithering started.");

            // Setting a memory limit of 50 megabytes for the target loaded image
            using (RasterImage image = (RasterImage)Image.Load(inputFileName, new LoadOptions() { BufferSizeHint = 50 }))
            {
                // Perform a dithering operation
                image.Dither(DitheringMethod.FloydSteinbergDithering, 1);

                image.Save(Path.Combine(dataDir, output));
            }

            Console.WriteLine("Finished example OptimizationStrategyInDithering");
        }
    }
}