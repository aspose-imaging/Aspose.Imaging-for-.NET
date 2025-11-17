// GIST-ID: d1eb1a6f4afa0389f0a92f024a2cee09
//-----------------------------------------------------------------------------------------------------------
// <copyright file="OptimizationStrategyInJPEG2000.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="18.12.2019 16:05:55">
//     Copyright (c) 2001-2012 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Jpeg;
using Aspose.Imaging.FileFormats.Jpeg2000;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Sources;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.MemoryStrategies
{
    class OptimizationStrategyInJPEG2000
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            Console.WriteLine("Running example OptimizationStrategyInJPEG2000");

            // Set a memory limit of 100 megabytes for the loaded image (JP2 codec).
            using (Image image = Image.Load(Path.Combine(dataDir, "inputFile.jp2"), new LoadOptions() { BufferSizeHint = 100 }))
            {
                image.Save(Path.Combine(dataDir, "outputFile.jp2"));
            }

            // Set a memory limit of 100 megabytes for the created image (JP2 codec).
            ImageOptionsBase createOptions = new Jpeg2000Options { Codec = Jpeg2000Codec.Jp2 };
            createOptions.BufferSizeHint = 100;
            createOptions.Source = new FileCreateSource(Path.Combine(dataDir, "createdFile.jp2"), false);
            using (var image = Image.Create(createOptions, 1000, 1000))
            {
                image.Save(); // Save to the same location.
            }

            Console.WriteLine("Finished example OptimizationStrategyInJPEG2000");
        }
    }
}