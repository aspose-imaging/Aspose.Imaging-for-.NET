using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Imaging.Exif.Enums;
using Aspose.Imaging.Exif;
using Aspose.Imaging.Metadata;
using Aspose.Imaging.Xmp.Schemas.XmpBaseSchema;
using Aspose.Imaging.Xmp;

namespace CSharp.ModifyingAndConvertingImages
{
    internal class ExtendExifMetadataForRasterImage
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_PNG();

            Console.WriteLine("Running example ExtendExifMetadataForRasterImage");

            //# Signing limitations:
            //#  - The LSB steganography algorithm requires the image to be at least 8 pixels in width and height, with a minimum of 16,384 total pixels.
            //#  - Password must be at least 4 characters long.

            //            var password = "1234";
            //            var filePath = "c:\sunflower.jpg";

            //#################################### Example 1 ###############################
            //# Faster checking method with partial data extraction.                     #
            //# Set detectionThreasholdPercentage value to 75% (default value).          #
            //##############################################################################

            string filePath = Path.Combine(dataDir, @"00020.png");
            string outputPath = filePath + ".edited.png";
            EditSourceImageMetadata(filePath, outputPath);

            Console.WriteLine("Finished example ExtendExifMetadataForRasterImage");
        }

        public static void EditSourceImageMetadata(string inputPath, string outputPath)
        {            
            using (Image image = Image.Load(inputPath))
            {

                if (image.XmpData != null)
                {
                    var newPackage = new XmpBasicPackage();
                    newPackage.AddValue("New key", "New value");

                    image.XmpData.AddPackage(newPackage);
                }

                if (image.ExifData != null)
                {
                    image.ExifData.Orientation = ExifOrientation.RightTop;
                }

                image.Save(outputPath);

                File.Delete(outputPath);
            }
        }

        public static void ExportSourceImageMetadata(string inputPath, string outputPath, ImageOptionsBase outputOptions)
        {
            using (Image inputImage = Image.Load(inputPath))
            {
                // Set KeepMetadata to true to export inputImage metadata profiles, if outputOptions instance does not contain ones.
                outputOptions.KeepMetadata = true;

                inputImage.Save(outputPath, outputOptions);
            }
        }

        public static void OverwriteSourceImageMetadata(string inputPath, string outputPath, ImageOptionsBase outputOptions)
        {
            using (Image image = Image.Load(inputPath))
            {

                var newMetadata = GetNewMetadata();

                // Try to set metadata, if the image format support metadata format type.
                foreach (var metadata in newMetadata)
                {
                    if (outputOptions.TrySetMetadata(metadata))
                    {
                        Console.WriteLine($"{outputOptions.GetType().Name} image supports {metadata.GetType()}");
                    }
                }

                // Or set metadata directly without image and metadata format compatibility check.
                outputOptions.ExifData = Array.Find(newMetadata, m => m is ExifData) as ExifData;
                outputOptions.XmpData = Array.Find(newMetadata, m => m is XmpPacketWrapper) as XmpPacketWrapper;

                image.Save(outputPath, outputOptions);
            }
        }

        public static IImageMetadataFormat[] GetNewMetadata()
        {
            var xmpData = new XmpPacketWrapper();
            var xmpPackage = new XmpBasicPackage();
            xmpPackage.AddValue("User key", "User value");
            xmpData.AddPackage(xmpPackage);

            return new IImageMetadataFormat[]
            {
        xmpData,
        new ExifData
        {
            Orientation = ExifOrientation.RightTop,
        },
            };
        }
    }
}
