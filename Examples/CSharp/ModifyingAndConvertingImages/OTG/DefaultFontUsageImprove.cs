// GIST-ID: 5a367189a140bfd764272a8b48c7e3f8
//-----------------------------------------------------------------------------------------------------------
// <copyright file="DefaultFontUsageImprove.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="06.04.2021 12:45:24">
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

namespace CSharp.ModifyingAndConvertingImages.OTG
{
    class DefaultFontUsageImprove
    {
        public static void Run()
        {
            Console.WriteLine("Running the DefaultFontUsageImprove example");
            string dataDir = RunExamples.GetDataDir_OTG();

            string currentFolder = dataDir;
            FontSettings.SetFontsFolder(Path.Combine(currentFolder, "fonts"));
            FontSettings.GetSystemAlternativeFont = false;
            ExportToPng(Path.Combine(dataDir, "missing-font2.odg"), "Arial", Path.Combine(dataDir, "arial.png"));
            ExportToPng(
                Path.Combine(dataDir, "missing-font2.odg"),
                "Courier New",
                Path.Combine(dataDir, "courier.png"));

            // File.Delete(System.IO.Path.Combine(dataDir, "output.bmp"));

            Console.WriteLine("Finished the DefaultFontUsageImprove example");
        }

        private static void ExportToPng(string filePath, string defaultFontName, string outfileName)
        {
            FontSettings.DefaultFontName = defaultFontName;
            using (Aspose.Imaging.Image document = Aspose.Imaging.Image.Load(filePath))
            {
                PngOptions saveOptions = new PngOptions();
                saveOptions.VectorRasterizationOptions = new OdgRasterizationOptions();
                saveOptions.VectorRasterizationOptions.PageWidth = 1000;
                saveOptions.VectorRasterizationOptions.PageHeight = 1000;
                document.Save(outfileName, saveOptions);
            }

            File.Delete(outfileName);
        }
    }
}