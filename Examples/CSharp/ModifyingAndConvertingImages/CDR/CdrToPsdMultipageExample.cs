﻿//-----------------------------------------------------------------------------------------------------------
// <copyright file="CdrToPsdMultipageExample.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="21.06.2020 17:15:39">
//     Copyright (c) 2001-2012 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.CDR
{
    class CdrToPsdMultipageExample
    {
        public static void Run()
        {
            Console.WriteLine("Running example CdrToPsdMultipageExample");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CDR();

            string inputFileName = dataDir + "MultiPage.cdr";

            using (Aspose.Imaging.FileFormats.Cdr.CdrImage image = (Aspose.Imaging.FileFormats.Cdr.CdrImage)Image.Load(
                inputFileName)
            )
            {
                ImageOptionsBase options = new Aspose.Imaging.ImageOptions.PsdOptions();

                // By default if image is multipage image all pages exported
                options.MultiPageOptions = new Aspose.Imaging.ImageOptions.MultiPageOptions();

                // Optional parameter that indicates to export multipage image as one
                // layer (page) otherwise it will be exported page to page
                options.MultiPageOptions.MergeLayers = true;

                // Set rasterization options for fileformat
                options.VectorRasterizationOptions = (Aspose.Imaging.ImageOptions.VectorRasterizationOptions)image.GetDefaultOptions(new object[] { Color.White, image.Width, image.Height });
                options.VectorRasterizationOptions.TextRenderingHint = TextRenderingHint.SingleBitPerPixel;
                options.VectorRasterizationOptions.SmoothingMode = SmoothingMode.None;

                image.Save(dataDir + "MultiPageOut.psd", options);
            }

            File.Delete(dataDir + "MultiPageOut.psd");

            Console.WriteLine("Finished example CdrToPsdMultipageExample");
        }
    }
}
