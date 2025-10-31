//-----------------------------------------------------------------------------------------------------------
// <copyright file="OptimizationStrategyInWebP.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="29.04.2020 2:25:51">
//     Copyright (c) 2001-2012 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Sources;
using System;

namespace CSharp.ModifyingAndConvertingImages.MemoryStrategies
{
    class OptimizationStrategyInWebP
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_WebPImages();

            Console.WriteLine("Running the OptimizationStrategyInWebP example");

            var imageOptions = new WebPOptions
            {
                Source = new FileCreateSource("created.webp", false),
                BufferSizeHint = 50
            };

            using (Image image = Image.Create(imageOptions, 1000, 1000))
            {
                // Do something with the created image
                image.Save();
            }

            Console.WriteLine("Finished the OptimizationStrategyInWebP example");
        }
    }
}