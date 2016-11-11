Imports Aspose.Imaging.FileFormats.Gif
Imports Aspose.Imaging.FileFormats.Gif.Blocks
Imports Aspose.Imaging.FileFormats.Tiff.Enums
Imports Aspose.Imaging.ImageOptions

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages
    Class ConvertGIFImageLayersToTIFF
        Public Shared Sub Run()
            ' ExStart:ConvertGIFImageLayersToTIFF
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingAndConvertingImages()

            ' Load a GIF image
            Dim objImage As Image = Image.Load(dataDir & Convert.ToString("asposelogo.gif"))

            ' Convert the image to GIF image and Iterate through arry of blocks in the GIF image
            Using gif As GifImage = DirectCast(objImage, GifImage)
                For i As Integer = 0 To gif.Blocks.Length - 1
                    ' Convert block to GifFrameBlock class instance
                    Dim gifBlock As GifFrameBlock = TryCast(gif.Blocks(i), GifFrameBlock)

                    ' Check if gif block is then ignore it
                    If gifBlock Is Nothing Then
                        Continue For
                    End If

                    ' Create an instance of TIFF Option class and Save the GIFF block as TIFF image
                    Dim objTiff As New TiffOptions(TiffExpectedFormat.[Default])
                    gifBlock.Save(dataDir & "asposelogo-" & i & "_out.tif", objTiff)
                Next
            End Using
            ' ExEnd:ConvertGIFImageLayersToTIFF
        End Sub
    End Class
End Namespace
