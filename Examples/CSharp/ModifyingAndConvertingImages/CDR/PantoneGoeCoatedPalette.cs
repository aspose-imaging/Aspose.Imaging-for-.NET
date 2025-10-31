//-----------------------------------------------------------------------------------------------------------
// <copyright file="PantoneGoeCoatedPalette.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="15.09.2021 22:47:29">
//     Copyright (c) 2001-2012 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Cdr;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.CDR
{
    class PantoneGoeCoatedPalette
    {
        public static void Run()
        {
            Console.WriteLine("Running example PantoneGoeCoatedPalette");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CDR();

            string inputFileName = dataDir + "test2.cdr";

            using (var image = (CdrImage)Image.Load(inputFileName))
            {
                image.Save(Path.Combine(dataDir, "result.png"), new PngOptions()
                {
                    VectorRasterizationOptions = new CdrRasterizationOptions
                    {
                        Positioning = PositioningTypes.Relative
                    }
                });
            }

            File.Delete(dataDir + "result.png");

            Console.WriteLine("Finished example PantoneGoeCoatedPalette");
        }
    }
}