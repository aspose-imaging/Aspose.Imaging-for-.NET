
Imports Aspose.Imaging.FileFormats.Gif
Imports Aspose.Imaging.FileFormats.Gif.Blocks
Imports Aspose.Imaging.FileFormats.Webp

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'


Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.WebPImages
    Class ConvertGIFFImageFrame
        Public Shared Sub Run()
            ' ExStart:ConvertGIFFImageFrame
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_WebPImages()

            ' Load GIFF image into the instance of image class.
            Using image__1 As Image = Image.Load(dataDir & Convert.ToString("asposelogo.gif"))
                ' Create an instance of GIFF image class.
                Dim gif As GifImage = TryCast(image__1, GifImage)

                If gif Is Nothing Then
                    Return
                End If

                ' Load an existing WebP image into the instance of WebPImage class.
                Using webp As New WebPImage(image__1.Width, image__1.Height, Nothing)
                    ' Loop through the GIFF frames
                    For i As Integer = 0 To gif.Blocks.Length - 1
                        ' Convert GIFF block to GIFF Frame
                        Dim gifBlock As GifFrameBlock = TryCast(gif.Blocks(i), GifFrameBlock)
                        If gifBlock Is Nothing Then
                            Continue For
                        End If

                        ' Create an instance of WebP Frame instance by passing GIFF frame to class constructor.
                        Dim block As New WebPFrameBlock(gifBlock) With { _
                            .Top = CShort(gifBlock.Top), _
                            .Left = CShort(gifBlock.Left), _
                            .Duration = CShort(gifBlock.ControlBlock.DelayTime) _
                        }

                        ' Add WebP frame to WebP image block list
                        webp.AddBlock(block)
                    Next

                    ' Set Properties of WebP image.
                    webp.Options.AnimBackgroundColor = &HFF
                    ' Black
                    webp.Options.AnimLoopCount = 0
                    'Infinity
                    webp.Options.Quality = 50
                    webp.Options.Lossless = False

                    ' Save WebP image.
                    webp.Save(dataDir & Convert.ToString("ConvertGIFFImageFrame_out.webp"))
                End Using
            End Using
            ' ExEnd:ConvertGIFFImageFrame
        End Sub
    End Class
End Namespace