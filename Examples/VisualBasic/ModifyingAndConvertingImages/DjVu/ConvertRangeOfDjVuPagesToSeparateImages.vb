Imports Aspose.Imaging.FileFormats.Djvu
Imports Aspose.Imaging.ImageOptions

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.DjVu
    Public Class ConvertRangeOfDjVuPagesToSeparateImages
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_DjVu()

            ' Load a DjVu image
            Using image__1 As DjvuImage = DirectCast(Image.Load(dataDir & Convert.ToString("Sample.djvu")), DjvuImage)
                ' Create an instance of BmpOptions
                Dim exportOptions As New BmpOptions()
                ' Set BitsPerPixel for resultant images
                exportOptions.BitsPerPixel = 32
                ' Create an instance of IntRange and initialize it with range of pages to be exported
                Dim range As New IntRange(0, 2)
                ' Export first 2 pages
                Dim counter As Integer = 0
                For Each i In range.Range
                    ' Save each page in separate file, as BMP do not support layering
                    exportOptions.MultiPageOptions = New DjvuMultiPageOptions(range.GetArrayOneItemFromIndex(counter))
                    image__1.Save(dataDir & String.Format("{0}_out.bmp", System.Math.Max(System.Threading.Interlocked.Increment(counter), counter - 1)), exportOptions)
                Next
            End Using
        End Sub
    End Class
End Namespace