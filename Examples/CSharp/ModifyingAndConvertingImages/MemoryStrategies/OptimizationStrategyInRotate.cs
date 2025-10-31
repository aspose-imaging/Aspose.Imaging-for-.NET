//-----------------------------------------------------------------------------------------------------------
// <copyright file="OptimizationStrategyInRotate.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="31.07.2019 13:03:38">
//     Copyright (c) 2001-2012 Aspose Pty Ltd. All rights reserved.
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
    class OptimizationStrategyInRotate
    {
        public static void Run()
        {
            Console.WriteLine("Running example OptimizationStrategyInRotate");
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            string fileName = "SampleTiff1.tiff";
            string inputFileName = Path.Combine(dataDir, fileName);
            Console.WriteLine("Memory optimization during rotation started.");
            using (var image = Image.Load(inputFileName, new LoadOptions() { BufferSizeHint = 50 }))
            {
                // Perform RotateFlip operation.
                image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                // Perform Rotate operation.
                ((RasterImage)image).Rotate(60); // Rotate 60 degrees clockwise.
            }

            Console.WriteLine("Finished example OptimizationStrategyInRotate");
        }   
    }
}