using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using Aspose.Imaging.FileFormats.Dicom;
using Aspose.Imaging.ImageOptions;
using Aspose.Imaging.Xmp;
using Aspose.Imaging.Xmp.Schemas.Dicom;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ModifyingAndConvertingImages.DICOM
{
    class SupportStoringXmpTags
    {
        public static void Run()
        {           
            string dataDir = RunExamples.GetDataDir_DICOM();

            Console.WriteLine("Running example SupportStoringXmpTags");
            
            using (DicomImage image = (DicomImage)Image.Load(dataDir + "file.dcm"))
            {
                XmpPacketWrapper xmpPacketWrapper = new XmpPacketWrapper();
                DicomPackage dicomPackage = new DicomPackage();

                dicomPackage.SetEquipmentInstitution("Test Institution");
                dicomPackage.SetEquipmentManufacturer("Test Manufacturer");
                dicomPackage.SetPatientBirthDate("19010101");
                dicomPackage.SetPatientId("010101");
                dicomPackage.SetPatientName("Test Name");
                dicomPackage.SetPatientSex("M");
                dicomPackage.SetSeriesDateTime("19020202");
                dicomPackage.SetSeriesDescription("Test Series Description");
                dicomPackage.SetSeriesModality("Test Modality");
                dicomPackage.SetSeriesNumber("01");
                dicomPackage.SetStudyDateTime("19030303");
                dicomPackage.SetStudyDescription("Test Study Description");
                dicomPackage.SetStudyId("02");
                dicomPackage.SetStudyPhysician("Test Physician");

                xmpPacketWrapper.AddPackage(dicomPackage);
                string outputFile = dataDir + "output.dcm";

                image.Save(outputFile, new DicomOptions() { XmpData = xmpPacketWrapper });
                
                
                using (DicomImage imageSaved = (DicomImage)Image.Load(outputFile))
                {
                    ReadOnlyCollection<string> originalDicomInfo = image.FileInfo.DicomInfo;
                    ReadOnlyCollection<string> imageSavedDicomInfo = imageSaved.FileInfo.DicomInfo;
                    int tagsCountDiff = Math.Abs(imageSavedDicomInfo.Count - originalDicomInfo.Count);
                }

                File.Delete(outputFile);
            }

            Console.WriteLine("Finished example SupportStoringXmpTags");
        }
    }
}
