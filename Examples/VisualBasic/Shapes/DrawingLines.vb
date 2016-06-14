Imports System.IO

Imports Aspose.Imaging

Namespace Aspose.Imaging.Examples.Shapes
    Public Class DrawingLines
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = Aspose.Imaging.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' Create directory if it is not already present.
            Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
            If Not IsExists Then
                System.IO.Directory.CreateDirectory(dataDir)
            End If

            'Creates an instance of FileStream
            Using stream As New System.IO.FileStream(dataDir & "outputlines.bmp", System.IO.FileMode.Create)
                'Create an instance of BmpOptions and set its various properties
                Dim saveOptions As New ImageOptions.BmpOptions()
                saveOptions.BitsPerPixel = 32

                'Set the Source for BmpOptions
                saveOptions.Source = New Sources.StreamSource(stream)

                'Create an instance of Image
                Using image As Image = image.Create(saveOptions, 100, 100)
                    'Create and initialize an instance of Graphics class
                    Dim graphic As New Graphics(image)

                    'Clear Graphics surface
                    graphic.Clear(Color.Yellow)

                    'Draw two dotted diagonal lines by specifying the Pen object having blue color and co-ordinate Points
                    graphic.DrawLine(New Pen(Color.Blue), 9, 9, 90, 90)
                    graphic.DrawLine(New Pen(Color.Blue), 9, 90, 90, 9)

                    'Draw a continuous line by specifying the Pen object having Solid Brush with red color and two point structures
                    graphic.DrawLine(New Pen(New Brushes.SolidBrush(Color.Red)), New Point(9, 9), New Point(9, 90))

                    'Draw a continuous line by specifying the Pen object having Solid Brush with aqua color and two point structures
                    graphic.DrawLine(New Pen(New Brushes.SolidBrush(Color.Aqua)), New Point(9, 90), New Point(90, 90))

                    'Draw a continuous line by specifying the Pen object having Solid Brush with black color and two point structures
                    graphic.DrawLine(New Pen(New Brushes.SolidBrush(Color.Black)), New Point(90, 90), New Point(90, 9))

                    'Draw a continuous line by specifying the Pen object having Solid Brush with white color and two point structures
                    graphic.DrawLine(New Pen(New Brushes.SolidBrush(Color.White)), New Point(90, 9), New Point(9, 9))


                    ' save all changes.
                    image.Save()
                End Using
            End Using
            Console.ReadKey()
        End Sub
    End Class
End Namespace
