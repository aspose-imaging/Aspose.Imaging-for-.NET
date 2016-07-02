
Imports System.IO

Imports Aspose.Imaging
Imports Aspose.Imaging.ImageOptions
Imports Aspose.Imaging.FileFormats.Tiff
Imports Aspose.Imaging.FileFormats.Tiff.Enums
Imports Aspose.Imaging.Sources

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages
    Public Class AddFramesToTIFFImage
        Public Shared Sub Run()
            ' To get proper output please apply a valid Aspose.Imaging License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")

            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingAndConvertingImages()
            Dim outputSettings As New TiffOptions(TiffExpectedFormat.[Default])
            outputSettings.BitsPerSample = New UShort() {1}
            outputSettings.Compression = TiffCompressions.CcittFax3
            outputSettings.Photometric = TiffPhotometrics.MinIsWhite
            outputSettings.Source = New StreamSource(New MemoryStream())
            Dim newWidth As Integer = 500
            Dim newHeight As Integer = 500
            Dim path As String = dataDir & Convert.ToString("AddFramesToTIFFImage_out.tif")
            Using tiffImage As TiffImage = DirectCast(Image.Create(outputSettings, newWidth, newHeight), TiffImage)
                Dim index As Integer = 0
                For Each file In Directory.GetFiles(dataDir, "*.jpg")
                    Using ri As RasterImage = DirectCast(Image.Load(file), RasterImage)
                        ri.Resize(newWidth, newHeight, ResizeType.NearestNeighbourResample)
                        Dim frame As TiffFrame = tiffImage.ActiveFrame
                        If index > 0 Then
                            ' Ensure options are cloned for each frame
                            'If there is a TIFF image loaded you need to enumerate the frames and perform the following
                            ' frame = TiffFrame.CreateFrameFrom(sourceFrame, outputSettings)
                            frame = New TiffFrame(New TiffOptions(outputSettings), newWidth, newHeight)
                        End If

                        frame.SavePixels(frame.Bounds, ri.LoadPixels(ri.Bounds))
                        If index > 0 Then
                            tiffImage.AddFrame(frame)
                        End If
                        index += 1
                    End Using
                Next
                tiffImage.Save(path)
            End Using
        End Sub
    End Class
End Namespace
