using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using Aspose.Imaging.FileFormats.Png;
using Aspose.Imaging.FileFormats.Psd;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging;
using System.IO;
using Aspose.Imaging.FileFormats.Tiff.Enums;
using Aspose.Imaging.Sources;

namespace CSharp.ModifyingAndConvertingImages.PSD
{
    class ICCProfileExtraction
    {//ExStart:ICCProfileExtraction
           
        public static void Run()
        {
            //string dir = @"c:\aspose.work\IMAGINGNET\2990\";
            string dataDir = RunExamples.GetDataDir_PSD();

            string sourcePath = dataDir + "gray-d15.psd";
            string outputPath = dataDir + "gray-d15.psd.apply-icc.tif";

            // Save to grayscale TIFF
            TiffOptions saveOptions = new TiffOptions(TiffExpectedFormat.Default);
            saveOptions.Photometric = TiffPhotometrics.MinIsBlack;
            saveOptions.BitsPerSample = new ushort[] { 8 };

            // If the image contains a built-in Gray ICC profile, it is not be applied by default in contrast of the CMYK profile.
            // Enable ICC conversion explicitly.
            LoadOptions loadOptions = new LoadOptions();
            loadOptions.UseIccProfileConversion = true;

            using (PsdImage psdImage = (PsdImage)Image.Load(sourcePath, loadOptions))
            {
                // Embed the gray ICC profile to the output TIFF.
                // The built-in Gray Profile can be read via the PsdImage.GrayColorProfile property.
                saveOptions.IccProfile = ToMemoryStream(psdImage.GrayColorProfile);
                psdImage.Save(outputPath, saveOptions);
            }
        }

        private static MemoryStream ToMemoryStream(StreamSource streamSource)
        {
            Stream srcStream = streamSource.Stream;
            MemoryStream dstStream = new MemoryStream();

            int byteCount;
            byte[] buffer = new byte[1024];
            long pos = srcStream.Position;
            srcStream.Seek(0, System.IO.SeekOrigin.Begin);
            while ((byteCount = srcStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                dstStream.Write(buffer, 0, byteCount);
            }

            srcStream.Seek(pos, System.IO.SeekOrigin.Begin);
            return dstStream;
        }

        //ExEnd:ICCProfileExtraction
    }

}
