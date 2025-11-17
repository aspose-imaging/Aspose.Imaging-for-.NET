// GIST-ID: ca8032ae3966b7e2b71369ab8225369b
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging;
using System;

namespace CSharp.ModifyingAndConvertingImages.CDR
{
    internal class SupportTextStylesItalicUnderline
    {
        public static void Run()
        {
            Console.WriteLine("Running example: SupportTextStylesItalicUnderline");

            FontSettings.SetFontsFolder(RunExamples.GetDataDir_Fonts());

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CDR();

            string inputFileName = dataDir + "Test3.cdr";

            using (var image = Image.Load(inputFileName))
            {
                image.Save(inputFileName + ".jpg");
            }

            Console.WriteLine("Finished example: SupportTextStylesItalicUnderline");
        }
    }
}