// GIST-ID: ee2276709661dc43611b1314c2b212cc
//-----------------------------------------------------------------------------------------------------------
// <copyright file="CreateAPNGAnimationFromSinglePageImage.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="20.06.2020 18:16:55">
//     Copyright (c) 2001-2012 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Apng;
using Aspose.Imaging.FileFormats.Png;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Sources;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.APNG
{
    class CreateAPNGAnimationFromSinglePageImage
    {
        public static void Run()
        {
            Console.WriteLine("Running example CreateAPNGAnimationFromSinglePageImage");

            const int AnimationDuration = 1000; // 1 s
            const int FrameDuration = 70; // 70 ms

            string dataDir = RunExamples.GetDataDir_APNG();
            string fileName = "not_animated.png";
            string inputFilePath = Path.Combine(dataDir, fileName);
            string outputFilePath = Path.Combine(dataDir, "raster_animation.png");

            using (RasterImage sourceImage = (RasterImage)Image.Load(inputFilePath))
            {
                ApngOptions createOptions = new ApngOptions
                {
                    Source = new FileCreateSource(outputFilePath, false),
                    DefaultFrameTime = (uint)FrameDuration,
                    ColorType = PngColorType.TruecolorWithAlpha,
                };

                using (ApngImage apngImage = (ApngImage)Image.Create(
                    createOptions,
                    sourceImage.Width,
                    sourceImage.Height))
                {
                    int numOfFrames = AnimationDuration / FrameDuration;
                    int numOfFrames2 = numOfFrames / 2;

                    apngImage.RemoveAllFrames();

                    // Add the first frame.
                    apngImage.AddFrame(sourceImage, FrameDuration);

                    // Add intermediate frames.
                    for (int frameIndex = 1; frameIndex < numOfFrames - 1; ++frameIndex)
                    {
                        apngImage.AddFrame(sourceImage, FrameDuration);
                        ApngFrame lastFrame = (ApngFrame)apngImage.Pages[apngImage.PageCount - 1];
                        float gamma = frameIndex >= numOfFrames2 ? numOfFrames - frameIndex - 1 : frameIndex;
                        lastFrame.AdjustGamma(gamma);
                    }

                    // Add the last frame.
                    apngImage.AddFrame(sourceImage, FrameDuration);

                    apngImage.Save();
                }
            }

            File.Delete(outputFilePath);

            Console.WriteLine("Finished example CreateAPNGAnimationFromSinglePageImage");
        }
    }
}