// GIST-ID: cdfed1c65d611da71b06a95bc061e7f0
//-----------------------------------------------------------------------------------------------------------
// <copyright file="CommonMultipageImageExample.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="28.02.2020 14:32:28">
//     Copyright (c) 2001-2012 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Djvu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Imaging;
using System.IO;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.FileFormats.Tiff.Enums;

namespace CSharp.ModifyingAndConvertingImages.Multipage
{
    class CommonMultipageImageExample
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_DjVu();

            Console.WriteLine("Running example CommonMultipageImageExample");

            using (DjvuImage image = (DjvuImage)Image.Load(Path.Combine(dataDir, "Sample.djvu")))
            {

                if (image is IMultipageImage)
                {
                    var pages = ((IMultipageImage)image).Pages;
                    Console.WriteLine("Pages count in document is " + pages.Length);
                }

                int startPage = 3;
                int countPage = 1;

                PngOptions pngOptions = new PngOptions();
                pngOptions.MultiPageOptions = new MultiPageOptions(new IntRange(startPage, countPage));
                image.Save(Path.Combine(dataDir, "multipageExportSingle_out.png"), pngOptions);


                startPage = 0;
                countPage = 2;
                TiffOptions tiffOptions = new TiffOptions(TiffExpectedFormat.TiffDeflateRgb);
                tiffOptions.MultiPageOptions = new MultiPageOptions(new IntRange(startPage, countPage));
                image.Save(Path.Combine(dataDir, "multipageExportMultiple_out.tiff"), tiffOptions);

            }

            Console.WriteLine("Finished example CommonMultipageImageExample");
        }
    }
}