//-----------------------------------------------------------------------------------------------------------
// <copyright file="OptimizationStrategyInDJVU.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="18.12.2019 16:13:57">
//     Copyright (c) 2001-2012 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Djvu;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.MemoryStrategies
{
    class OptimizationStrategyInDJVU
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            Console.WriteLine("Running example OptimizationStrategyInDJVU");

            using (DjvuImage image = (DjvuImage)Image.Load(Path.Combine(dataDir, "test.djvu"), new LoadOptions { BufferSizeHint = 50 }))
            {
                int pageNumber = 2;
                for (int pageNum = 0; pageNum < pageNumber; pageNum++)
                {
                    image.Pages[pageNum].Save(Path.Combine(dataDir, "page" + pageNum + ".png"), new PngOptions());
                }
            }

            Console.WriteLine("Finished example OptimizationStrategyInDJVU");
        }
    }
}