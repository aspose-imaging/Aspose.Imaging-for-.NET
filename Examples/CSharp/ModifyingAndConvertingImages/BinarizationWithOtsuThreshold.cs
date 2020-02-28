﻿/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

using System;

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    class BinarizationWithOtsuThreshold
    {
        public static void Run()
        {
            Console.WriteLine("Running example BinarizationWithOtsuThreshold");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Load an image in an instance of Image
            using (Image image = Image.Load(dataDir + "aspose-logo.jpg"))
            {
                // Cast the image to RasterCachedImage and Check if image is cached
                RasterCachedImage rasterCachedImage = (RasterCachedImage)image;
                if (!rasterCachedImage.IsCached)
                {
                    // Cache image if not already cached
                    rasterCachedImage.CacheData();
                }

                // Binarize image with Otsu Thresholding and Save the resultant image                
                rasterCachedImage.BinarizeOtsu();
                rasterCachedImage.Save(dataDir + "BinarizationWithOtsuThreshold_out.jpg");
            }

            Console.WriteLine("Finished example BinarizationWithOtsuThreshold");
        }
    }
}
