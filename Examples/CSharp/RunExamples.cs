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
using CSharp.ModifyingAndConvertingImages.SVG;
using CSharp.ModifyingAndConvertingImages.CMX;
using CSharp.ModifyingAndConvertingImages.CDR;
using CSharp.ModifyingAndConvertingImages.MetaFiles;
using CSharp.ModifyingAndConvertingImages.JPEG;
using CSharp.ModifyingAndConvertingImages.DjVu;
using CSharp.ModifyingAndConvertingImages.PNG;
using CSharp.ModifyingAndConvertingImages.WebPImages;
using CSharp.ModifyingAndConvertingImages.OTG;
using CSharp.ModifyingAndConvertingImages.MemoryStrategies;
using CSharp.ModifyingAndConvertingImages.Multipage;
using CSharp.ModifyingAndConvertingImages.Tiff;
using CSharp.ModifyingAndConvertingImages.DICOM;
using CSharp.ModifyingAndConvertingImages.Html5Canvas;
using CSharp.ModifyingAndConvertingImages.Gif;
using CSharp.ModifyingAndConvertingImages.APNG;
using CSharp.ModifyingAndConvertingImages.EPS;
using CSharp.ModifyingAndConvertingImages.TGA;
using CSharp.ModifyingAndConvertingImages.Remove_background;
using CSharp.ModifyingAndConvertingImages.Bmp;
namespace Aspose.Imaging.Examples.CSharp
{
    class RunExamples
    {
        [Flags]
        enum SelectionType
        {            
            DrawingAndFormattingImages = 1,

            ModifyingAndConvertingImages = 2,

            MemoryStrategies = 4,

            AdditionalFeatures = 8,

            TestFileFormats = 16,

            All = DrawingAndFormattingImages | ModifyingAndConvertingImages | MemoryStrategies | AdditionalFeatures
                  | TestFileFormats
        }


        static void Main()
        {
            Console.WriteLine(
                "Please select the features you want to test: \n0 - test all features of Aspose.Imaging, \n1 - Test drawing and formatting images, \n2 - Test modifying and converting images, \n3 - Test of memory strategies\n4 - Test additional Aspose.Imaging features, \n5 - Test file formats");
            Console.WriteLine("=====================================================");

            string key = Console.ReadLine();

            int keyNumber = 0;                        

            if (keyNumber - 1 >= 0)
            {
                keyNumber = (int)Math.Pow(2, keyNumber);
            }

            

            if (!int.TryParse(key, out keyNumber)
                || (!typeof(SelectionType).IsEnumDefined(keyNumber - 1 >= 0 ? keyNumber = (int)Math.Pow(2, keyNumber - 1) : keyNumber = (int)SelectionType.All)))
            {
                throw new ArgumentException("Please enter your choise as number between [0..5]");
            }

            SelectionType selectedValue = (SelectionType)keyNumber;
            
            if ((selectedValue & SelectionType.DrawingAndFormattingImages) == SelectionType.DrawingAndFormattingImages)
            {                
                RunTestDrawingAndFormattingImages();
            }

            if ((selectedValue & SelectionType.ModifyingAndConvertingImages) == SelectionType.ModifyingAndConvertingImages)
            {
                RunTestModifyingAndConvertingImages();
            }

            if ((selectedValue & SelectionType.MemoryStrategies) == SelectionType.MemoryStrategies)
            {
                RunTestMemoryStrategies();
            }

            if ((selectedValue & SelectionType.AdditionalFeatures) == SelectionType.AdditionalFeatures)
            {
                RunTestAdditionalFeatures();
            }

            if ((selectedValue & SelectionType.TestFileFormats) == SelectionType.TestFileFormats)
            {
                RunTestFileFormats();
            }
            
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        /// <summary>
        /// Runs the test file formats.
        /// </summary>
        private static void RunTestFileFormats()
        {
            Console.WriteLine("Running file formats tests:");

            // =====================================================
            // =====================================================
            //                        TGA
            // =====================================================
            // =====================================================

            ConvertToTGA.Run();

            // =====================================================
            // =====================================================
            //                        DICOM
            // =====================================================
            // =====================================================
            DicomCompression.Run();
            DicomToPngExample.Run();
            AdjustBrightnessDICOM.Run();
            AdjustContrastDICOM.Run();
            AdjustGammaDICOM.Run();
            ApplyFilterOnDICOMImage.Run();
            BinarizationWithFixedThresholdOnDICOMImage.Run();
            BinarizationWithOtsuThresholdOnDICOMImage.Run();
            BinarizationWithBradleysAdaptiveThreshold.Run();
            DICOMSimpleResizing.Run();
            DitheringForDICOMImage.Run();
            DICOMSOtherImageResizingOptions.Run();
            FlipDICOMImage.Run();
            GrayscalingOnDICOM.Run();
            RotatingDICOMImage.Run();

            // =====================================================
            // =====================================================
            //                        JPEG
            // =====================================================
            // =====================================================

            AddThumbnailToEXIFSegment.Run();
            AddThumbnailToJFIFSegment.Run();
            AutoCorrectOrientationOfJPEGImages.Run();
            CroppingByRectangle.Run();
            CroppingByShifts.Run();
            ReadAllEXIFTags.Run();
            ReadAndModifyJpegEXIFTags.Run();
            ReadJpegEXIFTags.Run();
            ReadSpecificEXIFTagsInformation.Run();
            RotatingAnImage.Run();
            WritingAndModifyingEXIFData.Run();
            ConvertTIFFToJPEG.Run();

            // =====================================================
            // =====================================================
            //                    META FILES
            // =====================================================
            // =====================================================

            ConvertEMFToPDF.Run();
            CroppingByRectangleEMFImage.Run();
            CroppingEMFImage.Run();
            SupportForReplacingMissingFonts.Run();
            SaveEMFtoFile.Run();
            SaveEMFPlustoFile.Run();
            SaveEmfGraphics.Run();

            // =====================================================
            // =====================================================
            //                       SVG  
            // =====================================================
            // =====================================================

            ConvOfOtherFormatsToSVG.Run();
            SVGToEMFConversion.Run();
            ConvertWMFToSVG.Run();
            SVGToBMPConversion.Run();
            SvgNativeResize.Run();

            // =====================================================
            // =====================================================

            // =====================================================
            // =====================================================
            //                        PNG
            // =====================================================
            // =====================================================

            ApplyFilterMethod.Run();
            ChangeBackgroundColor.Run();
            CompressingFiles.Run();
            SettingResolution.Run();
            SpecifyBitDepth.Run();
            SpecifyTransparency.Run();
            SpecifyTransparencyUsingRasterImage.Run();            

            // =====================================================
            // =====================================================
            //                        PSD
            // =====================================================
            // =====================================================

            CreateIndexedPSDFiles.Run();            

            // =====================================================
            // =====================================================
            //                        WebPImage
            // =====================================================
            // =====================================================

            WebPToPdfExample.Run();
            WebPToGifExample.Run();
            ConvertGIFFImageFrame.Run();
            CreatingWebPImage.Run();
            ExportToWebP.Run();
            ExportWebPToOtherImageFormats.Run();
            ExtractFrameFromWebPImage.Run();
            OpenWebPFile.Run();
            // =====================================================
            // =====================================================
            //                           DjVu
            // =====================================================
            // =====================================================

            ConvertDjVuToTIFF.Run();
            ConvertRangeOfDjVuPages.Run();
            ConvertRangeOfDjVuPagesToSeparateImages.Run();
            ConvertSpecificPortionOfDjVuPage.Run();
            ConvertDjVuToPDF.Run();
            ParallelDJVUImagesProcessingUsingMultithreading.Run();

            // =====================================================
            // =====================================================
            //                           Fodg
            // =====================================================
            // =====================================================

            SupportOfFODG.Run();

            // =====================================================
            // =====================================================
            //                           CMX
            // =====================================================
            // =====================================================

            CmxToTiffExample.Run();
            CmxToPdfExample.Run();
            CMXToPNGConversion.Run();

            // =====================================================
            // =====================================================
            //                           CDR
            // =====================================================
            // =====================================================

            CdrToPdfExmple.Run();
            SupportOfCDR.Run();
            CdrToPsdMultipageExample.Run();
            CdrToPngExample.Run();

            // =====================================================
            // =====================================================
            //                           OTG
            // =====================================================
            // =====================================================

            SupportOfOTG.Run();
        }

        private static void RunTestMemoryStrategies()
        {        
            //// =====================================================
            //// =====================================================
            ////                        Memory Strategies
            //// =====================================================
            //// =====================================================

            Console.WriteLine("Running memory strategies tests:");

            OptimizationStrategyInDicom.Run();
            OptimizationStrategyInWebP.Run();
            OptimizationStrategyInRotate.Run();
            OptimizationStrategyInFilters.Run();
            OptimizationStrategyInDithering.Run();
            OptimizationStrategyInResize.Run();
            OptimizationStrategyInJPEG.Run();
            OptimizationStrategyInDJVU.Run();
            OptimizationStrategyInJPEG2000.Run();
            OptimizationStrategyInTiff.Run();
            //////////////
        }

        /// <summary>
        /// Runs the test modifying and converting images.
        /// </summary>
        private static void RunTestModifyingAndConvertingImages()
        {
            //// =====================================================
            //// =====================================================
            ////            Modifying And Converting Images
            //// =====================================================
            //// =====================================================
            Console.WriteLine("Running modifying and converting images tests:");
            BmpRLE4.Run();
            MultipageFromImages.Run();
            CreateGifUsingAddPage.Run();
            ExportEps.Run();
            CreateGraphicsPathFromPathTiffResourcesAndViceVersa.Run();
            ConvertTo1BitPng.Run();
            ExportAPNGToGif.Run();
            CreateAnimationFromMultipageImage.Run();
            SupportExtractingPathsFromTiff.Run();
            CreateAPNGAnimationFromSinglePageImage.Run();
            CreateAPNGAnimationFromGraphics.Run();
            SupportOfFullFrameGif.Run();
            ExportToHtml5Canvas.Run();
            CompressedVectorFormats.Run();
            ExportTiffBatchMode.Run();
            ExportToDicom.Run();
            CroppingWMFFileWhileConvertingtoPNG.Run();
            ConvertingSVGToRasterImages.Run();
            AddWatermarkToImage.Run();
            AddFramesToTIFFImage.Run();
            AdjustBrightness.Run();
            AdjustContrast.Run();
            AdjustGamma.Run();
            PNGtoPDF.Run();
            BMPToPDF.Run();
            SupportForJPEG.Run();            
            RasterImageToPDF.Run();
            SupportForEPSFormat.Run();            
            AlignHorizontalAndVeticalResolutionsOfImage.Run();
            ApplyGaussWienerFilter.Run();
            ApplyGaussWienerFilterForColoredImage.Run();
            ApplyingMotionWienerFilter.Run();
            ApplyMedianAndWienerFilters.Run();
            BinarizationWithFixedThreshold.Run();
            BinarizationWithOtsuThreshold.Run();
            BlurAnImage.Run();
            Bradleythreshold.Run();
            ConvertingSVGToRasterImages.Run();
            CompressingTIFFImagesWithAdobeDeflateCompression.Run();
            CompressingTIFFImagesWithLZWAlgorithm.Run();
            ConcatTIFFImages.Run();
            ConcatenatingTIFFImagesfromStream.Run();
            ConcatenateTiffImagesHavingSeveralFrames.Run();
            ConvertGIFImageLayersToTIFF.Run();
            CreatingTIFFImageWithCompression.Run();
            CreateWMFMetaFileImage.Run();
            ConvertWMFMetaFileToSVG.Run();
            DitheringRasterImages.Run();
            ExpandOrCropAnImage.Run();
            ExtractTIFFFramesToBMPImageFormat.Run();
            ExportImageToDifferentFormats.Run();
            ExportImageToPSD.Run();
            Grayscaling.Run();
            ReadAndWriteXMPDataToImages.Run();
            ResizeImageWithResizeTypeEnumeration.Run();
            ResizingWithResizeTypeEnumeration.Run();
            RotatingImageOnSpecificAngle.Run();
            SavingEachFrameInOtherRasterImageFormat.Run();
            SavingRasterImageToTIFFWithCompression.Run();
            SimpleResizeImageProportionally.Run();
            SimpleResizing.Run();
            SplittingTiffFrames.Run();
            TiffDataRecovery.Run();
            TiffOptionsConfiguration.Run();
            ControllCacheReallocation.Run();
            AddDiagonalWatermarkToImage.Run();
            ColorConversionUsingICCProfiles.Run();
            ColorConversionUsingDefaultProfiles.Run();
            AddSignatureToImage.Run();
            ExportTextAsShape.Run();
            CreateEMFMetaFileImage.Run();
            ResizeWMFFile.Run();
            ConvertWMFToWebp.Run();
            ConvertWMFToPNG.Run();
            ConvertWMFToPDF.Run();
            GetLastModifiedDate.Run();
            SupportTiffDeflate.Run();
            ConvertImageWithGrayscale.Run();            
            SupportOfDIB.Run();
            SupportOfTextRenderingHint.Run();
            SupportOfSmoothingMode.Run();
            CropWMFFile.Run();
            CropEMFFile.Run();
            SupportOfDPISettingsInPdfOptions.Run();
            CommonMultipageImageExample.Run();
        }

        /// <summary>
        /// Runs the test drawing and formatting images.
        /// </summary>
        private static void RunTestDrawingAndFormattingImages()
        {
            //// =====================================================
            //// =====================================================
            ////            Drawing And Formatting Images
            //// =====================================================
            //// =====================================================

            Console.WriteLine("Running drawing and formatting images tests:");

            DrawingUsingGraphics.Run();
            DrawingUsingGraphicsPath.Run();
            DrawingRectangle.Run();
            DrawingArc.Run();
            DrawingEllipse.Run();
            DrawingBezier.Run();
            CombineImages.Run();
            DrawingLines.Run();
            CreatingAnImageBySettingPath.Run();
            CreatingImageUsingStream.Run();
            DrawImagesUsingCoreFunctionality.Run();
            Imagetransparency.Run();            
            DrawRasterImageOnWMF.Run();
            DrawRasterImageOnEMF.Run();
            DrawRasterImageOnSVG.Run();
            DrawVectorImageToRasterImage.Run();            
        }

        /// <summary>
        /// Runs the test additional features.
        /// </summary>
        private static void RunTestAdditionalFeatures()
        {
            //// =====================================================
            //// =====================================================
            ////                        Deskew
            //// =====================================================
            //// =====================================================

            Console.WriteLine("Running additional features tests:");
            GraphCutAutoMasking.Run();
            Deskew.Run();

            DocumentConvertionProgress.Run();

            ManualImageMasking.Run();
            AutoImageMasking.Run();
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

        public static String GetDataDir_EPS()
        {
            return Path.GetFullPath(GetDataDir_Data() + "Eps/");
        }

        public static String GetDataDir_DrawingAndFormattingImages()
        {
            return Path.GetFullPath(GetDataDir_Data() + "DrawingAndFormattingImages/");
        }

        public static String GetDataDir_DICOM()
        {
            return Path.GetFullPath(GetDataDir_Data() + "DICOM/");
        }

        public static String GetDataDir_TGA()
        {
            return Path.GetFullPath(GetDataDir_Data() + "TGA/");
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

        public static String GetDataDir_APNG()
        {
            return Path.GetFullPath(GetDataDir_Data() + "APNG/");
        }

        public static String GetDataDir_Bmp()
        {
            return Path.GetFullPath(GetDataDir_Data() + "Bmp/");
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
        public static String GetDataDir_CMX()
        {
            return Path.GetFullPath(GetDataDir_Data() + "CMX/");
        }
        
        public static String GetDataDir_CDR()
        {
            return Path.GetFullPath(GetDataDir_Data() + "CDR/");
        }

        public static String GetDataDir_OTG()
        {
            return Path.GetFullPath(GetDataDir_Data() + "OTG/");
        }

        public static String GetDataDir_Tiff()
        {
            return Path.GetFullPath(GetDataDir_Data() + "Tiff/");
        }

        public static String GetDataDir_Multipage()
        {
            return Path.GetFullPath(GetDataDir_Data() + "Multipage/");
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
