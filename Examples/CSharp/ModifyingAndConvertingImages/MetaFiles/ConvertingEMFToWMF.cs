using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aspose.Imaging;

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.MetaFiles
{
    class ConvertingEMFToWMF
    {
        public static void Run()
        {
            // To get proper output, please apply a valid Aspose.Imaging license. You can purchase a full license or obtain a 30‑day temporary license from https://www.aspose.com/purchase/default.aspx.

            // ExStart: SyncRootProperty

            // List of existing EMF images.
            string path = @"";
            string[] files = new string[] { "TestEmfRotatedText.emf", "TestEmfPlusFigures.emf", "TestEmfBezier.emf" };

            // Loop for each file name.
            foreach (string file in files)
            {

                // Input file name & path.
                string filePath = System.IO.Path.Combine(path, file);

                // Load the EMF image as image and convert it to MetaImage object.
                using (Aspose.Imaging.FileFormats.Emf.MetaImage image = (Aspose.Imaging.FileFormats.Emf.MetaImage)Image.Load(filePath))
                {
                    // Convert the EMF image to WMF image by creating and passing WMF image options class object.
                    image.Save(filePath + "_out.wmf", new Aspose.Imaging.ImageOptions.WmfOptions());
                }
            }

            // ExEnd: SyncRootProperty
        }
    }
}