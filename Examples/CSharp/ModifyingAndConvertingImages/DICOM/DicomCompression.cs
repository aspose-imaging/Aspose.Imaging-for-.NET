//-----------------------------------------------------------------------------------------------------------
// <copyright file="DicomCompression.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="04.10.2020 16:58:17">
//     Copyright (c) 2001-2012 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Dicom;
using Aspose.Imaging.FileFormats.Jpeg2000;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.DICOM
{
    class DicomCompression
    {
        public static void Run()
        {
            // To get proper output, please apply a valid Aspose.Imaging license. You can purchase a full license
            // or obtain a 30‑day temporary license from https://www.aspose.com/purchase/default.aspx.

            Console.WriteLine("Running example DicomCompression");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DICOM();
            string inputFile = Path.Combine(dataDir, "original.jpg");
            string output1 = Path.Combine(dataDir, "original_Uncompressed.dcm");
            string output2 = Path.Combine(dataDir, "original_JPEG.dcm");
            string output3 = Path.Combine(dataDir, "original_JPEG2000.dcm");
            string output4 = Path.Combine(dataDir, "original_RLE.dcm");
            
            using (var inputImage = Image.Load(inputFile))
            {
                var options = new DicomOptions
                {
                    ColorType = ColorType.Rgb24Bit,
                    Compression = new Compression { Type = CompressionType.None }
                };

                inputImage.Save(output1, options);
            }

            using (var inputImage = Image.Load(inputFile))
            {
                var options = new DicomOptions
                {
                    ColorType = ColorType.Rgb24Bit,
                    Compression = new Compression { Type = CompressionType.Jpeg }
                };

                inputImage.Save(output2, options);
            }

            using (var inputImage = Image.Load(inputFile))
            {
                var options = new DicomOptions
                {
                    ColorType = ColorType.Rgb24Bit,
                    Compression = new Compression
                    {
                        Type = CompressionType.Jpeg2000,
                        Jpeg2000 = new Jpeg2000Options
                        {
                            Codec = Jpeg2000Codec.Jp2,
                            Irreversible = false
                        }
                    }
                };

                inputImage.Save(output3, options);
            }

            using (var inputImage = Image.Load(inputFile))
            {
                var options = new DicomOptions
                {
                    ColorType = ColorType.Rgb24Bit,
                    Compression = new Compression { Type = CompressionType.Rle }
                };

                inputImage.Save(output4, options);
            }

            File.Delete(output1);
            File.Delete(output2);
            File.Delete(output3);
            File.Delete(output4);

            Console.WriteLine("Finished example DicomCompression");
        }
    }
}