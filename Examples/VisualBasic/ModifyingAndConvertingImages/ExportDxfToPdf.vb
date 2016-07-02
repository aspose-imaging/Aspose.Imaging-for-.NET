
Imports Aspose.Imaging.ImageOptions

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages
    Class ExportDxfToPdf
        Public Shared Sub Run()
            ' To get proper output please apply a valid Aspose.Imaging License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")

            ' ExStart:ExportDxfToPdf
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingAndConvertingImages()

            Using cadImage As Image = Image.Load(dataDir & Convert.ToString("conic_pyramid.dxf"))
                Dim rasterizationOptions As New CadRasterizationOptions()
                rasterizationOptions.PageWidth = 500
                rasterizationOptions.PageHeight = 500
                rasterizationOptions.TypeOfEntities = TypeOfEntities.Entities3D

                ' RasterizationOptions.ScaleMethod = ScaleType.GrowToFit

                rasterizationOptions.Layouts = {"Model"}
                Dim pdfOptions As New PdfOptions()
                pdfOptions.VectorRasterizationOptions = rasterizationOptions
                cadImage.Save(dataDir & Convert.ToString("_output.pdf"), pdfOptions)
            End Using
            ' ExEnd:ExportDxfToPdf
        End Sub
    End Class
End Namespace
