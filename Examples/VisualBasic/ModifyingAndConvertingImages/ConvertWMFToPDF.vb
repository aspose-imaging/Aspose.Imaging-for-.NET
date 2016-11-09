Imports Aspose.Imaging.ImageOptions

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages
    Public Class ConvertWMFToPDF
        Public Shared Sub Run()
            ' ExStart:ConvertWMFToPDF
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingAndConvertingImages()

            ' Load an existing WMF image
            Using image__1 As Image = Image.Load(dataDir & Convert.ToString("input.wmf"))
                ' Create an instance of EmfRasterizationOptions class and set different properties
                Dim emfRasterizationOptions As New EmfRasterizationOptions()
                emfRasterizationOptions.BackgroundColor = Color.WhiteSmoke
                emfRasterizationOptions.PageWidth = image__1.Width
                emfRasterizationOptions.PageHeight = image__1.Height

                ' Create an instance of PdfOptions class and provide rasterization option
                Dim pdfOptions As New PdfOptions()
                pdfOptions.VectorRasterizationOptions = emfRasterizationOptions

                ' Call the save method, provide output path and PdfOptions to convert the WMF file to PDF and save the output
                image__1.Save(dataDir & Convert.ToString("ConvertWMFToPDF_out.pdf"), pdfOptions)
            End Using
            ' ExEnd:ConvertWMFToPDF
        End Sub
    End Class
End Namespace