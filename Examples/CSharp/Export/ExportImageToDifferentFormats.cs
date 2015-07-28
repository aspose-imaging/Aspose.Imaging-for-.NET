//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Imaging. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Imaging;

namespace Aspose.Imaging.Examples.Export
{
    public class ExportImageToDifferentFormats
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Aspose.Imaging.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            //Load an existing image (of type Gif) in an instance of the Image class
            using (Aspose.Imaging.Image image = Aspose.Imaging.Image.Load(dataDir + "sample.gif"))
            {
                //Export to BMP file format using the default options
                image.Save(dataDir + "output.bmp", new Aspose.Imaging.ImageOptions.BmpOptions());

                //Export to JPEG file format using the default options
                image.Save(dataDir + "output.jpeg", new Aspose.Imaging.ImageOptions.JpegOptions());

                //Export to PNG file format using the default options
                image.Save(dataDir + "output.png", new Aspose.Imaging.ImageOptions.PngOptions());

                //Export to TIFF file format using the default options
                image.Save(dataDir + "output.tiff", new Aspose.Imaging.ImageOptions.TiffOptions());
            }

            // Display Status.
            System.Console.WriteLine("Conversion performed successfully.");
        }
    }
}
