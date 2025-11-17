// GIST-ID: 43eebf03ec07028adf45b293105b7cd1
using System;
using System.IO;
using Aspose.Imaging;
using Aspose.Imaging.FileFormats.Tiff;
using Aspose.Imaging.FileFormats.Tiff.Enums;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Xmp;
using Aspose.Imaging.Xmp.Schemas.DublinCore;
using Aspose.Imaging.Xmp.Schemas.Photoshop;

/*
This project uses the Automatic Package Restore feature of NuGet to resolve the Aspose.Imaging for .NET API reference
when the project is built. Please check https://learn.microsoft.com/en-us/nuget/resources/nuget-faq for more information.
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from https://releases.aspose.com/,
install it, and then add its reference to this project. For any issues, questions, or suggestions,
please feel free to contact us using https://forum.aspose.com/
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

            // Specify the size of the image by defining a Rectangle.
            Rectangle rect = new Rectangle(0, 0, 100, 200);
            TiffOptions tiffOptions = new TiffOptions(TiffExpectedFormat.TiffJpegRgb);
            tiffOptions.Photometric = TiffPhotometrics.MinIsBlack;
            tiffOptions.BitsPerSample = new ushort[] { 8 };

            // Create a brand‑new image just for sample purposes.
            using (var image = new TiffImage(new TiffFrame(tiffOptions, rect.Width, rect.Height)))
            {
                // Create an instance of XMP header.
                XmpHeaderPi xmpHeader = new XmpHeaderPi(Guid.NewGuid().ToString());

                // Create an instance of XmpTrailerPi and an XmpMeta object to set attributes.
                XmpTrailerPi xmpTrailer = new XmpTrailerPi(true);
                XmpMeta xmpMeta = new XmpMeta();
                xmpMeta.AddAttribute("Author", "Mr Smith");
                xmpMeta.AddAttribute("Description", "The fake metadata value");

                // Create an instance of XmpPacketWrapper that contains all metadata.
                XmpPacketWrapper xmpData = new XmpPacketWrapper(xmpHeader, xmpTrailer, xmpMeta);

                // Create an instance of Photoshop package and set Photoshop attributes.
                PhotoshopPackage photoshopPackage = new PhotoshopPackage();
                photoshopPackage.SetCity("London");
                photoshopPackage.SetCountry("England");
                photoshopPackage.SetColorMode(ColorMode.Rgb);
                photoshopPackage.SetCreatedDate(DateTime.UtcNow);

                // Add Photoshop package into XMP metadata.
                xmpData.AddPackage(photoshopPackage);

                // Create an instance of DublinCore package and set DublinCore attributes.
                DublinCorePackage dublinCorePackage = new DublinCorePackage();
                dublinCorePackage.SetAuthor("Charles Bukowski");
                dublinCorePackage.SetTitle("Confessions of a Man Insane Enough to Live With the Beasts");
                dublinCorePackage.AddValue("dc:movie", "Barfly");

                // Add DublinCore package into XMP metadata.
                xmpData.AddPackage(dublinCorePackage);

                using (var ms = new MemoryStream())
                {
                    // Update XMP metadata into the image and save the image on disk or in the memory stream.
                    image.XmpData = xmpData;
                    image.Save(ms);
                    ms.Seek(0, System.IO.SeekOrigin.Begin);

                    // Load the image from the memory stream or from disk to read/get the metadata.
                    using (var img = (TiffImage)Image.Load(ms))
                    {
                        // Getting the XMP metadata.
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