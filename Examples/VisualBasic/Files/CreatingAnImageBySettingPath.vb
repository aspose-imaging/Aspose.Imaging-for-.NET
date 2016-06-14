Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Imaging

Namespace Aspose.Imaging.Examples.VisualBasic.Files
    Public Class CreatingAnImageBySettingPath
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Files()

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