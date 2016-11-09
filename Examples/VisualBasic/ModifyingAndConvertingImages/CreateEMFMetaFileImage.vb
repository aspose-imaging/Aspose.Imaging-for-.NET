Imports Aspose.Imaging.Brushes
Imports Aspose.Imaging.FileFormats.Emf
Imports Aspose.Imaging.FileFormats.Emf.Emf.Consts
Imports Aspose.Imaging.FileFormats.Emf.Graphics
Imports Aspose.Imaging.ImageOptions

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages
    Public Class CreateEMFMetaFileImage
        Public Shared Sub Run()
            ' ExStart:CreateEMFMetaFileImage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingAndConvertingImages()

            ' EmfRecorderGraphics2D class provides you the frame or canvas to draw shapes on it.
            Dim graphics As New EmfRecorderGraphics2D(New Rectangle(0, 0, 1000, 1000), New Size(1000, 1000), New Size(100, 100))
            If True Then
                ' Create an instance of Imaging Pen class and mention its color.
                Dim pen As New Pen(Color.Bisque)

                ' Draw a line by calling DrawLine method and passing x,y coordinates of 1st point and same for 2nd point along with color infor as Pen.
                graphics.DrawLine(pen, 1, 1, 50, 50)

                ' Reset the Pen color Specify the end style of the line.
                pen = New Pen(Color.BlueViolet, 3)
                pen.EndCap = LineCap.Round

                ' Draw a line by calling DrawLine method and passing x,y coordinates of 1st point and same for 2nd point along with color infor as Pen and end style of line.
                graphics.DrawLine(pen, 15, 5, 50, 60)

                ' Specify the end style of the line.
                pen.EndCap = LineCap.Square
                graphics.DrawLine(pen, 5, 10, 50, 10)
                pen.EndCap = LineCap.Flat

                ' Draw a line by calling DrawLine method and passing parameters.
                graphics.DrawLine(pen, New Point(5, 20), New Point(50, 20))

                ' Create an instance of HatchBrush class to define rectanglurar brush with with different settings.
                Dim hatchBrush As New HatchBrush() With { _
                    .BackgroundColor = Color.AliceBlue, _
                    .ForegroundColor = Color.Red, _
                    .HatchStyle = HatchStyle.Cross _
                }

                ' Draw a line by calling DrawLine method and passing parameters.
                pen = New Pen(hatchBrush, 7)
                graphics.DrawRectangle(pen, 50, 50, 20, 30)

                ' Draw a line by calling DrawLine method and passing parameters with different mode.
                graphics.BackgroundMode = EmfBackgroundMode.OPAQUE
                graphics.DrawLine(pen, 80, 50, 80, 80)

                ' Draw a polygon by calling DrawPolygon method and passing parameters with line join setting/style.
                pen = New Pen(New SolidBrush(Color.Aqua), 3)
                pen.LineJoin = LineJoin.MiterClipped
                graphics.DrawPolygon(pen, {New Point(10, 20), New Point(12, 45), New Point(22, 48), New Point(48, 36), New Point(30, 55)})

                ' Draw a rectangle by calling DrawRectangle method.
                pen.LineJoin = LineJoin.Bevel
                graphics.DrawRectangle(pen, 50, 10, 10, 5)
                pen.LineJoin = LineJoin.Round
                graphics.DrawRectangle(pen, 65, 10, 10, 5)
                pen.LineJoin = LineJoin.Miter
                graphics.DrawRectangle(pen, 80, 10, 10, 5)

                ' Call EndRecording method to produce the final shape. EndRecording method will return the final shape as EmfImage. So create an instance of EmfImage class and initialize it with EmfImage returned by EndRecording method.
                Using image As EmfImage = graphics.EndRecording()
                    ' Create an instance of PdfOptions class.
                    Dim options As New PdfOptions()

                    ' Create an instance of EmfRasterizationOptions class and define different settings.
                    Dim rasterizationOptions As New EmfRasterizationOptions()
                    rasterizationOptions.PageSize = image.Size
                    options.VectorRasterizationOptions = rasterizationOptions
                    Dim outPath As String = dataDir & Convert.ToString("CreateEMFMetaFileImage_out.pdf")
                    image.Save(outPath, options)
                End Using
            End If
            ' ExStart:CreateEMFMetaFileImage
        End Sub
    End Class
End Namespace