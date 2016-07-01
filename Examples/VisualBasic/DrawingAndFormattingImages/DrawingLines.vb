Imports System.IO
Imports Aspose.Imaging.Brushes
Imports Aspose.Imaging.ImageOptions
Imports Aspose.Imaging.Sources

Namespace Aspose.Imaging.Examples.VisualBasic.DrawingAndFormattingImages
    Public Class DrawingLines
        Public Shared Sub Run()
            ' ExStart:DrawingLines
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_DrawingAndFormattingImages() + "SolidLines_out.bmp"

            ' Creates an instance of FileStream
            Using stream As New FileStream(dataDir, FileMode.Create)
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

                    ' Draw two dotted diagonal lines by specifying the Pen object having blue color and co-ordinate Points
                    graphic.DrawLine(New Pen(Color.Blue), 9, 9, 90, 90)
                    graphic.DrawLine(New Pen(Color.Blue), 9, 90, 90, 9)

                    ' Draw a four continuous line by specifying the Pen object having Solid Brush with red color and two point structures
                    graphic.DrawLine(New Pen(New SolidBrush(Color.Red)), New Point(9, 9), New Point(9, 90))
                    graphic.DrawLine(New Pen(New SolidBrush(Color.Aqua)), New Point(9, 90), New Point(90, 90))
                    graphic.DrawLine(New Pen(New SolidBrush(Color.Black)), New Point(90, 90), New Point(90, 9))
                    graphic.DrawLine(New Pen(New SolidBrush(Color.White)), New Point(90, 9), New Point(9, 9))

                    ' Save all changes
                    image__1.Save()
                End Using
            End Using
            ' ExEnd:DrawingLines
        End Sub
    End Class
End Namespace