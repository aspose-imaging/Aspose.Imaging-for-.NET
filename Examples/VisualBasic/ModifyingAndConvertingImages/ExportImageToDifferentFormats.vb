Imports Aspose.Imaging.FileFormats.Tiff.Enums
Imports Aspose.Imaging.ImageOptions

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages
    Public Class ExportImageToDifferentFormats
        Public Shared Sub Run()
            ' ExStart:ExportImageToDifferentFormats
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingAndConvertingImages()

            ' Load an existing image (of type Gif) in an instance of the Image class
            Using image__1 As Image = Image.Load(dataDir & Convert.ToString("sample.gif"))
                ' Export to BMP, JPEG, PNG, and TIFF file format using the default options
                image__1.Save(dataDir & Convert.ToString("_output.bmp"), New BmpOptions())
                image__1.Save(dataDir & Convert.ToString("_output.jpeg"), New JpegOptions())
                image__1.Save(dataDir & Convert.ToString("_output.png"), New PngOptions())
                image__1.Save(dataDir & Convert.ToString("_output.tiff"), New TiffOptions(TiffExpectedFormat.[Default]))
            End Using
            ' ExStart:ExportImageToDifferentFormats
        End Sub
    End Class
End Namespace
