Imports System.IO

Imports Aspose.Imaging
Imports Aspose.Imaging.Shapes

Namespace Aspose.Imaging.Examples.Images
    Public Class DrawingUsingGraphicsPath
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = Aspose.Imaging.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            'Create an instance of BmpCreateOptions and set its various properties
            'Create an instance of BmpOptions and set its various properties
            Dim ImageOptions As New ImageOptions.BmpOptions()
            ImageOptions.BitsPerPixel = 24

            'Create an instance of FileCreateSource and assign it to Source property
            ImageOptions.Source = New Sources.FileCreateSource(dataDir & "sample.bmp", False)

            'Create an instance of Image 
            Using image As Image = image.Create(ImageOptions, 500, 500)
                'Create and initialize an instance of Graphics
                Dim graphics As New Graphics(image)

                'Clear the image surface with white color
                graphics.Clear(Color.White)

                'Create an instance of GraphicsPath
                Dim graphicspath As New GraphicsPath()

                'Create an instance of Figure
                Dim figure As New Figure()

                'Add EllipseShape to the figure by defining boundary Rectangle
                figure.AddShape(New EllipseShape(New RectangleF(0, 0, 499, 499)))

                'Add RectangleShape to the figure
                figure.AddShape(New RectangleShape(New RectangleF(0, 0, 499, 499)))

                'Add TextShape to the figure by defining the boundary Rectangle and Font
                figure.AddShape(New TextShape("Aspose.Imaging", New RectangleF(170, 225, 170, 100), New Font("Arial", 20), StringFormat.GenericTypographic))

                'Add figures to the GraphicsPath object
                graphicspath.AddFigures(New Figure() {figure})

                'Draw Path
                graphics.DrawPath(New Pen(Color.Blue), graphicspath)

                'Create an instance of HatchBrush and set its properties
                Dim hatchbrush As New Brushes.HatchBrush()
                hatchbrush.BackgroundColor = Color.Brown
                hatchbrush.ForegroundColor = Color.Blue
                hatchbrush.HatchStyle = HatchStyle.Vertical

                'Fill path by supplying the brush and GraphicsPath objects
                graphics.FillPath(hatchbrush, graphicspath)

                ' Save the changes.
                image.Save()

                ' Display Status.
                System.Console.WriteLine("Processing completed successfully.")
            End Using
        End Sub
    End Class
End Namespace