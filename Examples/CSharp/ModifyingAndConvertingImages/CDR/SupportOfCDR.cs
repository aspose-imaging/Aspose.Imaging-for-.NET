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
        public static void Run() {

            //ExStart:SupportOfCDR
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CDR();

            string inputFileName = dataDir + "test.cdr";
            FileFormat expectedFileFormat = FileFormat.Cdr;
            using (Image image = Image.Load(inputFileName))
            {
                if (expectedFileFormat != image.FileFormat)
                {
                    throw new Exception("Image FileFormat is not {expectedFileFormat}");
                }
            }


            //ExEnd:SupportOfCDR

        }
    }
}
