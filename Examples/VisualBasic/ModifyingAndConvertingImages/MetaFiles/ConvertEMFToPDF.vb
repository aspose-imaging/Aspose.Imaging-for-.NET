Imports System.IO
Imports Aspose.Imaging.CoreExceptions
Imports Aspose.Imaging.FileFormats.Emf
Imports Aspose.Imaging.ImageOptions

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.MetaFiles
    Class ConvertEMFToPDF
        Public Shared Sub Run()
            ' ExStart:ConvertEMFToPDF
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_MetaFiles()

            Dim filePaths As String() = {"Picture1.emf"}

            For Each filePath As String In filePaths
                Dim outPath As String = (dataDir & filePath) + "_out.pdf"

                Using image__1 = DirectCast(Image.Load(dataDir & filePath), EmfImage)
                    Using outputStream As New FileStream(outPath, FileMode.Create)
                        If Not image__1.Header.EmfHeader.Valid Then
                            Throw New ImageLoadException(String.Format("The file {0} is not valid", outPath))
                        End If

                        Dim emfRasterization As New EmfRasterizationOptions()
                        emfRasterization.PageWidth = image__1.Width
                        emfRasterization.PageHeight = image__1.Height
                        emfRasterization.BackgroundColor = Color.WhiteSmoke

                        Dim pdfOptions As New PdfOptions()
                        pdfOptions.VectorRasterizationOptions = emfRasterization

                        image__1.Save(outputStream, pdfOptions)
                    End Using
                End Using
            Next
            ' ExEnd:ConvertEMFToPDF
        End Sub
    End Class
End Namespace