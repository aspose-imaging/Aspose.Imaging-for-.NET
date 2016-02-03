Imports System.IO

Imports Aspose.Imaging

Namespace Aspose.Imaging.Examples.Shapes
    Public Class DrawingArc
        Public Shared Sub Main(ByVal args() As String)
            ' The path to the documents directory.
            Dim dataDir As String = Aspose.Imaging.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' Create directory if it is not already present.
            Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
            If Not IsExists Then
                System.IO.Directory.CreateDirectory(dataDir)
            End If

            'Creates an instance of FileStream
            Using stream As New System.IO.FileStream(dataDir & "outputarc.bmp", System.IO.FileMode.Create)
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

                    'Draw an arc shape by specifying the Pen object having red black color and coordinates, height, width, start & end angles
                    Dim x As Integer = 0
                    Dim y As Integer = 0
                    Dim width As Integer = 100
                    Dim height As Integer = 200
                    Dim startAngle As Integer = 45
                    Dim sweepAngle As Integer = 270

                    ' Draw arc to screen.
                    graphic.DrawArc(New Pen(Color.Black), 0, 0, width, height, startAngle, sweepAngle)

                    ' save all changes.
                    image.Save()
                End Using

                stream.Close()
            End Using

        End Sub
    End Class
End Namespace