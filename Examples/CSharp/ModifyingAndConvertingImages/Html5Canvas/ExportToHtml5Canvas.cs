// GIST-ID: b2017daa35288c46be70d41a3568c240
//-----------------------------------------------------------------------------------------------------------
// <copyright file="ExportToHtml5Canvas.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="29.04.2020 2:14:07">
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

namespace CSharp.ModifyingAndConvertingImages.Html5Canvas
{
    class ExportToHtml5Canvas
    {
        public static void Run()
        {
            Console.WriteLine("Running example ExportToHtml5Canvas");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_SVG();

            using (var image = Image.Load(System.IO.Path.Combine(dataDir, "Sample.svg")))
            {
                image.Save(
                    System.IO.Path.Combine(dataDir, "Sample.html"),
                    new Html5CanvasOptions
                    {
                        VectorRasterizationOptions =
                            new SvgRasterizationOptions() { PageWidth = 100, PageHeight = 100 }
                    });
            }

            Console.WriteLine("Finished example ExportToHtml5Canvas");
        }
    }
}