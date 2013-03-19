'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Imaging. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////
Imports System.IO

Imports Aspose.Imaging

Namespace DrawImagesUsingCoreFunctionality
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Create an instance of BmpOptions and set its various properties
			Dim ImageOptions As New Aspose.Imaging.ImageOptions.BmpOptions()
			ImageOptions.BitsPerPixel = 24

			'Create an instance of FileCreateSource and assign it to Source property
			ImageOptions.Source = New Aspose.Imaging.Sources.FileCreateSource(dataDir & "sample.bmp", False)

			'Create an instance of RasterImage
			Using rasterImage As Aspose.Imaging.RasterImage = CType(Aspose.Imaging.Image.Create(ImageOptions, 500, 500), Aspose.Imaging.RasterImage)
				'Get the pixels of the image by specifying the area as image boundary
				Dim pixels() As Color = rasterImage.LoadPixels(rasterImage.Bounds)

				For index As Integer = 0 To pixels.Length - 1
					'Set the indexed pixel color to yellow
					pixels(index) = Color.Yellow
				Next index

				'Apply the pixel changes to the image
				rasterImage.SavePixels(rasterImage.Bounds, pixels)

				' Save all changes.
				rasterImage.Save()
			End Using
		End Sub
	End Class
End Namespace