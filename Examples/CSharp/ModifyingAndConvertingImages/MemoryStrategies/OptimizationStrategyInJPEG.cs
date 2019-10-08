//-----------------------------------------------------------------------------------------------------------
// <copyright file="OptimizationStrategyInJPEG.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="08.10.2019 11:16:55">
//     Copyright (c) 2001-2012 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Jpeg;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.MemoryStrategies
{
    class OptimizationStrategyInJPEG
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            string fileName = "aspose-logo.jpg";
            string output = "aspose-logo.out.jpg";
            string inputFileName = Path.Combine(dataDir, fileName);


            using (Image image = Image.Load(inputFileName, new LoadOptions() { BufferSizeHint = 50 }))
            {
                image.Save(Path.Combine(dataDir, "outputFile_Baseline.jpg"), new JpegOptions { CompressionType = JpegCompressionMode.Baseline, Quality = 100 });
                image.Save(Path.Combine(dataDir, "outputFile_Progressive.jpg"), new JpegOptions { CompressionType = JpegCompressionMode.Progressive });
                image.Save(Path.Combine(dataDir, "outputFile_Lossless.jpg") , new JpegOptions
                {
                    ColorType = JpegCompressionColorMode.YCbCr,
                    CompressionType = JpegCompressionMode.Lossless,
                    BitsPerChannel = 4
                });
                image.Save(Path.Combine(dataDir, "outputFile_JpegLs.jpg"), new JpegOptions
                {
                    ColorType = JpegCompressionColorMode.YCbCr,
                    CompressionType = JpegCompressionMode.JpegLs,
                    JpegLsInterleaveMode = JpegLsInterleaveMode.None,
                    JpegLsAllowedLossyError = 3,
                    JpegLsPreset = null
                });
            }
        }
    }
}
