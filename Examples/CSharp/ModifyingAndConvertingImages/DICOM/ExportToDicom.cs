//-----------------------------------------------------------------------------------------------------------
// <copyright file="ExportToDicom.cs" company="Aspose Pty Ltd" author="Samer El-Khatib" date="27.03.2020 10:54:17">
//     Copyright (c) 2001-2012 Aspose Pty Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------

using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.ImageOptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.DICOM
{
    public class ExportToDicom
    {
        public static void Run()
        {
            Console.WriteLine("Running example ExportToDicom");
            string dataDir = RunExamples.GetDataDir_DICOM();
            string fileName = "sample.jpg";
            string inputFileNameSingle = Path.Combine(dataDir, fileName);
            string inputFileNameMultipage = Path.Combine(dataDir, "multipage.tif");
            string outputFileNameSingleDcm = Path.Combine(dataDir, "output.dcm");
            string outputFileNameMultipageDcm = Path.Combine(dataDir, "outputMultipage.dcm");
            
            // The next code sample converts JPEG image to DICOM file format
            using (var image = Image.Load(inputFileNameSingle))
            {
                image.Save(outputFileNameSingleDcm, new DicomOptions());
            }

            // DICOM format supports multipage images. You can convert GIF or TIFF images to DICOM in the same way as JPEG images
            using (var image = Image.Load(inputFileNameMultipage))
            {
                image.Save(outputFileNameMultipageDcm, new DicomOptions());
            }            

            Console.WriteLine("Finished example ExportToDicom");
        }
    }
}
