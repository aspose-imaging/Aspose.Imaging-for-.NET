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
    class ResizeImageWithResizeTypeEnumeration
    {
        public static void Run()
        {
            Console.WriteLine("Running example ResizeImageWithResizeTypeEnumeration");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Load an image from disk
            using (Image image = Image.Load(dataDir + "aspose-logo.jpg"))
            {
                if (!image.IsCached)
                {
                    image.CacheData();
                }

                // Specifying only height, width and ResizeType
                int newWidth = image.Width / 2;
                image.ResizeWidthProportionally(newWidth, ResizeType.LanczosResample);
                int newHeight = image.Height / 2;
                image.ResizeHeightProportionally(newHeight, ResizeType.NearestNeighbourResample);
                image.Save(dataDir + "ResizeImageWithResizeTypeEnumeration_out.png");
            }

            Console.WriteLine("Finished example ResizeImageWithResizeTypeEnumeration");
        }
    }
}