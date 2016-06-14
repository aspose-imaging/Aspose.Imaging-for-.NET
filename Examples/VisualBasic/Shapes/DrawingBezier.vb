Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Imaging

Namespace Aspose.Imaging.Examples.Shapes
    Public Class DrawingBezier
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = Aspose.Imaging.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' Create directory if it is not already present.
            Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
            If (Not IsExists) Then
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


                    'Draw a Bezier shape by specifying the Pen object having black color and co-ordinate Points
                    graphic.DrawBezier(BlackPen, startX, startY, controlX1, controlY1, controlX2, controlY2, endX, endY)



                    ' save all changes.
                    image.Save()
                End Using
            End Using

        End Sub
    End Class
End Namespace