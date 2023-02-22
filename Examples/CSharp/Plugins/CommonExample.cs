using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Imaging;
using Aspose.Imaging.FileFormats.Emf;
using Aspose.Imaging.FileFormats.Png;
using Aspose.Imaging.FileFormats.Tiff;
using Aspose.Imaging.FileFormats.Tiff.Enums;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Sources;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Aspose.Imaging.Examples.CSharp;

namespace CSharp.Plugins
{
    internal class CommonExample
    {
        static string templatesFolder = RunExamples.GetDataDir_PNG();
        string dataDir = RunExamples.GetDataDir_PNG();


        public static void Run()
        {
            Console.WriteLine("Running example Plugins CommonExample");
            Run1();
            Run2();
            Run3();
            Run4();
            Run5();
            Run6();
            Run7();
            Console.WriteLine("Finished example Plugins CommonExample");
        }

        //------------------------------------------------------------------------
        //  Conversion plug-in use sample
        //------------------------------------------------------------------------
        static void Run1()
        {
            // Conversion plug-in licensed use example
            License license = new License();
            try
            {
                license.SetLicense(Path.Combine(Path.Combine(templatesFolder, "License/PlugIn"), "Aspose.Imaging.Conversion.NET.lic"));
            }
            catch 
            { 
            }            

            string OutputDirectory = templatesFolder;

            using (Image image = Image.Load(Path.Combine(templatesFolder, "template.png")))
            {
                var filePath = Path.Combine(templatesFolder, "licensed_tiger0.jpg");
                image.Save(filePath, new JpegOptions());
                File.Delete(filePath);
            }

            // Unlicensed use of resize with conversion license
            using (Image image = Image.Load(Path.Combine(templatesFolder, "template.png")))
            {
                var filePath = Path.Combine(templatesFolder, "trial_tiger0.jpg");

                image.Resize(image.Width << 1, image.Height << 1);

                image.Save(filePath, new JpegOptions());
                File.Delete(filePath);
            }
        }

        //-----------------------------------------------------------------
        // Crop plug-in license use examples
        //-----------------------------------------------------------------
        static void Run2()
        {
            // Valid crop licesing usage example
            License license = new License();
            try
            {
                license.SetLicense(Path.Combine(Path.Combine(templatesFolder, "License/PlugIn"), "Aspose.Imaging.Crop.NET.lic"));
            }
            catch
            {
            }

            string OutputDirectory = templatesFolder;

            using (var image = (RasterImage)Image.Load(Path.Combine(templatesFolder, "template.png")))
            {
                var filePath = Path.Combine(OutputDirectory, "licensed_tiger0.jpg");

                image.Crop(new Rectangle(0, 0, image.Width >> 1, image.Height >> 1));

                image.Save(filePath, new JpegOptions());
                File.Delete(filePath);
            }

            // Unlicensed use of resize with crop license
            using (Image image = Image.Load(Path.Combine(templatesFolder, "template.png")))
            {
                var filePath = Path.Combine(OutputDirectory, "trial_tiger0.jpg");

                image.Resize(image.Width << 1, image.Height << 1);

                image.Save(filePath, new JpegOptions());
                File.Delete(filePath);
            }
        }

        //------------------------------------------------------------------------------
        // Resize plug-in license use examples
        //------------------------------------------------------------------------------

        static void Run3()
        {
            // Valid resize license use example
            License license = new License();
            try
            {
                license.SetLicense(Path.Combine(Path.Combine(templatesFolder, "License/PlugIn"), "Aspose.Imaging.Resize.NET.lic"));
            }
            catch
            {
            }

            string OutputDirectory = templatesFolder;
            if (!Directory.Exists(OutputDirectory))
            {
                Directory.CreateDirectory(OutputDirectory);
            }
            using (Image image = Image.Load(Path.Combine(templatesFolder, "template.png")))
            {
                var filePath = Path.Combine(OutputDirectory, "licensed_tiger0.jpg");

                image.Resize(image.Width << 1, image.Height << 1);

                image.Save(filePath, new JpegOptions());
                File.Delete(filePath);
            }

            // Unlicensed use of flip rotate with resize license
            using (Image image = Image.Load(Path.Combine(templatesFolder, "template.png")))
            {
                var filePath = Path.Combine(OutputDirectory, "trial_tiger0.jpg");

                image.RotateFlip(RotateFlipType.Rotate180FlipXY);

                image.Save(filePath, new JpegOptions());
                File.Delete(filePath);
            }
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

        //------------------------------------------------------------------
        // Image album create plug-in example
        //------------------------------------------------------------------
        static void Run5()
        {
            // Valid image album plug-in license use example
            License license = new License();
            try
            {
                license.SetLicense(Path.Combine(Path.Combine(templatesFolder, "License/PlugIn"), "Aspose.Imaging.Image.Album.NET.lic"));
            }
            catch
            {
            }

            string OutputDirectory = templatesFolder;
            if (!Directory.Exists(OutputDirectory))
            {
                Directory.CreateDirectory(OutputDirectory);
            }

            var images = new List<Image>();

            string[] imagePaths = new string[] { "template.png", "template.jpg", "template.bmp" };

            foreach (var fileName in imagePaths)
            {
                var image = Image.Load(Path.Combine(templatesFolder, fileName));

                images.Add(image);
            }

            try
            {
                var outputPath = Path.Combine(templatesFolder, "licensed_image_album.pdf");
                MakeAlbum(images, new PdfOptions(), outputPath);

                File.Delete(outputPath);

                // Unlicensed use
                outputPath = Path.Combine(templatesFolder, "trial_image_album.tiff");
                MakeTiffAlbum(images, new TiffOptions(TiffExpectedFormat.TiffDeflateRgba), outputPath);

                File.Delete(outputPath);
            }
            finally
            {
                images.ForEach(image => image.Dispose());
            }
        }

        //----------------------------------------------------------
        // Composite use of plug-in licenses example
        //----------------------------------------------------------
        static void Run6()
        {
            // Valid crop licesing usage example
            License license = new License();
            try
            {
                license.SetLicense(Path.Combine(Path.Combine(templatesFolder, "License/PlugIn"), "Aspose.Imaging.Crop.NET.lic"));
            }
            catch
            {
            }

            try
            {
                license.SetLicense(Path.Combine(Path.Combine(templatesFolder, "License/PlugIn"), "Aspose.Imaging.Resize.NET.lic"));
            }
            catch
            {
            }

            string OutputDirectory = templatesFolder;

            using (var image = (RasterImage)Image.Load(Path.Combine(templatesFolder, "template.png")))
            {
                var filePath = Path.Combine(templatesFolder, "licensed_tiger0.jpg");

                image.Resize(image.Width << 1, image.Height << 1);

                image.Crop(new Rectangle(0, 0, image.Width >> 1, image.Height >> 1));

                image.Save(filePath, new JpegOptions());
                File.Delete(filePath);
            }
        }

        static void Run7()
        {
            // Valid image album plug-in license use example
            License license = new License();
            try
            {
                license.SetLicense(Path.Combine(Path.Combine(templatesFolder, "License/PlugIn"), "Aspose.Imaging.Image.Album.NET.lic"));
            }
            catch
            {
            }

            string OutputDirectory = templatesFolder;

            var images = new List<Image>();

            string[] imagePaths = new string[] { "template.png", "template.jpg", "template.bmp" };

            foreach (var fileName in imagePaths)
            {
                var image = Image.Load(Path.Combine(templatesFolder, fileName));

                images.Add(image);
            }

            try
            {
                var outputPath = Path.Combine(templatesFolder, "licensed_image_album.pdf");
                MakeAlbum(images, new PdfOptions(), outputPath);

                File.Delete(outputPath);
                // Unlicensed use
                outputPath = Path.Combine(templatesFolder, "trial_image_album.tiff");
                MakeTiffAlbum(images, new TiffOptions(TiffExpectedFormat.TiffDeflateRgba), outputPath);
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

        static void MakeTiffAlbum(List<Image> images, TiffOptions rgbOptions, string outputPath)
        {
            using (var tiffImage = new TiffImage(new TiffFrame[0]))
            {

                foreach (var image in images.Where(image => image is RasterImage))
                {
                    tiffImage.AddFrame(new TiffFrame(image as RasterImage, rgbOptions));
                    tiffImage.Frames[tiffImage.Frames.Length - 1].Grayscale();
                }

                tiffImage.ActiveFrame = tiffImage.Frames[0];

                tiffImage.Save(outputPath, rgbOptions);
            }
        }

        static void MakeAlbum(List<Image> images, ImageOptionsBase imageOptions, string outputPath)
        {
            using (var image = Image.Create(images.ToArray()))
            {
                image.Save(outputPath, imageOptions);
            }
        }

        enum MergeDirection
        {
            Horizontal = 0,
            Vertical = 1
        }
    }
}
