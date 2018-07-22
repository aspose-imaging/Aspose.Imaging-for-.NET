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
    class ExtractICCProfileIgnoreICC
    {
        //ExStart:ExtractICCProfileIgnoreICC

        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_PSD();

            string sourcePath = dataDir + "gray-d15.psd";
            string outputPath = dataDir + "gray-d15.psd.ignore-icc.tif";

            // Save to grayscale TIFF
            TiffOptions saveOptions = new TiffOptions(TiffExpectedFormat.Default);
            saveOptions.Photometric = TiffPhotometrics.MinIsBlack;
            saveOptions.BitsPerSample = new ushort[] { 8 };

            // Disable the ICC color conversion explicitly to get the original colors without applying a built-in ICC profile.
            LoadOptions loadOptions = new LoadOptions();
            loadOptions.UseIccProfileConversion = false;

            // Or just omit loadOptions because the built-in Gray ICC profile is not applied by default in contrast of the CMYK profile. 
            using (PsdImage psdImage = (PsdImage)Image.Load(sourcePath))
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

        //ExEnd:ExtractICCProfileIgnoreICC
    }

}
