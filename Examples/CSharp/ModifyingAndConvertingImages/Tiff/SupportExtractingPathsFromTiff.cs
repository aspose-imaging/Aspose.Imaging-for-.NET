// GIST-ID: 140bbbd3c9a491887f1ed8d16d82fe85
//-----------------------------------------------------------------------------------------------------------
// <copyright file="SupportExtractingPathsFromTiff.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="25.05.2020 11:18:58">
//     Copyright (c) 2001-2012 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Core.VectorPaths;
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

            var filePath = RunExamples.GetDataDir_Tiff();
            using (var image = (TiffImage)Image.Load(Path.Combine(filePath, "Sample.tif")))
            {
                foreach (var path in image.ActiveFrame.PathResources)
                {
                    Console.WriteLine(path.Name);
                }

                image.Save(Path.Combine(filePath, "SampleWithPaths.psd"), new PsdOptions());
            }

            // Create a clipping path manually
            using (var image = (TiffImage)Image.Load(Path.Combine(filePath, "Sample.tif")))
            {
                image.ActiveFrame.PathResources = new List<PathResource>
                                                      {
                                                          new PathResource
                                                              {
                                                                  BlockId = 2000, // Block ID according to the Photoshop specification
                                                                  Name = "My Clipping Path", // Path name
                                                                  Records = CreateRecords(
                                                                      0.2f,
                                                                      0.2f,
                                                                      0.8f,
                                                                      0.2f,
                                                                      0.8f,
                                                                      0.8f,
                                                                      0.2f,
                                                                      0.8f) // Create path records using the coordinates
                                                              }
                                                      };

                image.Save(Path.Combine(filePath, "ImageWithPath.tif"));
            }

            File.Delete(Path.Combine(filePath, "SampleWithPaths.psd"));
            File.Delete(Path.Combine(filePath, "ImageWithPath.tif"));

            Console.WriteLine("Finished example SupportExtractingPathsFromTiff");
        }

        private static List<VectorPathRecord> CreateRecords(params float[] coordinates)
        {
            var records = CreateBezierRecords(coordinates); // Create Bezier records using coordinates

            records.Insert(0, new LengthRecord // LengthRecord required by the Photoshop specification
                                  {
                                      IsOpen = false, // Let's create a closed path
                                      RecordCount = (ushort)records.Count // Record count in the path
                                  });

            return records;
        }

        private static List<VectorPathRecord> CreateBezierRecords(float[] coordinates)
        {
            return CoordinatesToPoints(coordinates)
                .Select(CreateBezierRecord)
                .ToList();
        }

        private static IEnumerable<PointF> CoordinatesToPoints(float[] coordinates)
        {
            for (var index = 0; index < coordinates.Length; index += 2)
                yield return new PointF(coordinates[index], coordinates[index + 1]);
        }

        private static VectorPathRecord CreateBezierRecord(PointF point)
        {
            return new BezierKnotRecord { PathPoints = new[] { point, point, point } };
        }
    }
}