// GIST-ID: 025334f905cf5b16998540ddf28bf140
//-----------------------------------------------------------------------------------------------------------
// <copyright file="ExportToDxf.cs" company="Aspose Pty Ltd" author="Samer El‑Khatib" date="09.05.2021 15:55:25">
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

namespace CSharp.ModifyingAndConvertingImages.Dxf
{
    class ExportToDxf
    {
        public static void Run()
        {
            Console.WriteLine("Running the ExportToDxf example");
            string dataDir = RunExamples.GetDataDir_EPS();

            using (Image image = Image.Load(Path.Combine(dataDir, "Pooh group.eps")))
            {
                DxfOptions options = new DxfOptions
                {
                    TextAsLines = true,
                    ConvertTextBeziers = true,
                    BezierPointCount = 20
                };
                image.Save(System.IO.Path.Combine(dataDir, "output.dxf"), options);
            }

            File.Delete(System.IO.Path.Combine(dataDir, "output.dxf"));

            Console.WriteLine("Finished the ExportToDxf example");
        }
    }
}