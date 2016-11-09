Imports Aspose.Imaging.FileFormats.Png
Imports Aspose.Imaging.FileFormats.Psd
Imports Aspose.Imaging.ImageOptions

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.PSD
    Class ExportPSDLayerToRasterImage
        Public Shared Sub Run()
            ' ExStart:ExportPSDLayerToRasterImage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_PSD()

            ' Create an instance of Image class and load PSD file as image.
            Using image__1 As Image = Image.Load(dataDir & Convert.ToString("samplePsd.psd"))
                ' Cast image object to PSD image
                Dim psdImage = DirectCast(image__1, PsdImage)

                ' Create an instance of PngOptions class
                Dim pngOptions = New PngOptions()
                pngOptions.ColorType = PngColorType.TruecolorWithAlpha

                ' Loop through the list of layers
                For i As Integer = 0 To psdImage.Layers.Length - 1
                    ' Convert and save the layer to PNG file format.
                    psdImage.Layers(i).Save(String.Format("layer_out{0}.png", i + 1), pngOptions)
                Next
            End Using
            ' ExEnd:ExportPSDLayerToRasterImage
        End Sub
    End Class
End Namespace