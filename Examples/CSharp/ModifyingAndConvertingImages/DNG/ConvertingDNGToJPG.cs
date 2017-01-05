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
            // To get proper output please apply a valid Aspose.Imaging License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx."

            // ExStart: SyncRootProperty

            //Declare variables to store file paths for input and output images.
            string sourceFiles = "Path_to_source_folder\\Source\\HDR - 3c.dng";
            string destPath = "Path_to_results_folder\\Results\\result.jpg";

            // Create an instance of Image class and load an exiting DNG file.
            // Convert the image to DngImage object.
            using (Aspose.Imaging.FileFormats.Dng.DngImage image = (Aspose.Imaging.FileFormats.Dng.DngImage)Image.Load(sourceFiles))
            {

                // Create an instance of JpegOptions class.
                // convert and save to disk in Jpeg file format.
                image.Save(destPath, new Aspose.Imaging.ImageOptions.JpegOptions());
            }

            // ExEnd: SyncRootProperty
        }
    }
}
