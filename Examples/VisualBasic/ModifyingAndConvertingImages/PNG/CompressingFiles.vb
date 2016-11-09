Imports Aspose.Imaging.ImageOptions

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.PNG
    Class CompressingFiles
        Public Shared Sub Run()
            ' ExStart:CompressingFiles
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_PNG()

            ' Load an image from file (or stream)
            Using image__1 As Image = Image.Load(dataDir & Convert.ToString("aspose_logo.png"))
                ' Loop over possible CompressionLevel range
                For i As Integer = 0 To 9
                    ' Create an instance of PngOptions for each resultant PNG, Set CompressionLevel and  Save result on disk
                    Dim options As New PngOptions()
                    options.CompressionLevel = i
                    image__1.Save(i & "_out.png", options)
                Next
            End Using
            ' ExEnd:CompressingFiles
        End Sub
    End Class
End Namespace
