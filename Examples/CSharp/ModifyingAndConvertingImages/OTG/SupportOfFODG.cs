//-----------------------------------------------------------------------------------------------------------
// <copyright file="SupportOfFODG.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="18.12.2019 12:19:15">
//     Copyright (c) 2001-2012 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using Aspose.Imaging;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Examples.CSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.OTG
{
    public class SupportOfFODG
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_OTG();
            string fileName = "sample.fodg";
            string inputFileName = Path.Combine(dataDir, fileName);

            using (Image image = Image.Load(inputFileName))
            {
                image.Save(
                    inputFileName + ".png",
                    new PngOptions()
                        {
                            VectorRasterizationOptions =
                                new OdgRasterizationOptions() { PageSize = image.Size }
                        });
            }
        }
    }
}
