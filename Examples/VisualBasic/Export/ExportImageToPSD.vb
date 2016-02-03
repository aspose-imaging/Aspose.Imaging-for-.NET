Imports System.IO

Imports Aspose.Imaging

Namespace Aspose.Imaging.Examples.Export
    Public Class ExportImageToPSD
        Public Shared Sub Main(ByVal args() As String)
            ' The path to the documents directory.
            Dim dataDir As String = Aspose.Imaging.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            'Load an existing image
            Using image As Image = image.Load(dataDir & "sample.bmp")
                'Create an instance of PsdOptions and set it’s various properties
                Dim psdOptions As New ImageOptions.PsdOptions()
                psdOptions.ColorMode = FileFormats.Psd.ColorModes.RGB
                psdOptions.CompressionMethod = FileFormats.Psd.CompressionMethod.RLE
                psdOptions.Version = 4

                'Save image to disk in PSD format
                image.Save(dataDir & "output.psd", psdOptions)

                ' Display Status.
                System.Console.WriteLine("Export to PSD performed successfully.")
            End Using
        End Sub
    End Class
End Namespace