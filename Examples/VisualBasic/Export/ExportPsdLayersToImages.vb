Imports Aspose.Imaging

Namespace Aspose.Imaging.Examples.Export
    Public Class ExportPsdLayersToImages
        Shared Sub Main()
            ' The path to the documents directory.
            Dim dataDir As String = Aspose.Imaging.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

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