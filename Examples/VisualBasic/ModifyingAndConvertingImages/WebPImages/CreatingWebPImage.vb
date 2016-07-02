
Imports Aspose.Imaging.FileFormats.Tiff.Enums
Imports Aspose.Imaging.ImageOptions

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'


Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.WebPImages
    Class CreatingWebPImage
        Public Shared Sub Run()
            ' ExStart:CreatingWebPImage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_WebPImages()

            ' Create an instance of WebPOptions class
            Dim imageOptions As New WebPOptions()

            ' Set LossLess property
            imageOptions.Lossless = True

            ' Set Source property with the path and image file name where you want to create the WebP image.
            imageOptions.Source = New Sources.FileCreateSource(dataDir & Convert.ToString("CreatingWebPImage_out.webp"), False)

            ' Create an instance of image class by using WebOptions instance that you have just created.
            Using image__1 As Image = Image.Create(imageOptions, 500, 500)
                ' Save the image.
                image__1.Save()
            End Using
            ' ExEnd:CreatingWebPImage
        End Sub
    End Class
End Namespace