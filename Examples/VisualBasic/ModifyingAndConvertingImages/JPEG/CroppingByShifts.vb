'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'


Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.JPEG
    Class CroppingByShifts
        Public Shared Sub Run()
            ' ExStart:CroppingByShifts
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_JPEG()

            ' Load an existing image into an instance of RasterImage class
            Using rasterImage As RasterImage = DirectCast(Image.Load(dataDir & Convert.ToString("aspose-logo.jpg")), RasterImage)
                ' Before cropping, the image should be cached for better performance
                If Not rasterImage.IsCached Then
                    rasterImage.CacheData()
                End If

                ' Define shift values for all four sides
                Dim leftShift As Integer = 10
                Dim rightShift As Integer = 10
                Dim topShift As Integer = 10
                Dim bottomShift As Integer = 10

                ' Based on the shift values, apply the cropping on image
                ' Crop method will shift the image bounds toward the center of image
                rasterImage.Crop(leftShift, rightShift, topShift, bottomShift)

                ' Save the results to disk
                rasterImage.Save(dataDir & Convert.ToString("CroppingByShifts_out.jpg"))
            End Using
        End Sub
        ' ExEnd:CroppingByShifts
    End Class
End Namespace
