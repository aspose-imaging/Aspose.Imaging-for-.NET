Imports System.IO
Imports Aspose.Imaging.Examples.VisualBasic.DrawingAndFormattingImages
Imports Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages
Imports Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.DICOM
Imports Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.DjVu
Imports Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.JPEG
Imports Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.MetaFiles
Imports Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.PNG
Imports Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.PSD
Imports Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.WebPImages

Namespace Aspose.Imaging.Examples.VisualBasic
    Class RunExamples
        Public Shared Sub Main()

            Console.WriteLine("Open RunExamples.vb. " & vbLf & "In Main() method uncomment the example that you want to run.")
            Console.WriteLine("=====================================================")

            ' Uncomment the one you want to try out

            ' =====================================================
            ' =====================================================
            ' Drawing And Formatting Images
            ' =====================================================
            ' =====================================================

            'DrawingUsingGraphics.Run()
            'DrawingUsingGraphicsPath.Run()
            'DrawingRectangle.Run()
            'DrawingArc.Run()
            'DrawingEllipse.Run()
            'DrawingBezier.Run()
            'CombineImages.Run()
            'DrawingLines.Run()
            'CreatingAnImageBySettingPath.Run()
            'CreatingImageUsingStream.Run()
            'DrawImagesUsingCoreFunctionality.Run()

            ' =====================================================
            ' =====================================================
            ' Modifying And Converting Images
            ' =====================================================
            ' =====================================================

            'AddWatermarkToImage.Run()
            'AddFramesToTIFFImageWithDifferentSettings.Run()
            'AddFramesToTIFFImage.Run()
            'AdjustBrightness.Run()
            'AdjustContrast.Run()
            'AdjustGamma.Run()
            'AlignHorizontalAndVeticalResolutionsOfImage.Run()
            'ApplyGaussWienerFilter.Run()
            'ApplyGaussWienerFilterForColoredImage.Run()
            'ApplyMedianAndWienerFilters.Run()
            'ApplyingMotionWienerFilter.Run()
            'BinarizationWithFixedThreshold.Run()
            'BinarizationWithOtsuThreshold.Run()
            'BlurAnImage.Run()
            'Bradleythreshold.Run()
            'ConvertingSVGToRasterImages.Run()
            'CompressingTIFFImagesWithAdobeDeflateCompression.Run()
            'ConcatenatingTIFFImagesfromStream.Run()
            'ConcatenateTiffImagesHavingSeveralFrames.Run()
            'CompressingTIFFImagesWithLZWAlgorithm.Run()
            'ConcatTIFFImages.Run()
            'ConvertGIFImageLayersToTIFF.Run()
            'CreatingTIFFImageWithCompression.Run()
            'DitheringRasterImages.Run()
            'ExpandOrCropAnImage.Run()
            'ExtractTIFFFramesToBMPImageFormat.Run()
            'ExportDxfToPdf.Run()
            'ExportImageToDifferentFormats.Run()
            'ExportImageToPSD.Run()
            'ExportPsdLayersToImages.Run()
            'Grayscaling.Run()
            'ReadAndWriteXMPDataToImages.Run()
            'ResizeImageWithResizeTypeEnumeration.Run()
            'ResizingWithResizeTypeEnumeration.Run()
            'RotatingImageOnSpecificAngle.Run()
            'SavingEachFrameInOtherRasterImageFormat.Run()
            'SavingRasterImageToTIFFWithCompression.Run()
            'SimpleResizeImageProportionally.Run()
            'SimpleResizing.Run()
            'SplittingTiffFrames.Run()
            'TiffDataRecovery.Run()
            'TiffOptionsConfiguration.Run()

            ' =====================================================
            ' =====================================================
            ' DICOM
            ' =====================================================
            ' =====================================================

            'AdjustBrightnessDICOM.Run()
            'AdjustContrastDICOM.Run()
            'AdjustGammaDICOM.Run()
            'ApplyFilterOnDICOMImage.Run()
            'BinarizationWithFixedThresholdOnDICOMImage.Run()
            'BinarizationWithOtsuThresholdOnDICOMImage.Run()
            'BinarizationWithBradleysAdaptiveThreshold.Run()
            'DICOMSimpleResizing.Run()
            'DitheringForDICOMImage.Run()
            'DICOMSOtherImageResizingOptions.Run()
            'FlipDICOMImage.Run()
            'GrayscalingOnDICOM.Run()
            'RotatingDICOMImage.Run()

            ' =====================================================
            ' =====================================================
            ' JPEG
            ' =====================================================
            ' =====================================================

            'AddThumbnailToEXIFSegment.Run()
            'AddThumbnailToJFIFSegment.Run()
            'AutoCorrectOrientationOfJPEGImages.Run()
            'CroppingByRectangle.Run()
            'CroppingByShifts.Run()
            'ReadAllEXIFTags.Run()
            'ReadAndModifyJpegEXIFTags.Run()
            'ReadJpegEXIFTags.Run()
            'ReadSpecificEXIFTagsInformation.Run()
            'RotatingAnImage.Run()
            'WritingAndModifyingEXIFData.Run()


            ' =====================================================
            ' =====================================================
            ' META FILES
            ' =====================================================
            ' =====================================================

            'ConvertEMFToPDF.Run()
            'CroppingByRectangleEMFImage.Run()
            'CroppingEMFImage.Run()
            'ExportMetaFileToRasterFormats.Run()
            'SpecifyFontFolder.Run()

            ' =====================================================
            ' =====================================================
            ' PNG
            ' =====================================================
            ' =====================================================

            'ApplyFilterMethod.Run()
            'ChangeBackgroundColor.Run()
            'CompressingFiles.Run()
            'SettingResolution.Run()
            'SpecifyBitDepth.Run()
            'SpecifyTransparency.Run()
            'SpecifyTransparencyUsingRasterImage.Run()

            ' =====================================================
            ' =====================================================
            ' PSD
            ' =====================================================
            ' =====================================================

            'CreateIndexedPSDFiles.Run()
            'CreateThumbnailsFromPSDFiles.Run()
            'DetectFlattenedPSD.Run()
            'ExportPSDLayerToRasterImage.Run()
            'ImportImageToPSDLayer.Run()
            'UpdateTextLayerInPSDFile.Run()
            'MergePSDlayers.Run()

            ' =====================================================
            ' =====================================================
            ' WebPImage
            ' =====================================================
            ' =====================================================

            'ConvertGIFFImageFrame.Run()
            'CreatingWebPImage.Run()
            'ExportToWebP.Run()
            'ExportWebPToOtherImageFormats.Run()
            'ExtractFrameFromWebPImage.Run()

            ' =====================================================
            ' =====================================================
            ' Djvu
            ' =====================================================
            ' =====================================================

            'ConvertDjVuToTIFF.Run()
            'ConvertDjVuToPDF.Run()
            'ConvertRangeOfDjVuPages.Run()
            'ConvertRangeOfDjVuPagesToSeparateImages.Run()
            'ConvertSpecificPortionOfDjVuPage.Run()

            Console.WriteLine("Press any key to continue...")
            Console.ReadKey()
        End Sub

        Public Shared Function GetDataDir_Export(path__1 As String) As [String]
            Return Path.GetFullPath((Convert.ToString(GetDataDir_Data() & Convert.ToString("Export/")) & path__1) + "/")
        End Function

        Public Shared Function GetDataDir_Files() As [String]
            Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("Files/"))
        End Function

        Public Shared Function GetDataDir_Images(path__1 As String) As [String]
            Return Path.GetFullPath((Convert.ToString(GetDataDir_Data() & Convert.ToString("Images/")) & path__1) + "/")
        End Function

        Public Shared Function GetDataDir_PNG() As [String]
            Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("PNG/"))
        End Function

        Public Shared Function GetDataDir_DrawingAndFormattingImages() As [String]
            Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("DrawingAndFormattingImages/"))
        End Function

        Public Shared Function GetDataDir_DICOM() As [String]
            Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("DICOM/"))
        End Function

        Public Shared Function GetDataDir_JPEG() As [String]
            Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("JPEG/"))
        End Function

        Public Shared Function GetDataDir_DjVu() As [String]
            Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("Djvu/"))
        End Function



        Public Shared Function GetDataDir_ModifyingAndConvertingImages() As [String]
            Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("ModifyingAndConvertingImages/"))
        End Function

        Public Shared Function GetDataDir_MetaFiles() As [String]
            Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("MetaFiles/"))
        End Function

        Public Shared Function GetDataDir_PSD() As [String]
            Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("PSD/"))
        End Function

        Public Shared Function GetDataDir_WebPImages() As [String]
            Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("WebPImage/"))
        End Function

        Public Shared Function GetDataDir_Data() As String
            Dim parent = Directory.GetParent(Directory.GetCurrentDirectory()).Parent
            Dim startDirectory As String = Nothing
            If parent IsNot Nothing Then
                Dim directoryInfo = parent.Parent
                If directoryInfo IsNot Nothing Then
                    startDirectory = directoryInfo.FullName
                End If
            Else
                startDirectory = parent.FullName
            End If
            Return Path.Combine(startDirectory, "Data\")
        End Function

    End Class
End Namespace
