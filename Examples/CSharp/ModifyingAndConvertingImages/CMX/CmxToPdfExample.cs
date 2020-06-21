//-----------------------------------------------------------------------------------------------------------
// <copyright file="CmxToPdfExample.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="21.06.2020 18:52:19">
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

namespace CSharp.ModifyingAndConvertingImages.CMX
{
    class CmxToPdfExample
    {
        public static void Run()
        {
            Console.WriteLine("Running example CmxToPdfExample");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CMX();

            string inputFile = Path.Combine(dataDir, "MultiPage.cmx");

            using (Aspose.Imaging.FileFormats.Cmx.CmxImage image =
                (Aspose.Imaging.FileFormats.Cmx.CmxImage)Image.Load(inputFile))
            {
                Aspose.Imaging.ImageOptions.PdfOptions options = new PdfOptions();
                options.PdfDocumentInfo = new Aspose.Imaging.FileFormats.Pdf.PdfDocumentInfo();

                // Set rasterization options for fileformat
                options.VectorRasterizationOptions = (Aspose.Imaging.ImageOptions.VectorRasterizationOptions)image.GetDefaultOptions(new object[] { Color.White, image.Width, image.Height });
                options.VectorRasterizationOptions.TextRenderingHint = TextRenderingHint.SingleBitPerPixel;
                options.VectorRasterizationOptions.SmoothingMode = SmoothingMode.None;

                image.Save(dataDir + "MultiPage.pdf", options);
            }

            File.Delete(dataDir + "MultiPage.pdf");

            Console.WriteLine("Finished example CmxToPdfExample");
        }
    }
}
