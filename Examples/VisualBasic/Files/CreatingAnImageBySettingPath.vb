'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Imaging. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Imaging

Namespace Aspose.Imaging.Examples.Files
    Public Class CreatingAnImageBySettingPath
        Public Shared Sub Main(ByVal args() As String)
            ' The path to the documents directory.
            Dim dataDir As String = Aspose.Imaging.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            ' Create directory if it is not already present.
            Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
            If (Not IsExists) Then
                System.IO.Directory.CreateDirectory(dataDir)
            End If

            'Creates an instance of BmpOptions and set its various properties
            Dim ImageOptions As New ImageOptions.BmpOptions()
            ImageOptions.BitsPerPixel = 24


            'Define the source property for the instance of BmpOptions
            'Second boolean parameter determines if the file is temporal or not
            ImageOptions.Source = New Sources.FileCreateSource(dataDir & "output.bmp", False)


            'Creates an instance of Image and call Create method by passing the BmpOptions object
            Using image As Image = image.Create(ImageOptions, 500, 500)
                image.Save()
            End Using


        End Sub
    End Class
End Namespace