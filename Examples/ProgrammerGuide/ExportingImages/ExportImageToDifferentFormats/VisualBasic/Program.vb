'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Imaging. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////
Imports System.IO

Imports Aspose.Imaging

Namespace ExportImageToDifferentFormats
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Load an existing image (of type Gif) in an instance of the Image class
			Using image As Aspose.Imaging.Image = Aspose.Imaging.Image.Load(dataDir & "sample.gif")
				'Export to BMP file format using the default options
				image.Save(dataDir & "output.bmp", New Aspose.Imaging.ImageOptions.BmpOptions())

				'Export to JPEG file format using the default options
				image.Save(dataDir & "output.jpeg", New Aspose.Imaging.ImageOptions.JpegOptions())

				'Export to PNG file format using the default options
				image.Save(dataDir & "output.png", New Aspose.Imaging.ImageOptions.PngOptions())

				'Export to TIFF file format using the default options
				image.Save(dataDir & "output.tiff", New Aspose.Imaging.ImageOptions.TiffOptions())
			End Using

			' Display Status.
			System.Console.WriteLine("Conversion performed successfully.")
		End Sub
	End Class
End Namespace