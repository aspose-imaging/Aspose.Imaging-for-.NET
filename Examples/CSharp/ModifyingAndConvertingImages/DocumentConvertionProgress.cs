//-----------------------------------------------------------------------------------------------------------
// <copyright file="DocumentConvertionProgress.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="18.11.2019 21:46:12">
//     Copyright (c) 2001-2012 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Jpeg;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages
{    
    class DocumentConvertionProgress
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            string fileName = "aspose-logo.jpg";
            string output = "aspose-logo.out.jpg";
            string inputFileName = Path.Combine(dataDir, fileName);

            Console.WriteLine("Running example DocumentConvertionProgress");

            // Example of use of separate operation progress event handlers for load/export operations
            using (var image = Image.Load(inputFileName, new LoadOptions { ProgressEventHandler = ProgressCallback }))
            {

                image.Save(
                    Path.Combine(dataDir, "outputFile_Baseline.jpg"),
                    new JpegOptions
                        {
                            CompressionType = JpegCompressionMode.Baseline,
                            Quality = 100,
                            ProgressEventHandler = ExportProgressCallback
                        });                
            }

            Console.WriteLine("Finished example DocumentConvertionProgress");
        }

        internal static void ProgressCallback(Aspose.Imaging.ProgressManagement.ProgressEventHandlerInfo info)
        {
            Console.WriteLine("{0} : {1}/{2}", info.EventType, info.Value, info.MaxValue);
        }

        internal static void ExportProgressCallback(Aspose.Imaging.ProgressManagement.ProgressEventHandlerInfo info)
        {
            Console.WriteLine("Export event {0} : {1}/{2}", info.EventType, info.Value, info.MaxValue);
        }
    }
}
