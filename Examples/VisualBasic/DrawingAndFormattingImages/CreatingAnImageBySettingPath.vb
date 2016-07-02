Imports System.IO
Imports Aspose.Imaging.ImageOptions
Imports Aspose.Imaging.Sources

Namespace Aspose.Imaging.Examples.VisualBasic.DrawingAndFormattingImages
    Public Class CreatingAnImageBySettingPath
        Public Shared Sub Run()
            ' ExStart:CreatingAnImageBySettingPath
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_DrawingAndFormattingImages()

            ' Creates an instance of BmpOptions and set its various properties
            Dim ImageOptions As New BmpOptions()
            ImageOptions.BitsPerPixel = 24

            ' Define the source property for the instance of BmpOptions
            ' Second boolean parameter determines if the file is temporal or not
            ImageOptions.Source = New FileCreateSource(dataDir & Convert.ToString("CreatingAnImageBySettingPath_out.bmp"), False)

            ' Creates an instance of Image and call Create method by passing the BmpOptions object
            Using image__1 As Image = Image.Create(ImageOptions, 500, 500)
                image__1.Save(dataDir & Convert.ToString("CreatingAnImageBySettingPath1_out.bmp"))
            End Using
            ' ExEnd:CreatingAnImageBySettingPath
        End Sub
    End Class
End Namespace