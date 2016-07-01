
Imports Aspose.Imaging.ImageOptions

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'


Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.WebPImages
    Class ExportToWebP
        Public Shared Sub Run()
            ' ExStart:ExportToWebP
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_WebPImages()

            ' Create an instance of image class.
            Using image__1 As Image = Image.Load(dataDir & Convert.ToString("SampleImage1.bmp"))
                ' Create an instance of WebPOptions class
                Dim options As New WebPOptions()

                ' Set Quality
                options.Quality = 50

                ' Set LossLess property
                options.Lossless = False

                ' Save the image in WebP format.
                image__1.Save(dataDir & Convert.ToString("ExportToWebP_out.webp"), options)
            End Using
            ' ExEnd:ExportToWebP
        End Sub
    End Class
End Namespace