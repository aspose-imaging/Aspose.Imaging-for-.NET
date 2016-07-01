
Imports System.IO
Imports Aspose.Imaging.ImageOptions
Imports Aspose.Imaging.Sources

Namespace Aspose.Imaging.Examples.VisualBasic.DrawingAndFormattingImages
    Public Class DrawingArc
        Public Shared Sub Run()
            ' ExStart:DrawingBezier
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_DrawingAndFormattingImages()

            ' Creates an instance of FileStream
            Using stream As New FileStream(dataDir & Convert.ToString("DrawingArc_out.bmp"), FileMode.Create)
                ' Create an instance of BmpOptions and set its various properties
                Dim saveOptions As New BmpOptions()
                saveOptions.BitsPerPixel = 32

                ' Set the Source for BmpOptions
                saveOptions.Source = New StreamSource(stream)

                ' Create an instance of Image
                Using image__1 As Image = Image.Create(saveOptions, 100, 100)
                    ' Create and initialize an instance of Graphics class
                    Dim graphic As New Graphics(image__1)

                    ' Clear Graphics surface
                    graphic.Clear(Color.Yellow)

                    ' Draw an arc shape by specifying the Pen object having red black color and coordinates, height, width, start & end angles                 
                    Dim width As Integer = 100
                    Dim height As Integer = 200
                    Dim startAngle As Integer = 45
                    Dim sweepAngle As Integer = 270

                    ' Draw arc to screen.
                    graphic.DrawArc(New Pen(Color.Black), 0, 0, width, height, startAngle, _
                        sweepAngle)

                    ' save all changes.
                    image__1.Save()
                End Using
                stream.Close()
            End Using
        End Sub
    End Class
End Namespace
