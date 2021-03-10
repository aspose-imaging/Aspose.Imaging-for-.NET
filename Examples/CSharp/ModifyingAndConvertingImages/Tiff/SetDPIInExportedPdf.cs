//-----------------------------------------------------------------------------------------------------------
// <copyright file="SetDPIInExportedPdf.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="10.03.2021 21:25:51">
//     Copyright (c) 2001-2012 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Tiff;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.Tiff
{
    class SetDPIInExportedPdf
    {
        public static void Run()
        {
            Console.WriteLine("Running example SetDPIInExportedTiff");

            var filePath = RunExamples.GetDataDir_Tiff();
            using (TiffImage image = (TiffImage)Image.Load(Path.Combine(filePath, "AFREY-Original.tif")))
            {
                PdfOptions pdfOptions = new PdfOptions()
                                            {
                                                ResolutionSettings = new ResolutionSetting(
                                                    image.HorizontalResolution,
                                                    image.VerticalResolution)
                                            };

                image.Save(Path.Combine(filePath, "result.pdf"), pdfOptions);

            }

            File.Delete(Path.Combine(filePath, "result.pdf"));

            Console.WriteLine("Finished example SetDPIInExportedTiff");
        }
    }
}
