using System;
using System.IO;
using Aspose.Imaging.FileFormats.Tiff;
using Aspose.Imaging.FileFormats.Tiff.Enums;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Xmp;
using Aspose.Imaging.Xmp.Schemas.DublinCore;
using Aspose.Imaging.Xmp.Schemas.Photoshop;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    class ReadAndWriteXMPDataToImages
    {
        public static void Run()
        {
            Console.WriteLine("Running example ReadAndWriteXMPDataToImages");
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Specify the size of image by defining a Rectangle 
            Rectangle rect = new Rectangle(0, 0, 100, 200);
            TiffOptions tiffOptions = new TiffOptions(TiffExpectedFormat.TiffJpegRgb);
            tiffOptions.Photometric = TiffPhotometrics.MinIsBlack;
            tiffOptions.BitsPerSample = new ushort[] { 8 };

            // Create the brand new image just for sample purposes
            using (var image = new TiffImage(new TiffFrame(tiffOptions, rect.Width, rect.Height)))
            {
                // Create an instance of XMP-Header
                XmpHeaderPi xmpHeader = new XmpHeaderPi(Guid.NewGuid().ToString());

                // Create an instance of Xmp-TrailerPi, XMPmeta class to set different attributes
                XmpTrailerPi xmpTrailer = new XmpTrailerPi(true);
                XmpMeta xmpMeta = new XmpMeta();
                xmpMeta.AddAttribute("Author", "Mr Smith");
                xmpMeta.AddAttribute("Description", "The fake metadata value");

                // Create an instance of XmpPacketWrapper that contains all metadata
                XmpPacketWrapper xmpData = new XmpPacketWrapper(xmpHeader, xmpTrailer, xmpMeta);

                // Create an instacne of Photoshop package and set photoshop attributes
                PhotoshopPackage photoshopPackage = new PhotoshopPackage();
                photoshopPackage.SetCity("London");
                photoshopPackage.SetCountry("England");
                photoshopPackage.SetColorMode(ColorMode.Rgb);
                photoshopPackage.SetCreatedDate(DateTime.UtcNow);

                // Add photoshop package into XMP metadata
                xmpData.AddPackage(photoshopPackage);

                // Create an instacne of DublinCore package and set dublinCore attributes
                DublinCorePackage dublinCorePackage = new DublinCorePackage();
                dublinCorePackage.SetAuthor("Charles Bukowski");
                dublinCorePackage.SetTitle("Confessions of a Man Insane Enough to Live With the Beasts");
                dublinCorePackage.AddValue("dc:movie", "Barfly");

                // Add dublinCore Package into XMP metadata
                xmpData.AddPackage(dublinCorePackage);

                using (var ms = new MemoryStream())
                {
                    // Update XMP metadata into image and Save image on the disk or in memory stream
                    image.XmpData = xmpData;
                    image.Save(ms);
                    ms.Seek(0, System.IO.SeekOrigin.Begin);

                    // Load the image from moemory stream or from disk to read/get the metadata
                    using (var img = (TiffImage)Image.Load(ms))
                    {
                        // Getting the XMP metadata
                        XmpPacketWrapper imgXmpData = img.XmpData;
                        foreach (XmpPackage package in imgXmpData.Packages)
                        {
                            // Use package data ...
                        }
                    }
                }
            }

            Console.WriteLine("Finished example ReadAndWriteXMPDataToImages");
        }
    }
}