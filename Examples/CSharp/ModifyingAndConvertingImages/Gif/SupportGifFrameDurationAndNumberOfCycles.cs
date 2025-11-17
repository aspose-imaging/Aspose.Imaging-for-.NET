// GIST-ID: 85d6b75b15f184dbbafea53d0c5a1b75
//-----------------------------------------------------------------------------------------------------------
// <copyright file="SupportGifFrameDurationAndNumberOfCycles.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="05.07.2021 18:43:38">
//     Copyright (c) 2001-2012 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Gif;
using Aspose.Imaging.FileFormats.Gif.Blocks;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.Gif
{
    class SupportGifFrameDurationAndNumberOfCycles
    {
        public static void Run()
        {
            Console.WriteLine("Running example SupportGifFrameDurationAndNumberOfCycles");
            string dataDir = RunExamples.GetDataDir_GIF();
            string filepath = Path.Combine(dataDir, "ezgif.com-gif-maker(1)___.gif");
            string outputPath = Path.Combine(dataDir, "output.gif");

            using (GifImage image = (GifImage)Image.Load(filepath))
            {
                image.SetFrameTime(2000);
                ((GifFrameBlock)image.Pages[0]).FrameTime = 200;
                image.Save(outputPath, new GifOptions() { LoopsCount = 4 });
            }

            File.Delete(outputPath);

            Console.WriteLine("Finished example SupportGifFrameDurationAndNumberOfCycles");
        }
    }
}