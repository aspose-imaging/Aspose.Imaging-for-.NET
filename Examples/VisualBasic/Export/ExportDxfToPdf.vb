Imports Aspose.Imaging
Imports Aspose.Imaging.ImageOptions
Imports Aspose.Imaging.FileFormats.Cad

Namespace Aspose.Imaging.Examples.VisualBasic.Export
    Public Class ExportDxfToPdf
        Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Export("ExportDxfToPdf")

            Using cadImage As CadImage = TryCast(Image.Load(dataDir + "conic_pyramid.dxf"), CadImage)
                Dim rasterizationOptions As CadRasterizationOptions = New CadRasterizationOptions()
                rasterizationOptions.PageWidth = 500
                rasterizationOptions.PageHeight = 500
                rasterizationOptions.TypeOfEntities = TypeOfEntities.Entities3D

                Dim pdfOptions As PdfOptions = New PdfOptions()
                pdfOptions.VectorRasterizationOptions = rasterizationOptions
                cadImage.Save(dataDir + "output.pdf", pdfOptions)
            End Using

        End Sub
    End Class
End Namespace
