//-----------------------------------------------------------------------------------------------------------
// <copyright file="CompressedVectorFormats.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="29.04.2020 2:22:15">
//     Copyright (c) 2001-2012 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages
{
    class CompressedVectorFormats
    {
        public static void Run()
        {
            Console.WriteLine("Running example CompressedVectorFormats");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_SVG();

            using (var image = Image.Load(System.IO.Path.Combine(dataDir, "Sample.svg")))
            {
                VectorRasterizationOptions vectorRasterizationOptions = new SvgRasterizationOptions() { PageSize = image.Size };
                image.Save(System.IO.Path.Combine(dataDir, "Sample.svgz"), new SvgOptions() { VectorRasterizationOptions = vectorRasterizationOptions, Compress = true });
            }

            Console.WriteLine("Finished example CompressedVectorFormats");
        }
    }
}
