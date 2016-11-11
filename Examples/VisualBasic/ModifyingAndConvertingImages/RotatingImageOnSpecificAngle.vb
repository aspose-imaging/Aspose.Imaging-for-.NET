Imports Aspose.Imaging

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages
    Class RotatingImageOnSpecificAngle
        Public Shared Sub Run()
            ' ExStart:RotatingImageOnSpecificAngle
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingAndConvertingImages()

            ' Load an image to be rotated in an instance of RasterImage
            Using image__1 As RasterImage = DirectCast(Image.Load(dataDir & Convert.ToString("aspose-logo.jpg")), RasterImage)
                ' Before rotation, the image should be cached for better performance
                If Not image__1.IsCached Then
                    image__1.CacheData()
                End If

                ' Perform the rotation on 20 degree while keeping the image size proportional with red background color and  Save the result to a new file
                image__1.Rotate(20.0F, True, Color.Red)
                image__1.Save(dataDir & Convert.ToString("RotatingImageOnSpecificAngle_out.jpg"))
            End Using

            ' ExEnd:RotatingImageOnSpecificAngle
        End Sub
    End Class
End Namespace