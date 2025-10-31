//-----------------------------------------------------------------------------------------------------------
// <copyright file="SupportOfDPISettingsInPdfOptions.cs" company="Aspose Pty Ltd" author="Samer El‑Khatib" date="31.07.2019 12:51:44">
//     Copyright (c) 2001-2012 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.ImageOptions;
using System;
using System.IO;

namespace CSharp.ModifyingAndConvertingImages
{
    class SupportOfDPISettingsInPdfOptions
    {
        public static void Run()
        {
            Console.WriteLine("Running example SupportOfDPISettingsInPdfOptions");
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            string fileName = "SampleTiff1.tiff";
            string inputFileName = Path.Combine(dataDir, fileName);
            string outFileName = inputFileName + ".pdf";

            using (Image image = Image.Load(inputFileName))
            {
                // Set the PDF page size (width: 612 points, height: 792 points).
                PdfOptions pdfOptions = new PdfOptions { PageSize = new SizeF(612, 792) };
                image.Save(outFileName, pdfOptions);
            }

            Console.WriteLine("Finished example SupportOfDPISettingsInPdfOptions");
        }
    }
}