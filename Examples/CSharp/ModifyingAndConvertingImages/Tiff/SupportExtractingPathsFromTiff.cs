//-----------------------------------------------------------------------------------------------------------
// <copyright file="SupportExtractingPathsFromTiff.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="25.05.2020 11:18:58">
//     Copyright (c) 2001-2012 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using Aspose.Imaging;
using Aspose.Imaging.FileFormats.Psd.Layers.LayerResources.VectorPaths;
using Aspose.Imaging.FileFormats.Tiff;
using Aspose.Imaging.FileFormats.Tiff.Enums;
using Aspose.Imaging.FileFormats.Tiff.PathResources;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.Tiff
{
    class SupportExtractingPathsFromTiff
    {
        public static void Run()
        {
            Console.WriteLine("Running example SupportExtractingPathsFromTiff");
            var filePath = Path.GetTempFileName() + ".tif";
            var pathResources = new List<PathResource> { new PathResource { BlockId = 2000, Name = "Name", Records = new List<VectorPathRecord>() } };

            using (var image = new TiffImage(new TiffFrame(new TiffOptions(TiffExpectedFormat.Default), 10, 10)))
            {
                image.ActiveFrame.PathResources = pathResources;
                image.Save(filePath);
            }

            using (var image = (TiffImage)Image.Load(filePath))
            {
                var actual = image.ActiveFrame.PathResources;
                if (pathResources.Count != actual.Count)
                {
                    Console.WriteLine("Resources count not equal");
                }

                if (pathResources[0].BlockId != actual[0].BlockId)
                {
                    Console.WriteLine("BlockId not equal");
                }

                if (!pathResources[0].Name.Equals(actual[0].Name))
                {
                    Console.WriteLine("Resource name not equal");
                }
            }

            File.Delete(filePath);

            Console.WriteLine("Finished example SupportExtractingPathsFromTiff");
        }
    }
}
