using System.IO;
using Aspose.Imaging.CoreExceptions;
using Aspose.Imaging.FileFormats.Emf;
using Aspose.Imaging.ImageOptions;
using System;


namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.MetaFiles
{
    class SaveEMFtoFile
    {
        public static void Run()
        {
            //ExStart:SaveEMFtoFile
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_MetaFiles();

            var path = dataDir+"TestEmfBezier.emf";
            Console.WriteLine("Running example SaveEMFtoFile");

            using (var image = (MetaImage)Image.Load(path))
            {
                image.Save(path + ".emf", new EmfOptions());
            }

            Console.WriteLine("Finished example SaveEMFtoFile");
            //ExEnd:SaveEMFtoFile
        }
    }
}