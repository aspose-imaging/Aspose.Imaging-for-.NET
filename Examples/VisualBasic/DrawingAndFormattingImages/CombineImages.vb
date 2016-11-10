Imports Aspose.Imaging.ImageOptions
Imports Aspose.Imaging.Sources

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.DrawingAndFormattingImages
    Class CombineImages
        Public Shared Sub Run()
            ' ExStart:CombineImages
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_DrawingAndFormattingImages()

            ' Create an instance of JpegOptions and set its various properties
            Dim imageOptions As New JpegOptions()

            ' Create an instance of FileCreateSource and assign it to Source property
            imageOptions.Source = New FileCreateSource(dataDir & Convert.ToString("Two_images_result_out.bmp"), False)

            ' Create an instance of Image and define canvas size
            Using image__1 = Image.Create(imageOptions, 600, 600)

                ' Create and initialize an instance of Graphics, Clear the image surface with white color and Draw Image
                Dim graphics = New Graphics(image__1)
                graphics.Clear(Color.White)
                graphics.DrawImage(Image.Load(dataDir & Convert.ToString("sample_1.bmp")), 0, 0, 600, 300)
                graphics.DrawImage(Image.Load(dataDir & Convert.ToString("File1.bmp")), 0, 300, 600, 300)
                image__1.Save()
            End Using
            ' ExEnd:CombineImages
        End Sub
    End Class
End Namespace