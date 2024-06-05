using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.Exif;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.DICOM
{
    internal class RemoveAndSaveWithMetadata
    {
        public static void Run()
        {
            Console.WriteLine("Running example RemoveAndSaveWithMetadata");

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DICOM();

            ExportWithMetadata(dataDir + "file.dcm", dataDir + "output.dcm", new DicomOptions());
            
            File.Delete(dataDir + "output.dcm");

            Console.WriteLine("Finished example RemoveAndSaveWithMetadata");
        }

        public static void ExportWithMetadata(string inputPath, string outputPath, ImageOptionsBase exportOptions)
        {
            using (var image = Image.Load(inputPath))
            {
                exportOptions.KeepMetadata = true;
                image.Save(outputPath, exportOptions);
            }
        }

        public static void RemoveMetadata(string inputPath, string outputPath, ImageOptionsBase exportOptions)
        {
            using (var image = Image.Load(inputPath))
            {
                image.RemoveMetadata();
                image.Save(outputPath, exportOptions);
            }
        }

        public static void ModifyMetada(string inputPath, string outputPath, ImageOptionsBase exportOptions)
        {
            using (var image = Image.Load(inputPath))
            {
                if (image is IHasExifData hasExif && hasExif.ExifData != null)
                {
                    hasExif.ExifData.UserComment = $"Modified at {DateTime.Now}";
                }

                exportOptions.KeepMetadata = exportOptions is IHasExifData;
                image.Save(outputPath, exportOptions);
            }
        }
    }
}
