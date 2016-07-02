Imports Aspose.Imaging.FileFormats.Png
Imports Aspose.Imaging.FileFormats.Psd
Imports Aspose.Imaging.ImageOptions

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages
    Class ExportPsdLayersToImages
        Public Shared Sub Run()
            ' To get proper output please apply a valid Aspose.Imaging License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")

            ' ExStart:ExportPsdLayersToImages
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingAndConvertingImages()

            ' Load an existing image
            Using image__1 As Image = Image.Load(dataDir & Convert.ToString("samplePsd.psd"))
                Dim psdImage = DirectCast(image__1, PsdImage)
                Dim pngOptions = New PngOptions()
                pngOptions.ColorType = PngColorType.TruecolorWithAlpha

                For i As Integer = 0 To psdImage.Layers.Length - 1
                    psdImage.Layers(i).Save(dataDir & "layer-" & i & "_out.png", pngOptions)
                Next
            End Using
            ' ExEnd:ExportPsdLayersToImages
        End Sub
    End Class
End Namespace
