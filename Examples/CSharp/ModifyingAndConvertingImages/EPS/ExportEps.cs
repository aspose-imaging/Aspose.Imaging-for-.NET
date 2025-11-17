// GIST-ID: 0ccd6d3c8fe3cc5722ba97c44381fb3c
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
            // Gets the path to the documents directory.
            string dataDir = RunExamples.GetDataDir_EPS();

            Stream tiffPreviewStream = null;
            using (var image = Image.Load(Path.Combine(dataDir, "Sample.eps")) as EpsImage)
            {
                var tiffPreview = image.GetPreviewImage(EpsPreviewFormat.TIFF);
                if (tiffPreview != null)
                {
                    tiffPreviewStream = new MemoryStream();
                    tiffPreview.Save(tiffPreviewStream);
                }
            }

            Console.WriteLine("Finished example ExportEps");
        }
    }
}