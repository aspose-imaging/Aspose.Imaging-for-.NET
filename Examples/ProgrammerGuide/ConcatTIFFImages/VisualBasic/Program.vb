'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Imaging. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////
Imports System.IO

Imports Aspose.Imaging
Imports Aspose.Imaging.FileFormats.Tiff

Namespace ConcatTIFFImages
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Create a copy of original image to avoid any alteration
			File.Copy(dataDir & "demo.tif", dataDir & "TestDemo.tif", True)

			'Create an instance of TiffImage and load the copied destination image
			Using image As TiffImage = CType(Aspose.Imaging.Image.Load(dataDir & "TestDemo.tif"), TiffImage)
				'Create an instance of TiffImage and load the source image
				Using image1 As TiffImage = CType(Aspose.Imaging.Image.Load(dataDir & "sample.tif"), TiffImage)
					' Create an instance of TIffFrame and copy active frame of source image
					Dim frame As TiffFrame = TiffFrame.CopyFrame(image1.ActiveFrame)

					' Add copied frame to destination image
					image.AddFrame(frame)

					' save the image with changes.
					image.Save()
				End Using
			End Using

			' Display Status.
			System.Console.WriteLine("Concatenation of TIF files done successfully.")
		End Sub
	End Class
End Namespace