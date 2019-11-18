//-----------------------------------------------------------------------------------------------------------
// <copyright file="SvgNativeResize.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="18.11.2019 21:58:09">
//     Copyright (c) 2001-2012 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Svg;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.SVG
{
    class SvgNativeResize
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();            

            // Load the image
            using (SvgImage image = (SvgImage)Image.Load(dataDir + "aspose_logo.Svg"))
            {

                image.Resize(image.Width * 10, image.Height * 15);
                image.Save(dataDir + "Logotype_10_15_out.png", new PngOptions()
                                                     {
                                                         VectorRasterizationOptions = new SvgRasterizationOptions()
                                                     });                
            }            
        }
    }
}
