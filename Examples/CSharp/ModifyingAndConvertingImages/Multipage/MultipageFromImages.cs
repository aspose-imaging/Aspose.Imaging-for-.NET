//-----------------------------------------------------------------------------------------------------------
// <copyright file="MultipageFromImages.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="15.01.2021 0:16:48">
//     Copyright (c) 2001-2012 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using Aspose.Imaging.Examples.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Imaging;
using Aspose.Imaging.ImageOptions;
using System.IO;
using Aspose.Imaging.FileFormats.Tiff.Enums;

namespace CSharp.ModifyingAndConvertingImages.Multipage
{
    class MultipageFromImages
    {
        public static void Run()
        {
            Console.WriteLine("Running example MultipageFromImages");
            // Path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Multipage();

            string baseFolder = dataDir;

            string outFileName = "MultipageImageCreateTest.tif";
            string outputFilePath = Path.Combine(baseFolder, outFileName);
            string[] files = new string[]
                                 {
                                     "33266.tif", "Animation.gif", "elephant.png",
                                     "MultiPage.cdr"
                                 };
            List<Image> images = new List<Image>();
            foreach (var file in files)
            {
                string filePath = Path.Combine(baseFolder, file);
                images.Add(Image.Load(filePath));
            }

            using (Image image = Image.Create(images.ToArray(), true))
            {
                image.Save(outputFilePath, new TiffOptions(TiffExpectedFormat.TiffJpegRgb));
            }

            File.Delete(outputFilePath);

            Console.WriteLine("Finished example MultipageFromImages");
        }
    }
}