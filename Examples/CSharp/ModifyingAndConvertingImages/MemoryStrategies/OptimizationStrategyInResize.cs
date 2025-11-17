// GIST-ID: b510f0e0afd1566997cf3ae2bfcb087e
//-----------------------------------------------------------------------------------------------------------
// <copyright file="OptimizationStrategyInResize.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="11.09.2019 14:09:47">
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
    class OptimizationStrategyInResize
    {
        public static void Run()
        {
            Console.WriteLine("Running example OptimizationStrategyInResize");
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            string fileName = "SampleTiff1.tiff";
            string output = "SampleTiff1.out.tiff";
            string inputFileName = Path.Combine(dataDir, fileName);

            // Set a memory limit of 50 MB for the loaded image.
            using (var image = Image.Load(inputFileName, new LoadOptions() { BufferSizeHint = 50 }))
            {
                // Perform resize operation.
                image.Resize(300, 200, ResizeType.LanczosResample);
                image.Save(Path.Combine(dataDir, output));
            }

            Console.WriteLine("Finished example OptimizationStrategyInResize");
        }
    }
}