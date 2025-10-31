//-----------------------------------------------------------------------------------------------------------
// <copyright file="CmxToTiffExample.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="28.10.2020 18:51:20">
//     Copyright (c) 2001-2012 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Tiff.Enums;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.CMX
{
    class CmxToTiffExample
    {
        private static VectorRasterizationOptions[] CreatePageOptions<TOptions>(VectorMultipageImage image) where TOptions : VectorRasterizationOptions
        {
            // Create page rasterization options for each page in the image.
            return image.Pages.Select(x => x.Size).Select(CreatePageOptions<TOptions>).ToArray();
        }

        private static VectorRasterizationOptions CreatePageOptions<TOptions>(Size pageSize) where TOptions : VectorRasterizationOptions
        {
            // Create an instance of the rasterization options.
            var options = Activator.CreateInstance<TOptions>();

            // Set the page size.
            options.PageSize = pageSize;
            return options;
        }

        public static void Run()
        {
            Console.WriteLine("Running example CmxToTiffExample");
            // Path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CMX();

            string inputFile = Path.Combine(dataDir, "MultiPage2.cmx");

            using (var image = (VectorMultipageImage)Image.Load(inputFile))
            {
                // Create page rasterization options.
                var pageOptions = CreatePageOptions<CmxRasterizationOptions>(image);

                // Create TIFF options.
                var options = new TiffOptions(TiffExpectedFormat.TiffDeflateRgb)
                {
                    MultiPageOptions = new MultiPageOptions { PageRasterizationOptions = pageOptions }
                };

                // Export the image to TIFF format.
                image.Save(dataDir + "MultiPage2.cmx.tiff", options);
            }

            File.Delete(dataDir + "MultiPage2.cmx.tiff");

            Console.WriteLine("Finished example CmxToTiffExample");
        }
    }
}