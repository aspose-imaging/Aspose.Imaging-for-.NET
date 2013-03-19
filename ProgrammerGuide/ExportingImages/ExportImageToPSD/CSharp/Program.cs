//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Imaging. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Imaging;

namespace ExportImageToPSD
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //Load an existing image
            using (Aspose.Imaging.Image image = Aspose.Imaging.Image.Load(dataDir + "sample.bmp"))
            {
                //Create an instance of PsdOptions and set it’s various properties
                Aspose.Imaging.ImageOptions.PsdOptions psdOptions = new Aspose.Imaging.ImageOptions.PsdOptions();
                psdOptions.ColorMode = Aspose.Imaging.FileFormats.Psd.ColorModes.RGB;
                psdOptions.CompressionMethod = Aspose.Imaging.FileFormats.Psd.CompressionMethod.RLE;
                psdOptions.Version = 4;

                //Save image to disk in PSD format
                image.Save(dataDir + "output.psd", psdOptions);

                // Display Status.
                System.Console.WriteLine("Export to PSD performed successfully.");
            }
        }
    }
}