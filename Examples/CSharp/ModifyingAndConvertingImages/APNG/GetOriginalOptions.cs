// GIST-ID: d11ab7adc16aa94bcd41dd5af1ac1021
//-----------------------------------------------------------------------------------------------------------
// <copyright file="GetOriginalOptions.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="04.06.2021 3:37:14">
//     Copyright (c) 2001-2012 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Apng;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.APNG
{
    class GetOriginalOptions
    {
        public static void Run()
        {
            Console.WriteLine("Running example GetOriginalOptions");
            string dataDir = RunExamples.GetDataDir_APNG();

            using (ApngImage image = (ApngImage)Image.Load(Path.Combine(dataDir, "SteamEngine.png")))
            {
                ApngOptions options = (ApngOptions)image.GetOriginalOptions();
                if (options.NumPlays != 0 || options.DefaultFrameTime != 10 || options.BitDepth != 8)
                {
                    Console.WriteLine("There are some errors in the default options");
                }
            }

            Console.WriteLine("Finished example GetOriginalOptions");
        }  
    }
}