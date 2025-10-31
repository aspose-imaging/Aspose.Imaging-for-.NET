using Aspose.Imaging;
using Aspose.Imaging.Examples.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.ModifyingAndConvertingImages.JPEG
{
    class ConvertTIFFToJPEG
    {
        public static void Run() {

            //ExStart:ConvertTIFFToJPEG


            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_JPEG();
            Console.WriteLine("Running example ConvertTIFFToJPEG");

            using (Aspose.Imaging.FileFormats.Tiff.TiffImage tiffImage = (Aspose.Imaging.FileFormats.Tiff.TiffImage)Image.Load(dataDir + "source2.tif"))
            {
                int i = 0;
                foreach (Aspose.Imaging.FileFormats.Tiff.TiffFrame tiffFrame in tiffImage.Frames)
                {
                    Aspose.Imaging.ImageOptions.JpegOptions saveOptions = new Aspose.Imaging.ImageOptions.JpegOptions();
                    saveOptions.ResolutionSettings = new ResolutionSetting(tiffFrame.HorizontalResolution, tiffFrame.VerticalResolution);

                    if (tiffFrame.FrameOptions != null)
                    {
                        // Set the resolution unit explicitly.
                        switch (tiffFrame.FrameOptions.ResolutionUnit)
                        {
                            case Aspose.Imaging.FileFormats.Tiff.Enums.TiffResolutionUnits.None:
                                saveOptions.ResolutionUnit = ResolutionUnit.None;
                                break;

                            case Aspose.Imaging.FileFormats.Tiff.Enums.TiffResolutionUnits.Inch:
                                saveOptions.ResolutionUnit = ResolutionUnit.Inch;
                                break;

                            case Aspose.Imaging.FileFormats.Tiff.Enums.TiffResolutionUnits.Centimeter:
                                saveOptions.ResolutionUnit = ResolutionUnit.Cm;
                                break;

                            default:
                                throw new System.NotSupportedException();
                        }
                    }

                    string fileName = "source2.tif.frame." + (i++) + "." + saveOptions.ResolutionUnit + ".jpg";
                    tiffFrame.Save(dataDir + fileName, saveOptions);
                }
            }

            Console.WriteLine("Finished example ConvertTIFFToJPEG");

            //ExEnd:ConvertTIFFToJPEG

        }
    }
}