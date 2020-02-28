//-----------------------------------------------------------------------------------------------------------
// <copyright file="OptimizationStrategyInFilters.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="11.09.2019 13:51:13">
//     Copyright (c) 2001-2012 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.ImageFilters.FilterOptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.MemoryStrategies
{
    class OptimizationStrategyInFilters
    {
        public static void Run()
        {
            Console.WriteLine("Running example OptimizationStrategyInFilters");
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            string fileName = "SampleTiff1.tiff";
            string output = "SampleTiff1.out.tiff";
            string inputFileName = Path.Combine(dataDir, fileName);
            Console.WriteLine("Memory optimization in Filters started..");
            using (RasterImage rasterImage = (RasterImage)Image.Load(
                inputFileName,
                new LoadOptions { BufferSizeHint = 50 }))
            {
                FilterOptionsBase filterOptions = new MedianFilterOptions(6 /*size*/);
                rasterImage.Filter(rasterImage.Bounds, filterOptions);
                rasterImage.Save(Path.Combine(dataDir, output));
            }

            Console.WriteLine("Finished example OptimizationStrategyInFilters");
        }
    }
}
