Imports Aspose.Imaging.FileFormats.Djvu
Imports Aspose.Imaging.FileFormats.Png
Imports Aspose.Imaging.ImageOptions

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'


Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.DjVu
    Public Class ConvertSpecificPortionOfDjVuPage
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_DjVu()

            ' Load a DjVu image
            Using image__1 As DjvuImage = DirectCast(Image.Load(dataDir & Convert.ToString("Sample.djvu")), DjvuImage)
                ' Create an instance of PngOptions
                Dim exportOptions As New PngOptions()
                ' Set ColorType to Grayscale
                exportOptions.ColorType = PngColorType.Grayscale
                ' Create an instance of Rectangle and specify the portion on DjVu page
                Dim exportArea As New Rectangle(0, 0, 500, 500)
                ' Specify the DjVu page index
                Dim exportPageIndex As Integer = 2
                ' Initialize an instance of DjvuMultiPageOptions
                ' while passing index of DjVu page index and instance of Rectangle covering the area to be exported
                exportOptions.MultiPageOptions = New DjvuMultiPageOptions(exportPageIndex, exportArea)
                ' Save the image
                image__1.Save(dataDir & Convert.ToString("ConvertSpecificPortionOfDjVuPage_out.djvu"), exportOptions)
            End Using
        End Sub
    End Class
End Namespace