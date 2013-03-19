'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Imaging. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////
Imports System.IO

Imports Aspose.Imaging

Namespace AddWatermarkToImage
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Create an instance of Image and load an existing image
			Using image As Image = Aspose.Imaging.Image.Load(dataDir & "sample.bmp")
				'Create and initialize an instance of Graphics class
				Dim graphics As New Graphics(image)

				'Creates an instance of Font
				Dim font As New Aspose.Imaging.Font("Times New Roman", 16, FontStyle.Bold)

				'Create an instance of SolidBrush and set its various properties
				Dim brush As New Aspose.Imaging.Brushes.SolidBrush()
				brush.Color = Color.Black
				brush.Opacity = 100

				'Draw a String using the SolidBrush object and Font, at specific Point
				graphics.DrawString("Aspose.Imaging for .Net", font, brush, New PointF(image.Width \ 2, image.Height \ 2))

				' save the image with changes.
				image.Save(dataDir & "out.bmp")

				' Display Status.
				System.Console.WriteLine("Watermark added successfully.")
			End Using
		End Sub
	End Class
End Namespace