//-----------------------------------------------------------------------------------------------------------
// <copyright file="DicomToPngExample.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="21.06.2020 19:13:33">
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

namespace CSharp.ModifyingAndConvertingImages.DICOM
{
    class DicomToPngExample
    {
        public static void Run()
        {
            Console.WriteLine("Running example DicomToPngExample");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DICOM();

            string inputFile = Path.Combine(dataDir, "MultiframePage1.dicom");

            using (Aspose.Imaging.FileFormats.Dicom.DicomImage image =
                (Aspose.Imaging.FileFormats.Dicom.DicomImage)Image.Load(inputFile))
            {
                PngOptions options = new PngOptions();

                image.Save(dataDir + @"MultiframePage1.png", options);
            }


            File.Delete(dataDir + "MultiframePage1.png");

            Console.WriteLine("Finished example DicomToPngExample");
        }
    }
}
