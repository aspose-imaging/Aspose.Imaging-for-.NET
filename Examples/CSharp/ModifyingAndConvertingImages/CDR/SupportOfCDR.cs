// GIST-ID: 6552eb1def0bbeb2302e3817026d2c37
using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.ModifyingAndConvertingImages.CDR
{
    class SupportOfCDR
    {
        public static void Run()
        {
            Console.WriteLine("Running example SupportOfCDR");
            // Path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CDR();

            string inputFileName = dataDir + "test.cdr";
            FileFormat expectedFileFormat = FileFormat.Cdr;
            using (Image image = Image.Load(inputFileName))
            {
                if (expectedFileFormat != image.FileFormat)
                {
                    throw new Exception($"Image FileFormat is not {expectedFileFormat}");
                }
            }

            Console.WriteLine("Finished example SupportOfCDR");
        }
    }
}