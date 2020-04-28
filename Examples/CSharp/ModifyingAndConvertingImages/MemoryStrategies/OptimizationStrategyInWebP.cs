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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.MemoryStrategies
{
    class OptimizationStrategyInWebP
    {
        public static void Run()
        {

        string dataDir = RunExamples.GetDataDir_WebPImages();

        Console.WriteLine("Running example OptimizationStrategyInWebP");

        var imageOptions = new WebPOptions();

        imageOptions.Source = new FileCreateSource("created.webp", false);

        imageOptions.BufferSizeHint = 50; 
        
        using (Image image = Image.Create(imageOptions, 1000, 1000))
        {
            // Do something with the created image
            image.Save();
        }

        Console.WriteLine("Finished example OptimizationStrategyInWebP");
    }
}
}
