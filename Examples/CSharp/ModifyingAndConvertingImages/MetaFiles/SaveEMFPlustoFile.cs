using System.IO;
using Aspose.Imaging.CoreExceptions;
using Aspose.Imaging.FileFormats.Emf;
using Aspose.Imaging.ImageOptions;


namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.MetaFiles
{
    class SaveEMFPlustoFile
    {
        public static void Run()
        {
            //ExStart:SaveEMFPlustoFile
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_MetaFiles();

            var path = dataDir + "TestEmfPlusFigures.emf";

            using (var image = (MetaImage)Image.Load(path))
            {
                image.Save(path + ".emf", new EmfOptions());
            }
            //ExEnd:SaveEMFPlustoFile
        }
    }
}