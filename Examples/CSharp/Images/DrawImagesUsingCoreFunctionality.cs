//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Imaging. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Imaging;

namespace Aspose.Imaging.Examples.Images
{
    public class DrawImagesUsingCoreFunctionality
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Aspose.Imaging.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            //Create an instance of BmpOptions and set its various properties
            Aspose.Imaging.ImageOptions.BmpOptions ImageOptions = new Aspose.Imaging.ImageOptions.BmpOptions();
            ImageOptions.BitsPerPixel = 24;

            //Create an instance of FileCreateSource and assign it to Source property
            ImageOptions.Source = new Aspose.Imaging.Sources.FileCreateSource(dataDir + "sample.bmp", false);

            //Create an instance of RasterImage
            using (Aspose.Imaging.RasterImage rasterImage = (Aspose.Imaging.RasterImage)Aspose.Imaging.Image.Create(ImageOptions, 500, 500))
            {
                //Get the pixels of the image by specifying the area as image boundary
                Color[] pixels = rasterImage.LoadPixels(rasterImage.Bounds);

                for (int index = 0; index < pixels.Length; index++)
                {
                    //Set the indexed pixel color to yellow
                    pixels[index] = Color.Yellow;
                }

                //Apply the pixel changes to the image
                rasterImage.SavePixels(rasterImage.Bounds, pixels);

                // Save all changes.
                rasterImage.Save();
            }
        }
    }
}