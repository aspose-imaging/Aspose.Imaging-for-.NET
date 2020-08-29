//-----------------------------------------------------------------------------------------------------------
// <copyright file="ExportEps.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="29.08.2020 10:33:39">
//     Copyright (c) 2001-2012 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Eps;
using Aspose.Imaging.FileFormats.Pdf;
using Aspose.Imaging.FileFormats.Tiff.Enums;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.EPS
{
    class ExportEps
    {
        public static void Run()
        {
            Console.WriteLine("Running example ExportEps");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_EPS();

            using (var image = (EpsImage)Image.Load(Path.Combine(dataDir, "Sample.eps")))
            {
                var options = new PdfOptions
                                  {
                                      PdfCoreOptions = new PdfCoreOptions
                                                           {
                                                               PdfCompliance =
                                                                   PdfComplianceVersion
                                                                       .PdfA1b // Set required PDF compliance
                                                           }
                                  };

                image.PreviewToExport = EpsPreviewFormat.PostScriptRendering;
                image.Save(Path.Combine(dataDir, "Sample.pdf"), options);
            }

            using (var image = (EpsBinaryImage)Image.Load(Path.Combine(dataDir,"Sample.eps")))
            {
                // Tiff image export options
                var options = new TiffOptions(TiffExpectedFormat.TiffJpegRgb);

                // The first way:
                image.TiffPreview.Save(Path.Combine(dataDir,"Sample1.tiff"), options);

                // The second way:
                image.PreviewToExport = EpsPreviewFormat.TIFF;
                image.Save(Path.Combine(dataDir, "Sample2.tiff"), options);
            }

            Console.Read();

            File.Delete(Path.Combine(dataDir, "Sample.pdf"));
            File.Delete(Path.Combine(dataDir, "Sample1.tiff"));
            File.Delete(Path.Combine(dataDir, "Sample2.tiff"));

            Console.WriteLine("Finished example ExportEps");
        }
    }
}
