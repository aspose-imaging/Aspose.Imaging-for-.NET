using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Avif;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.AVIF
{
    internal class LoadAvif
    {
        public static void Run()
        {
            // ExStart:LoadAvif
            // Path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AVIF();

            Console.WriteLine("Running example LoadAvif");

            using (var image = (AvifImage)Image.Load(dataDir + "example.avif"))
            {                
            }

            Console.WriteLine("Finished example LoadAvif");
            // ExEnd:LoadAvif
        }
    }
}