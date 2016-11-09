Imports Aspose.Imaging.Brushes

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages

    Public Class CreateWMFMetaFileImage
        Public Shared Sub Run()
            ' WmfRecorderGraphics2D class provides you the frame or canvas to draw shapes on it.  Create an instance of WmfRecorderGraphics2D class. The constructor takes in 2 parameters:  1. Instance of Imaging Rectangle class 2. An integer value for inches
            ' ExStart:CreateWMFMetaFileImage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingAndConvertingImages()

            Dim graphics As New FileFormats.Wmf.Graphics.WmfRecorderGraphics2D(New Aspose.Imaging.Rectangle(0, 0, 100, 100), 96)

            ' Define background color
            graphics.BackgroundColor = Color.WhiteSmoke

            ' Init Create an instance of Imaging Pen class and mention its color.
            Dim pen As New Pen(Color.Blue)

            ' Create an instance of Imaging Brush class and mention its color.
            Dim brush As Brush = New Brushes.SolidBrush(Color.YellowGreen)

            ' Polygon Fill polygon by calling FillPolygon method and passing parameters brush and points.
            graphics.FillPolygon(brush, New Point() {New Point(2, 2), New Point(20, 20), New Point(20, 2)})

            ' Draw a polygon by calling DrawPolygon method and passing parameters pen and points.
            graphics.DrawPolygon(pen, New Point() {New Point(2, 2), New Point(20, 20), New Point(20, 2)})

            ' Ellipse  Create an instance of HatchBrush class set different properties.
            brush = New HatchBrush() With { _
                .HatchStyle = HatchStyle.Cross, _
                .BackgroundColor = Color.White, _
                .ForegroundColor = Aspose.Imaging.Color.Silver _
            }

            ' Fill ellipse by calling FillEllipse method and passing parameters brush and an instance of Imaging Rectangle class.
            graphics.FillEllipse(brush, New Rectangle(25, 2, 20, 20))

            ' Draw an ellipse by calling DrawEllipse method and passing parameters pen and an instance of Imaging Rectangle class.
            graphics.DrawEllipse(pen, New Rectangle(25, 2, 20, 20))

            ' Arc  Define pen style by setting DashStyle value
            pen.DashStyle = DashStyle.Dot

            ' Set color of the pen
            pen.Color = Color.Black

            ' Draw an Arc by calling DrawArc method and passing parameters pen and an instance of Imaging Rectangle class.
            graphics.DrawArc(pen, New Rectangle(50, 2, 20, 20), 0, 180)

            ' CubicBezier
            pen.DashStyle = DashStyle.Solid
            pen.Color = Color.Red

            ' Draw an CubicBezier by calling DrawCubicBezier method and passing parameters pen and points.
            graphics.DrawCubicBezier(pen, New Point(10, 25), New Point(20, 50), New Point(30, 50), New Aspose.Imaging.Point(40, 25))

            ' Image  Create an Instance of Image class.
            Using image__1 As Image = Image.Load(dataDir & Convert.ToString("WaterMark.bmp"))
                ' Cast the instance of image class to RasterImage.
                Dim rasterImage As RasterImage = TryCast(image__1, RasterImage)
                If rasterImage IsNot Nothing Then
                    ' Draw an image by calling DrawImage method and passing parameters rasterimage and point.
                    graphics.DrawImage(rasterImage, New Point(50, 50))
                End If
            End Using

            ' Line Draw a line by calling DrawLine method and passing x,y coordinates of 1st point and same for 2nd point along with color infor as Pen.
            graphics.DrawLine(pen, New Point(2, 98), New Point(2, 50))

            ' Pie Define settings of the brush object.
            brush = New SolidBrush(Color.Green)
            pen.Color = Color.DarkGoldenrod

            ' Fill pie by calling FillPie method and passing parameters brush and an instance of Imaging Rectangle class.
            graphics.FillPie(brush, New Rectangle(2, 38, 20, 20), 0, 45)

            ' Draw pie by calling DrawPie method and passing parameters pen and an instance of Imaging Rectangle class.
            graphics.DrawPie(pen, New Rectangle(2, 38, 20, 20), 0, 45)

            pen.Color = Color.AliceBlue

            ' Polyline Draw Polyline by calling DrawPolyline method and passing parameters pen and points.
            graphics.DrawPolyline(pen, New Point() {New Point(50, 40), New Point(75, 40), New Point(75, 45), New Point(50, 45)})

            ' For having Strings Create an instance of Font class.
            Dim font As New Font("Arial", 16)

            ' Draw String by calling DrawString method and passing parameters string to display, color and X & Y coordinates.
            graphics.DrawString("Aspose", font, Color.Blue, 25, 75)

            ' Call end recording of graphics object and save WMF image by calling Save method.
            Using image__1 As FileFormats.Wmf.WmfImage = graphics.EndRecording()
                image__1.Save(dataDir & Convert.ToString("CreateWMFMetaFileImage.wmf"))
            End Using
            ' ExEnd:CreateWMFMetaFileImage
        End Sub
    End Class
End Namespace