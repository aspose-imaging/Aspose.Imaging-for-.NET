﻿//-----------------------------------------------------------------------------------------------------------
// <copyright file="WebPToPdfExample.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="21.06.2020 18:42:17">
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

namespace CSharp.ModifyingAndConvertingImages.WebPImages
{
    class WebPToPdfExample
    {
        public static void Run()
        {
            Console.WriteLine("Running example WebPToPdfExample");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_WebPImages();

            string inputFile = Path.Combine(dataDir, "Animation.webp");

            using (Aspose.Imaging.FileFormats.Webp.WebPImage image =
                (Aspose.Imaging.FileFormats.Webp.WebPImage)Image.Load(inputFile))
            {
                Aspose.Imaging.ImageOptions.PdfOptions options = new PdfOptions();
                options.PdfDocumentInfo = new Aspose.Imaging.FileFormats.Pdf.PdfDocumentInfo();

                image.Save(dataDir + "Animation.pdf", options);
            }

            File.Delete(dataDir + "Animation.pdf");

            Console.WriteLine("Finished example WebPToPdfExample");
        }
    }
}
