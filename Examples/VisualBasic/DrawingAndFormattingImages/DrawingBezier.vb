Imports System.IO
Imports Aspose.Imaging.ImageOptions
Imports Aspose.Imaging.Sources

Namespace Aspose.Imaging.Examples.VisualBasic.DrawingAndFormattingImages
    Public Class DrawingBezier
        Public Shared Sub Run()
            ' ExStart:DrawingBezier
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_DrawingAndFormattingImages()

            ' Creates an instance of FileStream
            Using stream As New FileStream(dataDir & Convert.ToString("DrawingBezier_out.bmp"), FileMode.Create)
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

                    'Initializes the instance of PEN class with black color and width
                    Dim BlackPen As New Pen(Color.Black, 3)

                    Dim startX As Single = 10
                    Dim startY As Single = 25
                    Dim controlX1 As Single = 20
                    Dim controlY1 As Single = 5
                    Dim controlX2 As Single = 55
                    Dim controlY2 As Single = 10
                    Dim endX As Single = 90
                    Dim endY As Single = 25

                    ' Draw a Bezier shape by specifying the Pen object having black color and co-ordinate Points
                    graphic.DrawBezier(BlackPen, startX, startY, controlX1, controlY1, controlX2, _
                        controlY2, endX, endY)

                    ' save all changes.
                    image__1.Save()
                End Using
            End Using
            ' ExEnd:DrawingBezier
        End Sub
    End Class
End Namespace
