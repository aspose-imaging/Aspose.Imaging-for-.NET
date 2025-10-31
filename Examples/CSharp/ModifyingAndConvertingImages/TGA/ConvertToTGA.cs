//-----------------------------------------------------------------------------------------------------------
// <copyright file="ConvertToTGA.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="04.10.2020 17:39:43">
//     Copyright (c) 2001-2012 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Jpeg;
using Aspose.Imaging.FileFormats.Tga;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.TGA
{
    class ConvertToTGA
    {
        public static void Run()
        {
            // To get proper output, please apply a valid Aspose.Imaging license. You can purchase a full license or obtain a 30‑day temporary license from https://www.aspose.com/purchase/default.aspx.

            Console.WriteLine("Running example ConvertToTGA");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_TGA();
            string inputFile = Path.Combine(dataDir, "test.jpg");
            string inputFile2 = Path.Combine(dataDir, "test.png");
            string inputFile3 = Path.Combine(dataDir, "test.tga");
            string output1 = Path.Combine(dataDir, "test_.tga");
            string output2 = Path.Combine(dataDir, "test2_.tga");
            string output3 = Path.Combine(dataDir, "test3_.tga");

            using (RasterImage image = (JpegImage)Image.Load(inputFile))
            {
                image.Save(output1, new TgaOptions());
            }

            using (RasterImage image = (RasterImage)Image.Load(inputFile2))
            {
                using (TgaImage tgaImage = new TgaImage(image))
                {
                    tgaImage.Save(output2);
                }
            }

            using (TgaImage image = (TgaImage)Image.Load(inputFile3))
            {
                image.DateTimeStamp = DateTime.UtcNow;
                image.AuthorName = "John Smith";
                image.AuthorComments = "Comment";
                image.ImageId = "ImageId";
                image.JobNameOrId = "Important Job";
                image.JobTime = TimeSpan.FromDays(10);
                image.TransparentColor = Color.FromArgb(123);
                image.SoftwareId = "SoftwareId";
                image.SoftwareVersion = "abc1";
                image.SoftwareVersionLetter = 'a';
                image.SoftwareVersionNumber = 2;
                image.XOrigin = 1000;
                image.YOrigin = 1000;

                image.Save(output3);
            }

            File.Delete(output1);
            File.Delete(output2);
            File.Delete(output3);

            Console.WriteLine("Finished example ConvertToTGA");
        }
    }
}