// GIST-ID: d08c5b3a19109a3112a6f53c0da995d0
//-----------------------------------------------------------------------------------------------------------
// <copyright file="OptimizationStrategyInDicom.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="25.05.2020 11:27:11">
//     Copyright (c) 2001-2012 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using Aspose.Imaging;
using Aspose.Imaging.Brushes;
using Aspose.Imaging.FileFormats.Dicom;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Sources;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.MemoryStrategies
{
    class OptimizationStrategyInDicom
    {
        public static void Run()
        {
            Console.WriteLine("Running example OptimizationStrategyInDicom");

            using (DicomImage image = (DicomImage)Image.Create(
                new DicomOptions() { Source = new StreamSource(new MemoryStream()) },
                100,
                100))
            {
                // Draw something using vector graphics.
                Graphics graphics = new Graphics(image);
                graphics.FillRectangle(new SolidBrush(Color.BlueViolet), image.Bounds);
                graphics.FillRectangle(new SolidBrush(Color.Aqua), 10, 20, 50, 20);
                graphics.FillEllipse(new SolidBrush(Color.Orange), 30, 50, 70, 30);

                // Save the pixels of the drawn image. They are now on the first page of the DICOM image.
                int[] pixels = image.LoadArgb32Pixels(image.Bounds);

                // Add a few pages after the first page, making them darker.
                for (int i = 1; i < 5; i++)
                {
                    DicomPage page = image.AddPage();
                    page.SaveArgb32Pixels(page.Bounds, pixels);
                    page.AdjustBrightness(i * 30);
                }

                // Add a few pages before the main page, making them brighter.
                for (int i = 1; i < 5; i++)
                {
                    DicomPage page = image.InsertPage(0);
                    page.SaveArgb32Pixels(page.Bounds, pixels);
                    page.AdjustBrightness(-i * 30);
                }

                string path = Path.GetTempFileName() + ".dcm";
                // Save the created multi-page image to the output file.
                image.Save(path);
                File.Delete(path);
            }

            Console.WriteLine("Finished example OptimizationStrategyInDicom");
        }
    }
}