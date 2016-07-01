
Imports Aspose.Imaging.ImageFilters.FilterOptions

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'


Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages
    Class ApplyMedianAndWienerFilters
        Public Shared Sub Run()
            ' To get proper output please apply a valid Aspose.Imaging License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")
            ' ExStart:ApplyMedianAndWienerFilters
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingAndConvertingImages()

            ' Load the noisy image 
            Using image__1 As Image = Image.Load(dataDir & Convert.ToString("asposelogo.gif"))
                ' caste the image into RasterImage
                Dim rasterImage As RasterImage = TryCast(image__1, RasterImage)

                If rasterImage Is Nothing Then
                    Return
                End If

                ' Create an instance of MedianFilterOptions class and set the size.
                Dim options As New MedianFilterOptions(4)

                ' Apply MedianFilterOptions filter to RasterImage object.
                rasterImage.Filter(image__1.Bounds, options)

                ' Save the resultant image
                image__1.Save(dataDir & Convert.ToString("median_test_denoise_out.gif"))
            End Using
        End Sub
    End Class
    ' ExEnd:ApplyMedianAndWienerFilters
End Namespace