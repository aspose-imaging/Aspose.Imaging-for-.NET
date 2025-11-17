// GIST-ID: 8109bb799f787cba3dde4c105ce609b6
using System.IO;
using Aspose.Imaging.CoreExceptions;
using Aspose.Imaging.FileFormats.Emf;
using Aspose.Imaging.ImageOptions;
using System;

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.MetaFiles
{
    class SaveEMFPlustoFile
    {
        public static void Run()
        {
            // ExStart:SaveEMFPlustoFile
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_MetaFiles();

            var path = dataDir + "TestEmfPlusFigures.emf";

            Console.WriteLine("Running example SaveEMFPlustoFile");
            using (var image = (MetaImage)Image.Load(path))
            {
                image.Save(path + ".emf", new EmfOptions());
            }

            Console.WriteLine("Finished example SaveEMFPlustoFile");
            // ExEnd:SaveEMFPlustoFile
        }
    }
}