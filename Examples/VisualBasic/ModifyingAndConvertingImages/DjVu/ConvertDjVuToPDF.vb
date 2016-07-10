Imports Aspose.Imaging.FileFormats.Djvu
Imports Aspose.Imaging.ImageOptions

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'


Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.DjVu
    Public Class ConvertDjVuToPDF
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_DjVu()

            ' Load a DjVu image
            Using image1 As DjvuImage = DirectCast(Image.Load(dataDir & Convert.ToString("Sample.djvu")), DjvuImage)
                ' Create an instance of PdfOptions
                Dim exportOptions As New PdfOptions()
                ' Initialize the metadata for Pdf document
                exportOptions.PdfDocumentInfo = New Aspose.Imaging.FileFormats.Pdf.PdfDocumentInfo()
                ' Create an instance of IntRange and initialize it with the range of DjVu pages to be exported
                Dim range As New IntRange(0, 5)
                'Export first 5 pages
                ' Initialize an instance of DjvuMultiPageOptions with range of DjVu pages to be exported 
                exportOptions.MultiPageOptions = New DjvuMultiPageOptions(range)
                ' Save the result in PDF format
                image1.Save(dataDir & Convert.ToString("ConvertDjVuToPDFFormat_out.pdf"), exportOptions)
            End Using
        End Sub
    End Class
End Namespace
