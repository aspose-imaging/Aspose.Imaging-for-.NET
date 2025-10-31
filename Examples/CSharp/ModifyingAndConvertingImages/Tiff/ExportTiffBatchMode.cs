//-----------------------------------------------------------------------------------------------------------
// <copyright file="ExportTiffBatchMode.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="27.03.2020 10:42:48">
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
    public class ExportTiffBatchMode
    {
        public static void Run()
        {
            Console.WriteLine("Running example ExportTiffBatchMode");
            string dataDir = RunExamples.GetDataDir_Tiff();
            string fileName = "10MB_Tif.tif";
            string inputFileName = Path.Combine(dataDir, fileName);

            string outputFileNameTif = Path.Combine(dataDir, "output.tif");
            
            // The ability to perform batch conversion before saving (exporting) TIFF images is implemented.

            using (TiffImage tiffImage = (TiffImage)Image.Load(inputFileName))
            {
                // Set batch operation for pages.
                tiffImage.PageExportingAction = delegate (int index, Image page)
                {
                    // Force garbage collection to avoid unnecessary memory usage from previous pages.
                    GC.Collect();

                    ((RasterImage)page).Rotate(90);
                };

                tiffImage.Save(outputFileNameTif); /* or export through tiffImage.Save("rotated.tif", new TiffOptions(TIFF_EXPECTED_FORMAT)) */

                /* Attention! In batch mode all pages are released at this point.
                   If you need to perform further operations on the original image, reload it from the source into a new instance. */
            }

            Console.WriteLine("Finished example ExportTiffBatchMode");
        }
    }
}