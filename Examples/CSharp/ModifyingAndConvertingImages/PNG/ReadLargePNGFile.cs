// GIST-ID: f4f075b3fb10b6e8f919556d1aa0e621
using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.PNG
{
    class ReadLargePNGFile
    {
        public static void Run()
        {
            // ExStart:ReadLargePNGFile

            // Aspose.Imaging.MemoryManagement.Configuration.BufferSizeHint = 50;
            // The path to the document directory.
            string dataDir = RunExamples.GetDataDir_PNG();
            using (var image = Image.Load(dataDir + "halfGigImage.png"))
            {
                image.Save(dataDir + "halfGigImage.jpg", new Aspose.Imaging.ImageOptions.JpegOptions());
            }

            // ExEnd:ReadLargePNGFile
        }
    }
}