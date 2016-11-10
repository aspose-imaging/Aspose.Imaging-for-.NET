Imports Aspose.Imaging.FileFormats.Psd
Imports Aspose.Imaging.ImageOptions

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'
Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.PSD
    Class UncompressedImageUsingFile
        Public Shared Sub Run()
            ' ExStart:UncompressedImageUsingFile
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_PSD()

            ' First convert the image to raw PSD format.
            Using psdImage As PsdImage = DirectCast(Image.Load(dataDir & Convert.ToString("PsdImage.psd")), PsdImage)
                Dim saveOptions As New PsdOptions()
                saveOptions.CompressionMethod = CompressionMethod.Raw
                psdImage.Save(dataDir & Convert.ToString("uncompressed_out.psd"), saveOptions)
            End Using

            ' Now reopen the newly created image.
            Using psdImage As PsdImage = DirectCast(Image.Load(dataDir & Convert.ToString("uncompressed_out.psd")), PsdImage)
                ' Perform graphics operations.
                Dim graphics As New Graphics(psdImage)
            End Using
            ' ExEnd:UncompressedImageUsingFile
        End Sub
    End Class
End Namespace