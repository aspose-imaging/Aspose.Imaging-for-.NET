Imports System.IO

Imports Aspose.Imaging

Namespace Aspose.Imaging.Examples.Export
    Public Class ExportImageToDifferentFormats
        Public Shared Sub Main(ByVal args() As String)
            ' The path to the documents directory.
            Dim dataDir As String = Aspose.Imaging.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            'Load an existing image (of type Gif) in an instance of the Image class
            Using image As Image = image.Load(dataDir & "sample.gif")
                'Export to BMP file format using the default options
                image.Save(dataDir & "output.bmp", New ImageOptions.BmpOptions())

                'Export to JPEG file format using the default options
                image.Save(dataDir & "output.jpeg", New ImageOptions.JpegOptions())

                'Export to PNG file format using the default options
                image.Save(dataDir & "output.png", New ImageOptions.PngOptions())

                'Export to TIFF file format using the default options
                image.Save(dataDir & "output.tiff", New ImageOptions.TiffOptions(FileFormats.Tiff.Enums.TiffExpectedFormat.Default))
            End Using

            ' Display Status.
            System.Console.WriteLine("Conversion performed successfully.")
        End Sub
    End Class
End Namespace