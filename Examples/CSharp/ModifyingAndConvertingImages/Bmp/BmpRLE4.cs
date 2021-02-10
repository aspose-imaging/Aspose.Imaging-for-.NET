//-----------------------------------------------------------------------------------------------------------
// <copyright file="BmpRLE4.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="10.02.2021 11:59:34">
//     Copyright (c) 2001-2012 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Bmp;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.Bmp
{
    class BmpRLE4
    {
        public static void Run()
        {
            Console.WriteLine("Running example BmpRLE4");
            string dataDir = RunExamples.GetDataDir_Bmp();

            using (Image image = Image.Load(Path.Combine(dataDir,"Rle4.bmp")))
            {
                image.Save(
                    System.IO.Path.Combine(dataDir, "output.bmp"),
                    new BmpOptions()
                        {
                            Compression = BitmapCompression.Rle4,
                            BitsPerPixel = 4,
                            Palette = ColorPaletteHelper.Create4Bit()
                        });
            }

            File.Delete(System.IO.Path.Combine(dataDir, "output.bmp"));

            Console.WriteLine("Finished example BmpRLE4");
        }   
    }
}
