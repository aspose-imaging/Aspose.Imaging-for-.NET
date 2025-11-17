// GIST-ID: 617e8e7c69c9bcaced82c71cc514e65d
//-----------------------------------------------------------------------------------------------------------
// <copyright file="GraphCutAutoMasking.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="30.11.2020 2:41:15">
//     Copyright (c) 2001-2012 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Png;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Masking;
using Aspose.Imaging.Masking.Options;
using Aspose.Imaging.Masking.Result;
using Aspose.Imaging.Sources;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.Remove_background
{
    class GraphCutAutoMasking
    {
        public static void Run()
        {
            Console.WriteLine("Running example GraphCutAutoMasking");
            // Path to the documents directory.
            string dataDir = RunExamples.GetDataDir_JPEG();

            string inputFile = Path.Combine(dataDir, "input.jpg");

            MaskingResult results;
            using (RasterImage image = (RasterImage)Image.Load(inputFile))
            {
                // To use Graph Cut with auto‑calculated strokes, AutoMaskingGraphCutOptions is used.
                AutoMaskingGraphCutOptions options = new AutoMaskingGraphCutOptions
                {
                    // Indicates that a new calculation of the default strokes should be performed during image decomposition.
                    CalculateDefaultStrokes = true,
                    // Sets the post‑process feathering radius based on the image size.
                    FeatheringRadius = (Math.Max(image.Width, image.Height) / 500) + 1,
                    Method = SegmentationMethod.GraphCut,
                    Decompose = false,
                    ExportOptions = new PngOptions()
                    {
                        ColorType = PngColorType.TruecolorWithAlpha,
                        Source = new FileCreateSource("tempFile")
                    },
                    BackgroundReplacementColor = Color.Transparent
                };

                results = new ImageMasking(image).Decompose(options);

                using (RasterImage resultImage = (RasterImage)results[1].GetImage())
                {
                    resultImage.Save(dataDir + "output.png", new PngOptions() { ColorType = PngColorType.TruecolorWithAlpha });
                }

                File.Delete(dataDir + "output.png");

                Console.WriteLine("Finished example GraphCutAutoMasking");
            }
        }
    }
}