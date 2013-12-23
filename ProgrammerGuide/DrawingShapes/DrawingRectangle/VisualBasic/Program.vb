'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Imaging. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Imaging

Namespace DrawingRectangle
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' Create directory if it is not already present.
			Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
			If (Not IsExists) Then
				System.IO.Directory.CreateDirectory(dataDir)
			End If

			'Creates an instance of FileStream
			Using stream As New System.IO.FileStream(dataDir & "outputlines.bmp", System.IO.FileMode.Create)
				'Create an instance of BmpOptions and set its various properties
				Dim saveOptions As New Aspose.Imaging.ImageOptions.BmpOptions()
				saveOptions.BitsPerPixel = 32

				'Set the Source for BmpOptions
				saveOptions.Source = New Aspose.Imaging.Sources.StreamSource(stream)

				'Create an instance of Image
				Using image As Aspose.Imaging.Image = Aspose.Imaging.Image.Create(saveOptions, 100, 100)
					'Create and initialize an instance of Graphics class
					Dim graphic As New Aspose.Imaging.Graphics(image)

					'Clear Graphics surface
					graphic.Clear(Color.Yellow)

					'Draw a rectangle shape by specifying the Pen object having red color and a rectangle structure
					graphic.DrawRectangle(New Pen(Color.Red), New Rectangle(30, 10, 40, 80))

					'Draw a rectangle shape by specifying the Pen object having solid brush with blue color and a rectangle structure
					graphic.DrawRectangle(New Pen(New Aspose.Imaging.Brushes.SolidBrush(Color.Blue)), New Rectangle(10, 30, 80, 40))

					' save all changes.
					image.Save()
				End Using
			End Using

		End Sub
	End Class
End Namespace