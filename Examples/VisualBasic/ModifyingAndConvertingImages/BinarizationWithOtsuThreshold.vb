Imports Aspose.Imaging.ImageFilters.FilterOptions

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages
    Class BinarizationWithOtsuThreshold
        Public Shared Sub Run()
            ' ExStart:BinarizationWithOtsuThreshold
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingAndConvertingImages()

            ' Load an image in an instance of Image
            Using image__1 As Image = Image.Load(dataDir & Convert.ToString("aspose-logo.jpg"))
                ' Cast the image to RasterCachedImage and  Check if image is cached
                Dim rasterCachedImage As RasterCachedImage = DirectCast(image__1, RasterCachedImage)
                If Not rasterCachedImage.IsCached Then
                    ' Cache image if not already cached
                    rasterCachedImage.CacheData()
                End If
                ' Binarize image with Otsu Thresholding and Save the resultant image
                rasterCachedImage.BinarizeOtsu()
                rasterCachedImage.Save(dataDir & Convert.ToString("BinarizationWithOtsuThreshold_out.jpg"))
            End Using
            ' ExEnd:BinarizationWithOtsuThreshold
        End Sub
    End Class
End Namespace