//-----------------------------------------------------------------------------------------------------------
// <copyright file="CreateGifUsingAddPage.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="30.11.2020 2:55:56">
//     Copyright (c) 2001-2012 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Gif;
using Aspose.Imaging.FileFormats.Gif.Blocks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.Gif
{
    class CreateGifUsingAddPage
    {
        public static void Run()
        {
            Console.WriteLine("Running example CreateGifUsingAddPage");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_PNG();

            // Load frames.
            var frames = LoadFrames(Path.Combine(dataDir, "Animation frames")).ToArray();

            // Create GIF image using the first frame.
            using (var image = new GifImage(new GifFrameBlock(frames[0])))
            {
                // Add frames to the GIF image using the AddPage method.
                for (var index = 1; index < frames.Length; index++)
                {
                    image.AddPage(frames[index]);
                }

                // Save GIF image.
                image.Save(dataDir + "Multipage.gif");
            }

            File.Delete(dataDir + "Multipage.gif");

            Console.WriteLine("Finished example CreateGifUsingAddPage");
        }

        private static IEnumerable<RasterImage> LoadFrames(string directory)
        {
            foreach (var filePath in Directory.GetFiles(directory))
            {
                yield return (RasterImage)Image.Load(filePath);
            }
        }
    }
}