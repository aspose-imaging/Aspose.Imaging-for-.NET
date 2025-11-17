// GIST-ID: 66c9eecc56a847b286215fc22d1a8ac0
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.DNG
{
    class ConvertingDNGToJPG
    {
        public static void Run()
        {
            // To get proper output, please apply a valid Aspose.Imaging license. You can purchase a full license
            // or get a 30‑day temporary license from https://www.aspose.com/purchase/default.aspx.

            // ExStart: SyncRootProperty

            // Declare variables to store file paths for input and output images.
            string sourceFiles = "Path_to_source_folder\\Source\\HDR - 3c.dng";
            string destPath = "Path_to_results_folder\\Results\\result.jpg";

            // Create an instance of the Image class and load an existing DNG file.
            // Convert the image to a DngImage object.
            using (Aspose.Imaging.FileFormats.Dng.DngImage image = (Aspose.Imaging.FileFormats.Dng.DngImage)Image.Load(sourceFiles))
            {
                // Create an instance of the JpegOptions class.
                // Convert and save the image to disk in JPEG format.
                image.Save(destPath, new Aspose.Imaging.ImageOptions.JpegOptions());
            }

            // ExEnd: SyncRootProperty
        }
    }
}