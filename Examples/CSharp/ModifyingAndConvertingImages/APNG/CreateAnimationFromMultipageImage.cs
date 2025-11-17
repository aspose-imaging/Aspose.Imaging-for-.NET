// GIST-ID: d7ca5eda87507ce948eceef58b808eab
//-----------------------------------------------------------------------------------------------------------
// <copyright file="CreateAnimationFromMultipageImage.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="20.06.2020 18:13:14">
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

namespace CSharp.ModifyingAndConvertingImages.APNG
{
    class CreateAnimationFromMultipageImage
    {
        public static void Run()
        {
            Console.WriteLine("Running example CreateAnimationFromMultipageImage");
            string dataDir = RunExamples.GetDataDir_APNG();
            string fileName = "img4.tif";
            string inputFilePath = Path.Combine(dataDir, fileName);
            string outputFilePath = Path.Combine(dataDir, "img4.tif.500ms.png");

            using (Image image = Image.Load(inputFilePath))
            {
                // Set the default frame duration.
                image.Save(outputFilePath, new ApngOptions() { DefaultFrameTime = 500 }); // 500 ms
            }

            File.Delete(outputFilePath);

            Console.WriteLine("Finished example CreateAnimationFromMultipageImage");
        }
    }
}