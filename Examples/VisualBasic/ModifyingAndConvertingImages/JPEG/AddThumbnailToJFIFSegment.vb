Imports System.IO
Imports Aspose.Imaging.FileFormats.Jpeg

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.JPEG
    Class AddThumbnailToJFIFSegment
        Public Shared Sub Run()
            ' ExStart:AddThumbnailToJFIFSegment
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_JPEG()

            Using stream As New MemoryStream()
                Dim thumbnailImage As New JpegImage(100, 100)
                Dim image As New JpegImage(1000, 1000)
                image.Jfif = New JFIFData()
                image.Jfif.Thumbnail = thumbnailImage
                image.Save((dataDir & DirectCast(stream.ToString(), Object)) + "_out.jpeg")
            End Using
            ' ExEnd:AddThumbnailToJFIFSegment
        End Sub
    End Class
End Namespace
