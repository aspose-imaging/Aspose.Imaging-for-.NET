Imports Aspose.Imaging.Brushes
Imports Aspose.Imaging.ImageOptions
Imports Aspose.Imaging.Sources
Imports Aspose.Imaging

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'


Namespace Aspose.Imaging.Examples.VisualBasic.DrawingAndFormattingImages
    Class DrawingUsingGraphics
        Public Shared Sub Run()
            ' ExStart:DrawingUsingGraphics
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_DrawingAndFormattingImages() + "SampleImage_out.bmp"

            ' Create an instance of BmpOptions and set its various properties
            Dim imageOptions As New BmpOptions()
            imageOptions.BitsPerPixel = 24

            ' Create an instance of FileCreateSource and assign it to Source property
            imageOptions.Source = New FileCreateSource(dataDir, False)

            ' Create an instance of Image
            Using image__1 = Image.Create(imageOptions, 500, 500)
                ' Create and initialize an instance of Graphics
                Dim graphics = New Graphics(image__1)
                ' Clear the image surface with white color
                graphics.Clear(Color.White)
                ' Create and initialize a Pen object with blue color
                Dim pen = New Pen(Color.Blue)

                ' Draw Ellipse by defining the bounding rectangle of width 150 and height 100
                graphics.DrawEllipse(pen, New Rectangle(10, 10, 150, 100))
                ' Draw a polygon using the LinearGradientBrush
                Using linearGradientBrush = New LinearGradientBrush(image__1.Bounds, Color.Red, Color.White, 45.0F)
                    graphics.FillPolygon(linearGradientBrush, {New Point(200, 200), New Point(400, 200), New Point(250, 350)})
                End Using
                image__1.Save()
            End Using
            ' ExEnd:DrawingUsingGraphics
        End Sub
    End Class
End Namespace