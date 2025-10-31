//-----------------------------------------------------------------------------------------------------------
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
            // Path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CDR();

            string inputFileName = dataDir + "MultiPage.cdr";

            using (Aspose.Imaging.FileFormats.Cdr.CdrImage image = (Aspose.Imaging.FileFormats.Cdr.CdrImage)Image.Load(
                inputFileName)
            )
            {
                ImageOptionsBase options = new Aspose.Imaging.ImageOptions.PsdOptions();

                // By default, if the image is multipage, all pages are exported.
                options.MultiPageOptions = new Aspose.Imaging.ImageOptions.MultiPageOptions();

                // Optional parameter that indicates whether to export the multipage image as a single layer (page).
                // If false, each page will be exported as a separate layer.
                options.MultiPageOptions.MergeLayers = true;

                // Set rasterization options for the file format.
                options.VectorRasterizationOptions = image.GetDefaultOptions(new object[] { Color.White, image.Width, image.Height }).VectorRasterizationOptions;
                options.VectorRasterizationOptions.TextRenderingHint = TextRenderingHint.SingleBitPerPixel;
                options.VectorRasterizationOptions.SmoothingMode = SmoothingMode.None;

                image.Save(dataDir + "MultiPageOut.psd", options);
            }

            File.Delete(dataDir + "MultiPageOut.psd");

            Console.WriteLine("Finished example CdrToPsdMultipageExample");
        }
    }
}