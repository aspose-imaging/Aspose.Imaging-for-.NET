Imports Aspose.Imaging

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages
    Public Class GetLastModifiedDate
        Public Shared Sub Run()
            ' ExStart:GetLastModifiedDate
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingAndConvertingImages()

            Using image__1 As RasterImage = DirectCast(Image.Load(dataDir & Convert.ToString("aspose-logo.jpg")), RasterImage)
                ' Gets the date from [FileInfo]
                Dim modifyDate As String = image__1.GetModifyDate(True).ToString()
                Console.WriteLine("Last modify date using [FileInfo]: {0}", modifyDate)

                ' Gets the date from XMP metadata of [FileInfo] as long as it's not default case
                modifyDate = image__1.GetModifyDate(False).ToString()
                Console.WriteLine("Last modify date using info from [FileInfo] and XMP metadata: {0}", modifyDate)
            End Using
            ' ExEnd:GetLastModifiedDate
        End Sub
    End Class
End Namespace