Imports System.IO
Imports Aspose.Imaging.ImageOptions
Imports Aspose.Imaging.Sources

Namespace Aspose.Imaging.Examples.VisualBasic.DrawingAndFormattingImages
    Public Class CreatingImageUsingStream
        Public Shared Sub Run()
            ' ExStart:CreatingImageUsingStream
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_DrawingAndFormattingImages()

            ' Creates an instance of BmpOptions and set its various properties
            Dim ImageOptions As New BmpOptions()
            ImageOptions.BitsPerPixel = 24

            ' Create an instance of System.IO.Stream
            Dim stream As Stream = New FileStream(dataDir & Convert.ToString("sample_out.bmp"), FileMode.Create)

            ' Define the source property for the instance of BmpOptions
            ' Second boolean parameter determines if the Stream is disposed once get out of scope
            ImageOptions.Source = New StreamSource(stream, True)

            ' Creates an instance of Image and call Create method by passing the BmpOptions object
            Using image__1 As Image = Image.Create(ImageOptions, 500, 500)
                ' Do some image processing
                image__1.Save(dataDir & Convert.ToString("CreatingImageUsingStream_out.bmp"))
            End Using
            ' ExEnd:CreatingImageUsingStream
        End Sub
    End Class
End Namespace