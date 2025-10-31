//-----------------------------------------------------------------------------------------------------------
// <copyright file="CreateGraphicsPathFromPathTiffResourcesAndViceVersa.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="28.08.2020 17:45:27">
//     Copyright (c) 2001-2012 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Tiff;
using Aspose.Imaging.FileFormats.Tiff.PathResources;
using Aspose.Imaging.Shapes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.Tiff
{
    class CreateGraphicsPathFromPathTiffResourcesAndViceVersa
    {
        public static void Run()
        {
            Console.WriteLine("Running example CreateGraphicsPathFromPathTiffResourcesAndViceVersa");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Tiff();

            using (var image = (TiffImage)Image.Load(Path.Combine(dataDir, "Bottle.tif")))
            {
                // Create the GraphicsPath using PathResources from the TIFF image.
                var graphicsPath = PathResourceConverter.ToGraphicsPath(image.ActiveFrame.PathResources.ToArray(), image.ActiveFrame.Size);
                var graphics = new Graphics(image);

                // Draw a red line and save the image.
                graphics.DrawPath(new Pen(Color.Red, 10), graphicsPath);
                image.Save(Path.Combine(dataDir, "BottleWithRedBorder.tif"));
            }

            using (var image = (TiffImage)Image.Load(Path.Combine(dataDir, "Bottle.tif")))
            {
                // Create a rectangular figure for the GraphicsPath.
                var figure = new Figure();
                figure.AddShape(CreateBezierShape(100f, 100f, 500f, 100f, 500f, 1000f, 100f, 1000f));

                // Create a GraphicsPath using the figure.
                var graphicsPath = new GraphicsPath();
                graphicsPath.AddFigure(figure);

                // Set PathResources using the GraphicsPath.
                var pathResources = PathResourceConverter.FromGraphicsPath(graphicsPath, image.Size);
                image.ActiveFrame.PathResources = new List<PathResource>(pathResources);

                // Save the image.
                image.Save(Path.Combine(dataDir, "BottleWithRectanglePath.tif"));
            }

            File.Delete(Path.Combine(dataDir, "BottleWithRedBorder.tif"));
            File.Delete(Path.Combine(dataDir, "BottleWithRectanglePath.tif"));

            Console.WriteLine("Finished example CreateGraphicsPathFromPathTiffResourcesAndViceVersa");
        }

        private static BezierShape CreateBezierShape(params float[] coordinates)
        {
            var bezierPoints = CoordinatesToBezierPoints(coordinates).ToArray();
            return new BezierShape(bezierPoints, true);
        }

        private static IEnumerable<PointF> CoordinatesToBezierPoints(float[] coordinates)
        {
            for (var coordinateIndex = 0; coordinateIndex < coordinates.Length; coordinateIndex += 2)
                for (var index = 0; index < 3; index++)
                    yield return new PointF(coordinates[coordinateIndex] + 100, coordinates[coordinateIndex + 1] + 100);
        }
    }
}