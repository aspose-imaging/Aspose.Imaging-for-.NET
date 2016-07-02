Imports System.IO
Imports Aspose.Imaging.Brushes
Imports Aspose.Imaging.ImageOptions
Imports Aspose.Imaging.Sources

Namespace Aspose.Imaging.Examples.VisualBasic.DrawingAndFormattingImages
    Public Class DrawingEllipse
        Public Shared Sub Run()
            ' ExStart:DrawingEllipse
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_DrawingAndFormattingImages()

            ' Creates an instance of FileStream
            Using stream As New FileStream(dataDir & Convert.ToString("DrawingEllipse_out.bmp"), FileMode.Create)
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

                    ' Draw a dotted ellipse shape by specifying the Pen object having red color and a surrounding Rectangle
                    graphic.DrawEllipse(New Pen(Color.Red), New Rectangle(30, 10, 40, 80))

                    ' Draw a continuous ellipse shape by specifying the Pen object having solid brush with blue color and a surrounding Rectangle
                    graphic.DrawEllipse(New Pen(New SolidBrush(Color.Blue)), New Rectangle(10, 30, 80, 40))

                    ' save all changes.
                    image__1.Save()
                End Using
                stream.Close()
            End Using
            ' ExEnd:DrawingEllipse
        End Sub
    End Class
End Namespace