Imports Aspose.Imaging.Brushes
Imports Aspose.Imaging.ImageOptions
Imports Aspose.Imaging.Shapes
Imports Aspose.Imaging.Sources

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.DrawingAndFormattingImages
    Public Class DrawingUsingGraphicsPath
        Public Shared Sub Run()
            ' ExStart:DrawingUsingGraphicsPath
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_DrawingAndFormattingImages()

            ' Create an instance of BmpOptions and set its various properties
            Dim ImageOptions As New BmpOptions()
            ImageOptions.BitsPerPixel = 24

            ' Create an instance of FileCreateSource and assign it to Source property
            ImageOptions.Source = New FileCreateSource(dataDir & Convert.ToString("sample_1.bmp"), False)

            ' Create an instance of Image 
            Using image__1 As Image = Image.Create(ImageOptions, 500, 500)
                ' Create and initialize an instance of Graphics
                Dim graphics As New Graphics(image__1)
                graphics.Clear(Color.White)

                ' Create an instance of GraphicsPath and Instance of Figure, add EllipseShape, RectangleShape and TextShape to the figure
                Dim graphicspath As New GraphicsPath()
                Dim figure As New Figure()
                figure.AddShape(New EllipseShape(New RectangleF(0, 0, 499, 499)))
                figure.AddShape(New RectangleShape(New RectangleF(0, 0, 499, 499)))
                figure.AddShape(New TextShape("Aspose.Imaging", New RectangleF(170, 225, 170, 100), New Font("Arial", 20), StringFormat.GenericTypographic))
                graphicspath.AddFigures(New Figure() {figure})
                graphics.DrawPath(New Pen(Color.Blue), graphicspath)

                ' Create an instance of HatchBrush and set its properties
                Dim hatchbrush As New HatchBrush()
                hatchbrush.BackgroundColor = Color.Brown
                hatchbrush.ForegroundColor = Color.Blue
                hatchbrush.HatchStyle = HatchStyle.Vertical

                ' Fill path by supplying the brush and GraphicsPath objects and Save the changes.
                graphics.FillPath(hatchbrush, graphicspath)
                image__1.Save()
            End Using
            ' ExEnd:DrawingUsingGraphicsPath
        End Sub
    End Class
End Namespace