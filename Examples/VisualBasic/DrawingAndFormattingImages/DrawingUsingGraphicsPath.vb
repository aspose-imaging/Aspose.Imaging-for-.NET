
Imports Aspose.Imaging.Brushes
Imports Aspose.Imaging.ImageOptions
Imports Aspose.Imaging.Shapes
Imports Aspose.Imaging.Sources

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

                ' Clear the image surface with white color
                graphics.Clear(Color.White)

                ' Create an instance of GraphicsPath
                Dim graphicspath As New GraphicsPath()

                ' Create an instance of Figure
                Dim figure As New Figure()

                ' Add EllipseShape to the figure by defining boundary Rectangle
                figure.AddShape(New EllipseShape(New RectangleF(0, 0, 499, 499)))

                ' Add RectangleShape to the figure
                figure.AddShape(New RectangleShape(New RectangleF(0, 0, 499, 499)))

                ' Add TextShape to the figure by defining the boundary Rectangle and Font
                figure.AddShape(New TextShape("Aspose.Imaging", New RectangleF(170, 225, 170, 100), New Font("Arial", 20), StringFormat.GenericTypographic))

                ' Add figures to the GraphicsPath object
                graphicspath.AddFigures(New Figure() {figure})

                ' Draw Path
                graphics.DrawPath(New Pen(Color.Blue), graphicspath)

                ' Create an instance of HatchBrush and set its properties
                Dim hatchbrush As New HatchBrush()
                hatchbrush.BackgroundColor = Color.Brown
                hatchbrush.ForegroundColor = Color.Blue
                hatchbrush.HatchStyle = HatchStyle.Vertical

                ' Fill path by supplying the brush and GraphicsPath objects
                graphics.FillPath(hatchbrush, graphicspath)

                ' Save the changes.
                image__1.Save()

                ' Display Status.
                Console.WriteLine("Processing completed successfully.")
            End Using
            ' ExEnd:DrawingUsingGraphicsPath
        End Sub
    End Class
End Namespace