
Imports Aspose.Imaging.FileFormats.Bmp
Imports Aspose.Imaging.FileFormats.Psd
Imports Aspose.Imaging.FileFormats.Psd.Resources

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'


Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.PSD
    Class CreateThumbnailsFromPSDFiles
        Public Shared Sub Run()
            ' ExStart:CreateThumbnailsFromPSDFiles
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_PSD()

            ' Load a PSD in an instance of PsdImage
            Using image__1 As PsdImage = DirectCast(Image.Load(dataDir & Convert.ToString("sample.psd")), PsdImage)
                ' Iterate over the PSD resources
                For Each resource In image__1.ImageResources
                    ' Check if the resource is of thumbnail type
                    If TypeOf resource Is ThumbnailResource Then
                        ' Retrieve the ThumbnailResource
                        Dim thumbnail = DirectCast(resource, ThumbnailResource)
                        ' Check the format of the ThumbnailResource
                        If thumbnail.Format = ThumbnailFormat.KJpegRgb Then
                            ' Create a new BmpImage by specifying the width and heigh
                            Dim thumnailImage As New BmpImage(thumbnail.Width, thumbnail.Height)
                            ' Store the pixels of thumbnail on to the newly created BmpImage
                            thumnailImage.SavePixels(thumnailImage.Bounds, thumbnail.ThumbnailData)
                            ' Save thumbnail on disc
                            thumnailImage.Save(dataDir & Convert.ToString("CreateThumbnailsFromPSDFiles_out.bmp"))
                        End If
                    End If
                Next
            End Using
            ' ExEnd:CreateThumbnailsFromPSDFiles
        End Sub
    End Class
End Namespace
