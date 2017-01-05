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
            // To get proper output please apply a valid Aspose.Imaging License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx."

            // ExStart: ExportImagesInMultiThreadedEnvironment
            
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            string imageDataPath = "";

            try
            {
                // Path & name of existing image.
                imageDataPath = dataDir + "sample.bmp";

                // Create the stream of the existing image file.   
                using (System.IO.FileStream fileStream = System.IO.File.Create(imageDataPath))
                {

                    // Create an instance of BMP image option class.
                    using (Aspose.Imaging.ImageOptions.BmpOptions bmpOptions = new Aspose.Imaging.ImageOptions.BmpOptions())
                    {
                        bmpOptions.BitsPerPixel = 32;

                        // Set the source property of the imaging option class object.
                        bmpOptions.Source = new Aspose.Imaging.Sources.StreamSource(fileStream);

                        // DO PROCESSING. 
                        // Following is the sample processing on the image. Un-comment to use it.
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
                // Delete the file. This statement is in the final block because in any case this statement should execute to make it sure that resource is properly disposed off.
                System.IO.File.Delete(imageDataPath);
            }


            // ExEnd: ExportImagesInMultiThreadedEnvironment
        }
    }
}
