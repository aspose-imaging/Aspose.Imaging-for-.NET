using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Tiff;
using Aspose.Imaging.FileFormats.Tiff.Enums;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Imaging.Sources;
using Aspose.Imaging.FileFormats.Png;

namespace CSharp.Plugins
{
    internal class MergePlugin
    {
        static string templatesFolder = RunExamples.GetDataDir_PNG();
        string dataDir = RunExamples.GetDataDir_PNG();

        public static void Run()
        {
            Console.WriteLine("Running example Merge Plugin");
            Run4();
            Console.WriteLine("Finished example Merge Plugin");
        }

        //---------------------------------------------------------------------------------------
        //  Image merge plug-in use examples
        //---------------------------------------------------------------------------------------

        static void Run4()
        {
            // Valid resize license use example
            License license = new License();
            try
            {
                license.SetLicense(Path.Combine(Path.Combine(templatesFolder, "License/PlugIn"), "Aspose.Imaging.Merge.NET.lic"));
            }
            catch
            {
            }

            string OutputDirectory = templatesFolder;

            var images = new List<Image>();

            int maxWidth = 0;
            int maxHeight = 0;
            int totalWidth = 0;
            int totalHeight = 0;

            string[] imagePaths = new string[] { "template.png", "template.jpg", "template.bmp" };

            foreach (string fileName in imagePaths)
            {
                var image = Image.Load(Path.Combine(templatesFolder, fileName));

                totalWidth += image.Width;

                if (image.Width > maxWidth)
                {
                    maxWidth = image.Width;
                }

                totalHeight += image.Height;

                if (image.Height > maxHeight)
                {
                    maxHeight = image.Height;
                }

                images.Add(image);
            }

            try
            {
                var outputPath = Path.Combine(OutputDirectory, "licensed_merge_horizontal.jpg");
                MergeImages(images, MergeDirection.Horizontal, totalWidth, maxHeight, outputPath);

                File.Delete(outputPath);

                outputPath = Path.Combine(OutputDirectory, "licensed_merge_vertical.jpg");
                MergeImages(images, MergeDirection.Vertical, totalHeight, maxWidth, outputPath);

                File.Delete(outputPath);

                // Unlicensed crop with merge plug-in license
                outputPath = Path.Combine(OutputDirectory, "trial_merge_vertical.jpg");
                MergeImages(images, MergeDirection.Vertical, totalHeight, maxWidth, outputPath,
                            (image) =>
                            {
                                var rasterImage = image as RasterImage;
                                if (rasterImage == null)
                                {
                                    return false;
                                }

                                rasterImage.Crop(new Rectangle(0, 0, image.Width >> 1, image.Height >> 1));
                                return true;
                            }
                            );

                File.Delete(outputPath);
            }
            finally
            {
                images.ForEach(image => image.Dispose());
            }
        }

        static void MergeImages(List<Image> images, MergeDirection direction, int totalSize, int maxSize, string outputPath, Func<Image, bool> callback = null)
        {
            int targetWidth, targetHeight;

            switch (direction)
            {
                case MergeDirection.Horizontal:
                    {
                        targetWidth = totalSize;
                        targetHeight = maxSize;
                        break;
                    }
                case MergeDirection.Vertical:
                    {
                        targetWidth = maxSize;
                        targetHeight = totalSize;
                        break;
                    }
                default:
                    throw new ArgumentException("Unexpected merge direction");
            }

            var pngOptions = new PngOptions() { ColorType = PngColorType.TruecolorWithAlpha };
            using (Stream stream = new MemoryStream())
            {
                pngOptions.Source = new StreamSource(stream);

                using (var image = Image.Create(pngOptions, targetWidth, targetHeight))
                {
                    image.BackgroundColor = Color.White;
                    var graphics = new Graphics(image);

                    float x = 0, y = 0;
                    images.ForEach(image2 =>
                    {
                        graphics.DrawImage(image2, new RectangleF(x, y, image2.Width, image2.Height));

                        if (direction == MergeDirection.Horizontal)
                        {
                            x += image2.Width;
                        }

                        if (direction == MergeDirection.Vertical)
                        {
                            y += image2.Height;
                        }
                    });

                    if (callback != null)
                    {
                        callback(image);
                    }

                    image.Save(outputPath);
                }
            }

        }

        enum MergeDirection
        {
            Horizontal = 0,
            Vertical = 1
        }
    }
}
