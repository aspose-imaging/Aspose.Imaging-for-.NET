//-----------------------------------------------------------------------------------------------------------
// <copyright file="CdrToPngExample.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="21.06.2020 17:35:44">
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

namespace CSharp.ModifyingAndConvertingImages.CDR
{
    class CdrToPngExample
    {
        public static void Run()
        {
            Console.WriteLine("Running example CdrToPngExample");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CDR();

            string inputFileName = dataDir + "SimpleShapes.cdr";

            using (Aspose.Imaging.FileFormats.Cdr.CdrImage image = (Aspose.Imaging.FileFormats.Cdr.CdrImage)Image.Load(
                inputFileName)
            )
            {
                PngOptions options = new Aspose.Imaging.ImageOptions.PngOptions();

                options.ColorType = Aspose.Imaging.FileFormats.Png.PngColorType.TruecolorWithAlpha;

                // Set rasterization options for fileformat
                options.VectorRasterizationOptions = image.GetDefaultOptions(new object[] { Color.White, image.Width, image.Height }).VectorRasterizationOptions;
                options.VectorRasterizationOptions.TextRenderingHint = TextRenderingHint.SingleBitPerPixel;
                options.VectorRasterizationOptions.SmoothingMode = SmoothingMode.None;

                image.Save(dataDir + "SimpleShapes.png", options);
            }

            File.Delete(dataDir + "SimpleShapes.png");

            Console.WriteLine("Finished example CdrToPngExample");
        }
    }
}
