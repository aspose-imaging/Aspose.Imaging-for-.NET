Imports Aspose.Imaging

Namespace Aspose.Imaging.Examples.VisualBasic.Export
    Public Class ExportPsdLayersToImages
        Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Export("ExportPsdLayersToImages")

            ' Load an existing image
            Using image As Image = image.Load(dataDir + "sample.psd")

                Dim psdImage As FileFormats.Psd.PsdImage = TryCast(image, FileFormats.Psd.PsdImage)
                Dim pngOptions As ImageOptions.PngOptions = New ImageOptions.PngOptions()
                pngOptions.ColorType = FileFormats.Png.PngColorType.TruecolorWithAlpha

                For i = 0 To psdImage.Layers.Length - 1
                    psdImage.Layers(i).Save(dataDir + "Layer-" + CStr(i) + ".png", pngOptions)
                Next
            End Using

        End Sub
    End Class
End Namespace