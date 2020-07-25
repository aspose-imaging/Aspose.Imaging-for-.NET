//-----------------------------------------------------------------------------------------------------------
// <copyright file="ConvertTo1BitPng.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="25.07.2020 3:07:14">
//     Copyright (c) 2001-2012 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Jpeg;
using Aspose.Imaging.FileFormats.Png;
using Aspose.Imaging.FileFormats.Tiff.Enums;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.PNG
{
    class ConvertTo1BitPng
    {
        public static void Run()
        {
            Console.WriteLine("Running example ConvertTo1BitPng");
            string inputFilePath = "00020.png";
            string outputFilePath = "00020_png.png";
            var filePath = RunExamples.GetDataDir_PNG();

            ExportImage(
                Path.Combine(filePath, inputFilePath),
                    Path.Combine(filePath, outputFilePath),
                    FileFormat.Png,
                    0,
                    null);

            Console.WriteLine("Finished example ConvertTo1BitPng");
        }

        private static void ExportImage(
            string sourceImageFilePath,
            string outputImageFilePath,
            Aspose.Imaging.FileFormat targetFormat,
            float rotateAngle,
            Aspose.Imaging.RotateFlipType? rotateFlipType)
        {
            using (RasterImage image = (RasterImage)Image.Load(
                sourceImageFilePath,
                new LoadOptions() { BufferSizeHint = 450 }))
            {
                if (!image.IsCached)
                {
                    // !!! The caching call was in the customer example.
                    // We strongly recommend that you do not use caching in this case,
                    // since this leads to a noticeable decrease in performance in this case (in memory optimization strategy).
                    image.CacheData();
                }

                if (rotateAngle != 0)
                {
                    image.Rotate(rotateAngle);
                }

                if (rotateFlipType != null)
                {
                    image.RotateFlip(rotateFlipType.Value);
                }

                int bitsPerPixel = image.BitsPerPixel;
                int bitDepth = bitsPerPixel == 1 ? 1 : bitsPerPixel < 8 ? 8 : 24;

                ImageOptionsBase exportOptions;
                switch (targetFormat)
                {
                    case FileFormat.Jpeg:
                        if (bitDepth <= 8)
                        {
                            exportOptions = new JpegOptions()
                            {
                                Palette = ColorPaletteHelper.Create8BitGrayscale(true),
                                ColorType = JpegCompressionColorMode.Grayscale
                            };
                        }
                        else
                        {
                            exportOptions = new JpegOptions();
                        }

                        break;
                    case FileFormat.Png:
                        if (bitDepth <= 8)
                        {
                            exportOptions = new PngOptions()
                            {
                                Progressive = false,
                                ColorType = PngColorType.Grayscale,
                                BitDepth = (byte)bitDepth
                            };
                        }
                        else
                        {
                            exportOptions = new PngOptions()
                            {
                                Progressive = false
                            };
                        }

                        break;
                    case FileFormat.Tiff:
                        switch (bitDepth)
                        {
                            case 1:
                                exportOptions =
                                    new TiffOptions(TiffExpectedFormat.Default)
                                    {
                                        Photometric = TiffPhotometrics.MinIsWhite,
                                        Palette = ColorPaletteHelper.CreateMonochrome(),
                                        Compression = TiffCompressions.CcittFax4,
                                        BitsPerSample = new ushort[] { 1 }
                                    };
                                break;
                            case 8:
                                exportOptions =
                                    new TiffOptions(TiffExpectedFormat.Default)
                                    {
                                        Photometric = TiffPhotometrics.MinIsWhite,
                                        Palette = ColorPaletteHelper.Create8BitGrayscale(true),
                                        Compression = TiffCompressions.Deflate,
                                        BitsPerSample = new ushort[] { 8 }
                                    };
                                break;
                            default:
                                ushort bitsPerSample = (ushort)(bitDepth / 3);
                                exportOptions =
                                    new TiffOptions(TiffExpectedFormat.Default)
                                    {
                                        Photometric = TiffPhotometrics.Rgb,
                                        Compression = TiffCompressions.Jpeg,
                                        BitsPerSample = new ushort[] { bitsPerSample, bitsPerSample, bitsPerSample }
                                    };
                                break;
                        }

                        break;
                    default:
                        return;
                }

                exportOptions.BufferSizeHint = 2056;
                exportOptions.ResolutionSettings = new ResolutionSetting(50, 50);

                image.Save(outputImageFilePath, exportOptions);
            }
        }
    }
}
