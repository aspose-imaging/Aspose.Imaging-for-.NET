// GIST-ID: f111aae5ca0434ec9adef570af085bff
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.ImageFilters.ComplexUtils;
using Aspose.Imaging.ImageFilters.Convolution;
using Aspose.Imaging.ImageFilters.FilterOptions;
using Aspose.Imaging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Imaging.FileFormats.Dicom;

namespace CSharp.ModifyingAndConvertingImages.DICOM
{
    internal class ModifyDicomTags
    {
        public static void Run()
        {
            Console.WriteLine("Running example ModifyDicomTags");

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_DICOM();

            using (DicomImage image = (DicomImage)Image.Load(dataDir + "file.dcm"))
            {
                image.FileInfo.UpdateTagAt(33, "Test Patient"); // Patient's Name
                image.FileInfo.AddTag("Angular View Vector", 234);
                image.FileInfo.RemoveTagAt(29); // Station Name

                image.Save(dataDir + "output.dcm");                
            }

            File.Delete(dataDir + "output.dcm");

            Console.WriteLine("Finished example ModifyDicomTags");
        }
    }
}