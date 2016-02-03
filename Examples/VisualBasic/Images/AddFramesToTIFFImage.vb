Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Imaging
Imports Aspose.Imaging.ImageOptions
Imports Aspose.Imaging.FileFormats.Tiff
Imports Aspose.Imaging.FileFormats.Tiff.Enums
Imports Aspose.Imaging.Sources

Namespace Aspose.Imaging.Examples.Images
    Public Class AddFramesToTIFFImage
        Public Shared Sub Main(ByVal args As String())
            ' The path to the documents directory.
            Dim dataDir As String = Aspose.Imaging.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            Dim outputSettings As TiffOptions = New TiffOptions(TiffExpectedFormat.Default)
            outputSettings.BitsPerSample = New UShort() {1}
            outputSettings.Compression = TiffCompressions.CcittFax3
            outputSettings.Photometric = TiffPhotometrics.MinIsWhite
            outputSettings.Source = New StreamSource(New MemoryStream())
            Dim newWidth As Integer = 500
            Dim newHeight As Integer = 500
            Dim path As String = dataDir & "output.tif"
            Using tiffImage As TiffImage = CType(Image.Create(outputSettings, newWidth, newHeight), TiffImage)
                Dim index As Integer = 0
                For Each file As String In Directory.GetFiles(dataDir, "*.jpg")
                    Using ri As RasterImage = CType(Image.Load(file), RasterImage)
                        ri.Resize(newWidth, newHeight, ResizeType.NearestNeighbourResample)
                        Dim frame As TiffFrame = tiffImage.ActiveFrame
                        If index > 0 Then
                            frame = New TiffFrame(New TiffOptions(outputSettings), newWidth, newHeight)
                            ' If there is a TIFF image loaded you need to enumerate the frames and perform the following
                            ' frame = TiffFrame.CreateFrameFrom(sourceFrame, outputSettings);
                        End If

                        frame.SavePixels(frame.Bounds, ri.LoadPixels(ri.Bounds))
                        If index > 0 Then
                            tiffImage.AddFrame(frame)
                        End If

                        index += 1
                    End Using
                Next file

                tiffImage.Save(path)
            End Using


        End Sub
    End Class
End Namespace