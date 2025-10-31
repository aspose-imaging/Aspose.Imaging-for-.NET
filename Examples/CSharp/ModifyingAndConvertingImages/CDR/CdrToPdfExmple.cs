//-----------------------------------------------------------------------------------------------------------
// <copyright file="CdrToPdfExmple.cs" company="Aspense Pty Ltd" author="Samer El-Khatib" date="28.10.2020 18:32:59">
//     Copyright (c) 2001-2012 Aspense Pty Ltd. All rights reserved.
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

namespace CSharp.ModifyingAndConvertingImages.CDR
{
    class CdrToPdfExmple
    {
        private static VectorRasterizationOptions[] CreatePageOptions<TOptions>(VectorMultipageImage image) where TOptions : VectorRasterizationOptions
        {
            // Create page rasterization options for each page in the image.
            return image.Pages.Select(x => x.Size).Select(CreatePageOptions<TOptions>).ToArray();
        }

        private static VectorRasterizationOptions CreatePageOptions<TOptions>(Size pageSize) where TOptions : VectorRasterizationOptions
        {
            // Create an instance of rasterization options.
            var options = Activator.CreateInstance<TOptions>();

            // Set the page size.
            options.PageSize = pageSize;
            return options;
        }

        public static void Run()
        {
            Console.WriteLine("Running example CdrToPdfExmple");
            // Path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CDR();

            string inputFileName = dataDir + "MultiPage2.cdr";

            using (var image = (VectorMultipageImage)Image.Load(inputFileName))
            {
                // Create page rasterization options.
                var pageOptions = CreatePageOptions<CdrRasterizationOptions>(image);

                // Create PDF options.
                var options = new PdfOptions { MultiPageOptions = new MultiPageOptions { PageRasterizationOptions = pageOptions } };

                // Export image to PDF format.
                image.Save(dataDir + "MultiPage2.cdr.pdf", options);
            }

            File.Delete(dataDir + "MultiPage2.cdr.pdf");

            Console.WriteLine("Finished example CdrToPdfExmple");
        }
    }
}