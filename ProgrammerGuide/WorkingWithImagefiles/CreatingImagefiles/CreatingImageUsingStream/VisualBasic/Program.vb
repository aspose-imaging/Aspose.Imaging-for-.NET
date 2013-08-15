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

Namespace CreatingImageUsingStream
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' Create directory if it is not already present.
			Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
			If (Not IsExists) Then
				System.IO.Directory.CreateDirectory(dataDir)
			End If

			'Creates an instance of BmpOptions and set its various properties
			Dim ImageOptions As New Aspose.Imaging.ImageOptions.BmpOptions()
			ImageOptions.BitsPerPixel = 24


			'Create an instance of System.IO.Stream
			Dim stream As System.IO.Stream = New System.IO.FileStream(dataDir & "sample.bmp", System.IO.FileMode.Create)


			'Define the source property for the instance of BmpOptions
			'Second boolean parameter determines if the Stream is disposed once get out of scope
			ImageOptions.Source = New Aspose.Imaging.Sources.StreamSource(stream, True)


			'Creates an instance of Image and call Create method by passing the BmpOptions object
			Using image As Aspose.Imaging.Image = Aspose.Imaging.Image.Create(ImageOptions, 500, 500)
				'do some image processing
				image.Save()
			End Using

		End Sub
	End Class
End Namespace