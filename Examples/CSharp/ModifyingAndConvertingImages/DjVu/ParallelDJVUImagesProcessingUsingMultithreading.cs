using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.DjVu
{
    class ParallelDJVUImagesProcessingUsingMultithreading
    {

        public static void Run() {

            //ExStart:ParallelDJVUImagesProcessingUsingMultithreading

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DjVu();
            string fileName = "Sample.djvu";

            int numThreads = 20;
            var tasks = Enumerable.Range(1, numThreads).Select(
                taskNum =>
                {
                    var inputFile = dataDir + fileName;
                    var outputFile = dataDir + string.Format("{0}_task{1}.png", fileName, taskNum);
                    return Task.Run(
                () =>
                            {
                                using (FileStream fs = File.OpenRead(inputFile))
                                {
                                    using (Image image = Image.Load(fs))
                                    {
                                        image.Save(outputFile, new PngOptions());
                                    }
                                }
                            });
                });
            Task.WaitAll(tasks.ToArray());

            //ExEnd:ParallelDJVUImagesProcessingUsingMultithreading

        }
    }
}
