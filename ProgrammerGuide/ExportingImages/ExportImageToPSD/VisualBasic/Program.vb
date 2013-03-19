'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Imaging. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////
Imports System.IO

Imports Aspose.Imaging

Namespace ExportImageToPSD
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Load an existing image
			Using image As Aspose.Imaging.Image = Aspose.Imaging.Image.Load(dataDir & "sample.bmp")
				'Create an instance of PsdOptions and set it’s various properties
				Dim psdOptions As New Aspose.Imaging.ImageOptions.PsdOptions()
				psdOptions.ColorMode = Aspose.Imaging.FileFormats.Psd.ColorModes.RGB
				psdOptions.CompressionMethod = Aspose.Imaging.FileFormats.Psd.CompressionMethod.RLE
				psdOptions.Version = 4

				'Save image to disk in PSD format
				image.Save(dataDir & "output.psd", psdOptions)

				' Display Status.
				System.Console.WriteLine("Export to PSD performed successfully.")
			End Using
		End Sub
	End Class
End Namespace