//-----------------------------------------------------------------------------------------------------------
// <copyright file="Deskew.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="11.09.2019 14:12:18">
//     Copyright (c) 2001-2012 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages
{
    class Deskew
    {
        public static void Run()
        {
            Console.WriteLine("Running example Deskew");
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            string fileName = "skewed.png";
            string output = "skewed.out.png";
            string inputFileName = Path.Combine(dataDir, fileName);

            // Get rid of the skewed scan with default parameters
            using (RasterImage image = (RasterImage)Image.Load(inputFileName))
            {
                image.NormalizeAngle(false /*do not resize*/, Color.LightGray /*background color*/);
                image.Save(Path.Combine(dataDir, output));
            }

            Console.WriteLine("Finished example Deskew");
        }
    }
}
