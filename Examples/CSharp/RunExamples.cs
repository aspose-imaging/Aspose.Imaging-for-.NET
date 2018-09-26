using System;
using System.IO;
using Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages;
using Aspose.Imaging.Examples.CSharp.DrawingAndFormattingImages;
using Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.DICOM;
using Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.DjVu;
using Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.JPEG;
using Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.MetaFiles;
using Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.PNG;
using Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.PSD;
using Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages.WebPImages;
using CSharp.ModifyingAndConvertingImages;
using CSharp.DrawingAndFormattingImages;
using CSharp.ModifyingAndConvertingImages.PSD;
using CSharp.ModifyingAndConvertingImages.SVG;

namespace Aspose.Imaging.Examples.CSharp
{
    class RunExamples
    {
        static void Main()
        {
            Console.WriteLine("Open RunExamples.cs. \nIn Main() method uncomment the example that you want to run.");
            Console.WriteLine("=====================================================");

			// Uncomment the one you want to try out

			//// =====================================================
			//// =====================================================
			////            Drawing And Formatting Images
			//// =====================================================
			//// =====================================================

			//DrawingUsingGraphics.Run();
			//DrawingUsingGraphicsPath.Run();
			//DrawingRectangle.Run();
			//DrawingArc.Run();
			//DrawingEllipse.Run();
			//DrawingBezier.Run();
			//CombineImages.Run();
			//DrawingLines.Run();
			//CreatingAnImageBySettingPath.Run();
			//CreatingImageUsingStream.Run();
			//DrawImagesUsingCoreFunctionality.Run();
			//Imagetransparency.Run();
			//InterruptMonitorSupport.Run();
			//// =====================================================
			//// =====================================================
			////            Modifying And Converting Images
			//// =====================================================
			//// =====================================================

			//AddWatermarkToImage.Run();
			//AddFramesToTIFFImage.Run();
			//AdjustBrightness.Run();
			//AdjustContrast.Run();
			//AdjustGamma.Run();
			//PNGtoPDF.Run();
			//BMPToPDF.Run();
			//SupportForJPEG.Run();
			//ReadingPixelVaules.Run();
			//RasterImageToPDF.Run();
			//SupportForEPSFormat.Run();
			//ConvertEMFToWMF.Run();
			//AlignHorizontalAndVeticalResolutionsOfImage.Run();
			//ApplyGaussWienerFilter.Run();
			//ApplyGaussWienerFilterForColoredImage.Run();
			//ApplyingMotionWienerFilter.Run();
			//ApplyMedianAndWienerFilters.Run();
			//BinarizationWithFixedThreshold.Run();
			//BinarizationWithOtsuThreshold.Run();
			//BlurAnImage.Run();
			//Bradleythreshold.Run();
			//ConvertingSVGToRasterImages.Run();
			//CompressingTIFFImagesWithAdobeDeflateCompression.Run();
			//CompressingTIFFImagesWithLZWAlgorithm.Run();
			//ConcatTIFFImages.Run();
			//ConcatenatingTIFFImagesfromStream.Run();
			//ConcatenateTiffImagesHavingSeveralFrames.Run();
			//ConvertGIFImageLayersToTIFF.Run();
			//CreatingTIFFImageWithCompression.Run();
			//CreateWMFMetaFileImage.Run();
			//ConvertWMFMetaFileToSVG.Run();
			//DitheringRasterImages.Run();
			//ExpandOrCropAnImage.Run();
			//ExtractTIFFFramesToBMPImageFormat.Run();
			//ExportImageToDifferentFormats.Run();
			//ExportImageToPSD.Run();
			//ExportPsdLayersToImages.Run();
			//Grayscaling.Run();
			//ReadAndWriteXMPDataToImages.Run();
			//ResizeImageWithResizeTypeEnumeration.Run();
			//ResizingWithResizeTypeEnumeration.Run();
			//RotatingImageOnSpecificAngle.Run();
			//SavingEachFrameInOtherRasterImageFormat.Run();
			//SavingRasterImageToTIFFWithCompression.Run();
			//SimpleResizeImageProportionally.Run();
			//SimpleResizing.Run();
			//SplittingTiffFrames.Run();
			//TiffDataRecovery.Run();
			//TiffOptionsConfiguration.Run();
			//ControllCacheReallocation.Run();
			//AddDiagonalWatermarkToImage.Run();
			//ColorConversionUsingICCProfiles.Run();
			//ColorConversionUsingDefaultProfiles.Run();
			//AddSignatureToImage.Run();
			//ExportTextAsShape.Run();
			//CreateEMFMetaFileImage.Run();
			//ResizeWMFFile.Run();
			//ConvertWMFToWebp.Run();
			//ConvertWMFToPNG.Run();
			//ConvertWMFToPDF.Run();
			//GetLastModifiedDate.Run();
			//SupportTiffDeflate.Run();
			//ConvertImageWithGrayscale.Run();
			//// =====================================================
			//// =====================================================
			////                        DICOM
			//// =====================================================
			//// =====================================================

			//AdjustBrightnessDICOM.Run();
			//AdjustContrastDICOM.Run();
			//AdjustGammaDICOM.Run();
			//ApplyFilterOnDICOMImage.Run();
			//BinarizationWithFixedThresholdOnDICOMImage.Run();
			//BinarizationWithOtsuThresholdOnDICOMImage.Run();
			//BinarizationWithBradleysAdaptiveThreshold.Run();
			//DICOMSimpleResizing.Run();
			//DitheringForDICOMImage.Run();
			//DICOMSOtherImageResizingOptions.Run();
			//FlipDICOMImage.Run();
			//GrayscalingOnDICOM.Run();
			//RotatingDICOMImage.Run();

			//// =====================================================
			//// =====================================================
			////                        JPEG
			//// =====================================================
			//// =====================================================

			//AddThumbnailToEXIFSegment.Run();
			//AddThumbnailToJFIFSegment.Run();
			//AutoCorrectOrientationOfJPEGImages.Run();
			//CroppingByRectangle.Run();
			//CroppingByShifts.Run();
			//ReadAllEXIFTags.Run();
			//ReadAndModifyJpegEXIFTags.Run();
			//ReadJpegEXIFTags.Run();
			//ReadSpecificEXIFTagsInformation.Run();
			//RotatingAnImage.Run();
			//WritingAndModifyingEXIFData.Run();


			//// =====================================================
			//// =====================================================
			////                    META FILES
			//// =====================================================
			//// =====================================================

			//ConvertEMFToPDF.Run();
			//CroppingByRectangleEMFImage.Run();
			//CroppingEMFImage.Run();
			//SupportForReplacingMissingFonts.Run();
			SaveEMFtoFile.Run();
            SaveEMFPlustoFile.Run();
            SaveEmfGraphics.Run();

            ///SVG----------
            //ConvOfOtherFormatsToSVG.Run();
			//SVGToEMFConversion.Run();
			//// =====================================================
			//// =====================================================
			////                        PNG
			//// =====================================================
			//// =====================================================

			//ApplyFilterMethod.Run();
			//ChangeBackgroundColor.Run();
			//CompressingFiles.Run();
			//SettingResolution.Run();
			//SpecifyBitDepth.Run();
			//SpecifyTransparency.Run();
			//SpecifyTransparencyUsingRasterImage.Run();

			//// =====================================================
			//// =====================================================
			////                        PSD
			//// =====================================================
			//// =====================================================

			//CreateIndexedPSDFiles.Run();
			//CreateThumbnailsFromPSDFiles.Run();
			//DetectFlattenedPSD.Run();
			//ExportPSDLayerToRasterImage.Run();
			//UpdateTextLayerInPSDFile.Run();
			//MergePSDlayers.Run();
			//UncompressedImageUsingFile.Run();
			//UncompressedImageStreamObject.Run();
			//PSDtoPDF.Run();
			//SupportLayerForPSD.Run();

			ICCProfileExtraction.Run();
            ExtractICCProfileIgnoreICC.Run();
            LockImageLayers.Run();

            //// =====================================================
            //// =====================================================
            ////                        WebPImage
            //// =====================================================
            //// =====================================================

            //ConvertGIFFImageFrame.Run();
            //CreatingWebPImage.Run();
            //ExportToWebP.Run();
            //ExportWebPToOtherImageFormats.Run();
            //ExtractFrameFromWebPImage.Run();

            //// =====================================================
            //// =====================================================
            ////                           DjVu
            //// =====================================================
            //// =====================================================

            //ConvertDjVuToTIFF.Run();
            //ConvertRangeOfDjVuPages.Run();
            //ConvertRangeOfDjVuPagesToSeparateImages.Run();
            //ConvertSpecificPortionOfDjVuPage.Run();
            //ConvertDjVuToPDF.Run();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public static String GetDataDir_Export(string path)
        {
            return Path.GetFullPath(GetDataDir_Data() + "Export/" + path + "/");
        }

        public static String GetDataDir_Files()
        {
            return Path.GetFullPath(GetDataDir_Data() + "Files/");
        }

        public static String GetDataDir_Images(string path)
        {
            return Path.GetFullPath(GetDataDir_Data() + "Images/" + path + "/");
        }

        public static String GetDataDir_PNG()
        {
            return Path.GetFullPath(GetDataDir_Data() + "PNG/");
        }

        public static String GetDataDir_DrawingAndFormattingImages()
        {
            return Path.GetFullPath(GetDataDir_Data() + "DrawingAndFormattingImages/");
        }

        public static String GetDataDir_DICOM()
        {
            return Path.GetFullPath(GetDataDir_Data() + "DICOM/");
        }

        public static String GetDataDir_JPEG()
        {
            return Path.GetFullPath(GetDataDir_Data() + "JPEG/");
        }

        public static String GetDataDir_ModifyingAndConvertingImages()
        {
            return Path.GetFullPath(GetDataDir_Data() + "ModifyingAndConvertingImages/");
        }

        public static String GetDataDir_Cache()
        {
            return Path.GetFullPath(GetDataDir_Data() + "Cache/");
        }

        public static String GetDataDir_MetaFiles()
        {
            return Path.GetFullPath(GetDataDir_Data() + "MetaFiles/");
        }

        public static String GetDataDir_PSD()
        {
            return Path.GetFullPath(GetDataDir_Data() + "PSD/");
        }

        public static String GetDataDir_SVG()
        {
            return Path.GetFullPath(GetDataDir_Data() + "SVG/");
        }
        public static String GetDataDir_WebPImages()
        {
            return Path.GetFullPath(GetDataDir_Data() + "WebPImage/");
        }

        public static String GetDataDir_DjVu()
        {
            return Path.GetFullPath(GetDataDir_Data() + "DjVu/");
        }

        public static string GetDataDir_Data()
        {
            var parent = Directory.GetParent(Directory.GetCurrentDirectory()).Parent;
            string startDirectory = null;
            if (parent != null)
            {
                var directoryInfo = parent.Parent;
                if (directoryInfo != null)
                {
                    startDirectory = directoryInfo.FullName;
                }
            }
            else
            {
                startDirectory = parent.FullName;
            }
            return Path.Combine(startDirectory, "Data\\");
        }
    }
}