
Imports Aspose.Imaging.FileFormats.Jpeg

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'


Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.JPEG
    Class AutoCorrectOrientationOfJPEGImages
        Public Shared Sub Run()
            ' ExStart:ReadAllEXIFTags
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_JPEG()

            ' Load a Jpeg image from file path location or stream
            Using image__1 As JpegImage = DirectCast(Image.Load(dataDir & Convert.ToString("aspose-logo.jpg")), JpegImage)
                ' Perform the automatic rotation on the image depending on the orientation data stored in the EXIF
                image__1.AutoRotate()
                ' Save the result on disc or stream
                image__1.Save(dataDir & Convert.ToString("aspose-logo_out.jpg"))
            End Using
        End Sub
        ' ExEnd:ReadAllEXIFTags
    End Class
End Namespace
