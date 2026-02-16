using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.Exif;
using Aspose.Imaging.FileFormats.Core.Photo.Hdr;
using Aspose.Imaging.FileFormats.Jpeg;
using Aspose.Imaging.FileFormats.Png;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.Hdr
{
    internal class SupportOfHdrImages
    {
        public static void Run()
        {
            //ExStart:ReadAndModifyJpegEXIFTags
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_JPEG();

            Console.WriteLine("Running example SupportOfHdrImages");
            string baseFolder = dataDir;
            var sourceFiles = new string[] { "DSC_6918.jpg", "DSC_6919.jpg" };
            var images = new RasterImage[sourceFiles.Length];
            var i = 0;
            foreach (var sourceFile in sourceFiles)
            {
                var sourcePath = Path.Combine(baseFolder, sourceFile);
                images[i] = (RasterImage)Image.Load(sourcePath);
                i++;
            }

            var pixels = HdrProcessor.Process(images, new HdrImageOptions
            {
                SampleCount = 2,
                SmoothFactor = 15,
                AlignImages = false
            });

            var resultPath = Path.Combine(baseFolder, "hdr.jpg");
            using (var image = new PngImage(images[0].Width, images[0].Height))
            {
                //image.SaveArgb32Pixels(image.Bounds, pixels);
                //image.Save(resultPath);
            }

            foreach (var image in images)
            {
                image.Dispose();
            }

            File.Delete(resultPath);            

            Console.WriteLine("Finished example SupportOfHdrImages");
        }
    }
}
