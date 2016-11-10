Imports Aspose.Imaging.FileFormats.Djvu
Imports Aspose.Imaging.FileFormats.Tiff.Enums
Imports Aspose.Imaging.ImageOptions

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.DjVu
    Public Class ConvertDjVuToTIFF
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_DjVu()

            ' Load a DjVu image
            Using Djvuimage As DjvuImage = DirectCast(Image.Load(dataDir & Convert.ToString("Sample.djvu")), DjvuImage)

                ' Create an instance of TiffOptions & use preset options for Black n While with Deflate compression
                Dim exportOptions As New TiffOptions(TiffExpectedFormat.TiffDeflateBw)

                ' Initialize the DjvuMultiPageOptions and Call Save method while passing instance of TiffOptions
                exportOptions.MultiPageOptions = New DjvuMultiPageOptions()
                Djvuimage.Save(dataDir & Convert.ToString("ConvertDjVuToTIFFFormat_out.tiff"), exportOptions)
            End Using
        End Sub
    End Class
End Namespace