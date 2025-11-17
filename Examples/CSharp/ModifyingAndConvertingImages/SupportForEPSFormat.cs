// GIST-ID: 59e7675976f0979d9bf07cd19009ab22
using Aspose.Imaging;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.FileFormats.Eps;
using Aspose.Imaging.FileFormats.Eps.Consts;
using Aspose.Imaging.Examples.CSharp;
using System;
using System.Collections.Generic;
using System.IO;

namespace CSharp.ModifyingAndConvertingImages
{
    public class SupportForEPSFormat
    {
        public static void Run()
        {
            Console.WriteLine("Running example SupportForEPSFormat");
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            var epsPreviewFiles = new List<string>();

            using (var image = Image.Load(dataDir + "sample.eps") as EpsImage)
            {
                foreach (var preview in image.GetPreviewImages())
                {
                    var previewPath = Path.Combine(dataDir, "output." + preview.FileFormat.ToString().ToLower());
                    preview.Save(previewPath);

                    epsPreviewFiles.Add(previewPath);
                }
            }

            epsPreviewFiles.ForEach(File.Delete);            

            Console.WriteLine("Finished example SupportForEPSFormat");
        }
    }
}