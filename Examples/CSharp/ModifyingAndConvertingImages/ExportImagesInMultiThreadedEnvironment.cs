using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    class ExportImagesInMultiThreadedEnvironment
    {
        public static void Run()
        {
            // To get proper output, please apply a valid Aspose.Imaging license. You can purchase a full license or obtain a 30‑day temporary license from https://releases.aspose.com/.

            // ExStart: ExportImagesInMultiThreadedEnvironment

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            string imageDataPath = "";

            try
            {
                // Path and name of the existing image.
                imageDataPath = dataDir + "sample.bmp";

                // Create the stream of the existing image file.
                using (System.IO.FileStream fileStream = System.IO.File.Create(imageDataPath))
                {
                    // Create an instance of the BMP image options class.
                    using (Aspose.Imaging.ImageOptions.BmpOptions bmpOptions = new Aspose.Imaging.ImageOptions.BmpOptions())
                    {
                        bmpOptions.BitsPerPixel = 32;

                        // Set the source property of the imaging options class object.
                        bmpOptions.Source = new Aspose.Imaging.Sources.StreamSource(fileStream);

                        // DO PROCESSING.
                        // The following is sample processing on the image. Uncomment to use it.
                        //using (RasterImage image = (RasterImage)Image.Create(bmpOptions, 10, 10))
                        //{
                        //    Color[] pixels = new Color[4];
                        //    for (int i = 0; i < 4; ++i)
                        //    {
                        //        pixels[i] = Color.FromArgb(40, 30, 20, 10);
                        //    }
                        //    image.SavePixels(new Rectangle(0, 0, 2, 2), pixels);
                        //    image.Save();
                        //}
                    }
                }
            }
            finally
            {
                // Delete the file. This statement is in the finally block because it should always execute to ensure that the resource is properly disposed.
                System.IO.File.Delete(imageDataPath);
            }

            // ExEnd: ExportImagesInMultiThreadedEnvironment
        }
    }
}