//-----------------------------------------------------------------------------------------------------------
// <copyright file="SupportOfOTG.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="31.07.2019 12:19:15">
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
    public class SupportOfOTG
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_OTG();
            string fileName = "VariousObjectsMultiPage.otg";
            string inputFileName = Path.Combine(dataDir, fileName);
            ImageOptionsBase[] options = { new PngOptions(), new PdfOptions() };
            foreach (ImageOptionsBase item in options)
            {                
                string fileExt = item is PngOptions ? ".png" : ".pdf";                
                using (Image image = Image.Load(inputFileName))
                {
                    OtgRasterizationOptions otgRasterizationOptions = new OtgRasterizationOptions();
                    otgRasterizationOptions.PageSize = image.Size;
                    item.VectorRasterizationOptions = otgRasterizationOptions;
                    image.Save(Path.Combine(dataDir, "output" + fileExt), item);
                }
            }
        }
    }
}
