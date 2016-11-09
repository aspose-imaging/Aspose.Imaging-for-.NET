Imports Aspose.Imaging.FileFormats.Webp
Imports Aspose.Imaging.ImageOptions

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.WebPImages
    Class ExtractFrameFromWebPImage
        Public Shared Sub Run()
            ' ExStart:ExtractFrameFromWebPImage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_WebPImages()

            ' Load an existing WebP image into the instance of WebPImage class.
            Using image As New WebPImage(dataDir & Convert.ToString("asposelogo.webp"))
                If image.Blocks.Length > 2 Then
                    ' Access a particular frame from WebP image and cast it to Raster Image
                    Dim block As RasterImage = TryCast(image.Blocks(2), RasterImage)

                    If block IsNot Nothing Then
                        ' Save the Raster Image to a BMP image.
                        block.Save(dataDir & Convert.ToString("ExtractFrameFromWebPImage.bmp"), New BmpOptions())
                    End If
                End If
            End Using
            ' ExEnd:ExtractFrameFromWebPImage
        End Sub
    End Class
End Namespace
