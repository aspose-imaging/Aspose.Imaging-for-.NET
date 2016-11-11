Imports Aspose.Imaging

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.JPEG
    Class CroppingByRectangle
        Public Shared Sub Run()
            ' ExStart:CroppingByRectangle
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_JPEG()

            ' Load an existing image into an instance of RasterImage class
            Using rasterImage As RasterImage = DirectCast(Image.Load(dataDir & Convert.ToString("aspose-logo.jpg")), RasterImage)
                If Not rasterImage.IsCached Then
                    rasterImage.CacheData()
                End If

                ' Create an instance of Rectangle class with desired size
                Dim rectangle As New Rectangle(20, 20, 20, 20)

                ' Perform the crop operation on object of Rectangle class and Save the results to disk
                rasterImage.Crop(rectangle)
                rasterImage.Save(dataDir & Convert.ToString("CroppingByRectangle_out.jpg"))
            End Using
            ' ExEnd:CroppingByRectangle
        End Sub
    End Class
End Namespace