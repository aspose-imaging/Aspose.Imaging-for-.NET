using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Jpeg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.JPEG
{
    class JpegSavedQualityEstimation
    {
        public static void Run()
        {
            // ExStart:AddThumbnailToEXIFSegment
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_JPEG();
            Console.WriteLine("Running example JpegSavedQualityEstimation");
            using (JpegImage image = (JpegImage)Image.Load(dataDir + "test.jpg"))
            {
                bool isNotDefaultQuality = image.JpegOptions.Quality != 75;
            }

            Console.WriteLine("Finished example JpegSavedQualityEstimation");
            // ExEnd:AddThumbnailToEXIFSegment
        }
    }
}