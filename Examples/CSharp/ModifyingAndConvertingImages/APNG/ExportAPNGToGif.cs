// GIST-ID: c7ff17f0ec19f4bade69392bb3f246b8
//-----------------------------------------------------------------------------------------------------------
// <copyright file="ExportAPNGToGif.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="20.06.2020 18:02:20">
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

namespace CSharp.ModifyingAndConvertingImages.APNG
{
    class ExportAPNGToGif
    {
        public static void Run()
        {
            Console.WriteLine("Running example ExportAPNGToGif");
            string dataDir = RunExamples.GetDataDir_APNG();
            string fileName = "elephant.png";
            string inputFilePath = Path.Combine(dataDir, fileName);
            string outputFilePath = Path.Combine(dataDir, "elephant_out.png.gif");

            using (Image image = Image.Load(inputFilePath))
            {
                // Export to the other animated format.
                image.Save(outputFilePath, new GifOptions());
            }

            File.Delete(outputFilePath);

            Console.WriteLine("Finished example ExportAPNGToGif");
        }
    }
}