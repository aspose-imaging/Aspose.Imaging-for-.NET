Imports System.IO
Imports Aspose.Imaging.ImageOptions
Imports Aspose.Imaging.Sources

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

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

                ' Set the Source for BmpOptions and create an instance of Image
                saveOptions.Source = New StreamSource(stream)

                ' Create and initialize an instance of Graphics class and clear Graphics surface
                Using image__1 As Image = Image.Create(saveOptions, 100, 100)

                    Dim graphic As New Graphics(image__1)
                    graphic.Clear(Color.Yellow)

                    ' Draw an arc shape by specifying the Pen object having red black color and coordinates, height, width, start & end angles                 
                    Dim width As Integer = 100
                    Dim height As Integer = 200
                    Dim startAngle As Integer = 45
                    Dim sweepAngle As Integer = 270

                    ' Draw arc to screen and Save all changes.
                    graphic.DrawArc(New Pen(Color.Black), 0, 0, width, height, startAngle, sweepAngle)
                    image__1.Save()
                End Using
                stream.Close()
            End Using
        End Sub
    End Class
End Namespace
