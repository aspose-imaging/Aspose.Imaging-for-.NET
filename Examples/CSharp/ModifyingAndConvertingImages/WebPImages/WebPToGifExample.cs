// GIST-ID: 836560ae97b8902ec53e2f796d94b3f7
//-----------------------------------------------------------------------------------------------------------
// <copyright file="WebPToGifExample.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="21.06.2020 18:24:02">
//     Copyright (c) 2001-2012 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.WebPImages
{
    class WebPToGifExample
    {
        public static void Run()
        {
            Console.WriteLine("Running example WebPToGifExample");
            // Get the path to the data directory.
            string dataDir = RunExamples.GetDataDir_WebPImages();

            string inputFile = Path.Combine(dataDir, "Animation.webp");

            using (Aspose.Imaging.FileFormats.Webp.WebPImage image =
                (Aspose.Imaging.FileFormats.Webp.WebPImage)Image.Load(inputFile))
            {
                GifOptions options = new GifOptions();

                image.Save(dataDir + "Animation.gif", options);
            }

            File.Delete(dataDir + "Animation.gif");

            Console.WriteLine("Finished example WebPToGifExample");
        }
    }
}