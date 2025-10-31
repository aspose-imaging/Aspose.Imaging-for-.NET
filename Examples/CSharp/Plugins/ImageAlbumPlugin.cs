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

namespace CSharp.Plugins
{
    internal class ImageAlbumPlugin
    {
        static string templatesFolder = RunExamples.GetDataDir_PNG();
        string dataDir = RunExamples.GetDataDir_PNG();

        public static void Run()
        {
            Console.WriteLine("Running example Image album Plugin");
            Run5();
            Console.WriteLine("Finished example Image album Plugin");
        }

        //------------------------------------------------------------------
        // Image album creation plug-in example
        //------------------------------------------------------------------
        static void Run5()
        {
            // Valid image album plug-in license usage example
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

                // Unlicensed usage
                outputPath = Path.Combine(templatesFolder, "trial_image_album.tiff");
                MakeTiffAlbum(images, new TiffOptions(TiffExpectedFormat.TiffDeflateRgba), outputPath);

                File.Delete(outputPath);
            }
            finally
            {
                images.ForEach(image => image.Dispose());
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