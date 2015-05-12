'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Imaging. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////
Imports System.IO

Imports Aspose.Imaging
Imports Aspose.Imaging.Shapes

Namespace DrawingUsingGraphicsPath
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Create an instance of BmpCreateOptions and set its various properties
			'Create an instance of BmpOptions and set its various properties
			Dim ImageOptions As New Aspose.Imaging.ImageOptions.BmpOptions()
			ImageOptions.BitsPerPixel = 24

			'Create an instance of FileCreateSource and assign it to Source property
			ImageOptions.Source = New Aspose.Imaging.Sources.FileCreateSource(dataDir & "sample.bmp", False)

			'Create an instance of Image 
			Using image As Aspose.Imaging.Image = Aspose.Imaging.Image.Create(ImageOptions, 500, 500)
				'Create and initialize an instance of Graphics
				Dim graphics As New Aspose.Imaging.Graphics(image)

				'Clear the image surface with white color
				graphics.Clear(Aspose.Imaging.Color.White)

				'Create an instance of GraphicsPath
				Dim graphicspath As New Aspose.Imaging.GraphicsPath()

				'Create an instance of Figure
				Dim figure As New Aspose.Imaging.Figure()

				'Add EllipseShape to the figure by defining boundary Rectangle
				figure.AddShape(New EllipseShape(New RectangleF(0, 0, 499, 499)))

				'Add RectangleShape to the figure
				figure.AddShape(New RectangleShape(New RectangleF(0, 0, 499, 499)))

				'Add TextShape to the figure by defining the boundary Rectangle and Font
				figure.AddShape(New TextShape("Aspose.Imaging", New RectangleF(170, 225, 170, 100), New Font("Arial", 20), StringFormat.GenericTypographic))

				'Add figures to the GraphicsPath object
				graphicspath.AddFigures(New Aspose.Imaging.Figure() { figure })

				'Draw Path
				graphics.DrawPath(New Aspose.Imaging.Pen(Aspose.Imaging.Color.Blue), graphicspath)

				'Create an instance of HatchBrush and set its properties
				Dim hatchbrush As New Aspose.Imaging.Brushes.HatchBrush()
				hatchbrush.BackgroundColor = Aspose.Imaging.Color.Brown
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