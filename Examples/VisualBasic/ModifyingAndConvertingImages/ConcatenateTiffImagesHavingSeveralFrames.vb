Imports System.Collections.Generic
Imports System.IO
Imports Aspose.Imaging.FileFormats.Tiff
Imports Aspose.Imaging.FileFormats.Tiff.Enums
Imports Aspose.Imaging.ImageOptions

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages
    Public Class ConcatenateTiffImagesHavingSeveralFrames
        Public Shared Sub Run()
            ' To get proper output please apply a valid Aspose.Imaging License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingAndConvertingImages()

            Dim files As New List(Of String)(New String() {dataDir & Convert.ToString("TestDemo.tiff"), dataDir & Convert.ToString("sample.tiff")})
            Dim createOptions As New TiffOptions(TiffExpectedFormat.[Default])
            createOptions.BitsPerSample = New UShort() {1}
            createOptions.Orientation = TiffOrientations.TopLeft
            createOptions.Photometric = TiffPhotometrics.MinIsBlack
            createOptions.Compression = TiffCompressions.CcittFax3
            createOptions.FillOrder = TiffFillOrders.Lsb2Msb

            'Create a new image by passing the TiffOptions and size of first frame
            'we will remove the first frame at the end, cause it will be empty
            Dim output As TiffImage = Nothing
            Try
                Dim images As New List(Of TiffImage)()
                Try
                    For Each file In files
                        'Create an instance of TiffImage and load the source image
                        Dim input As TiffImage = DirectCast(Image.Load(file), TiffImage)
                        images.Add(input)
                        ' Do not dispose before data is fetched. Data is fetched on 'Save' later.
                        For Each frame In input.Frames
                            If output Is Nothing Then
                                ' create a new tiff image with first frame defined.
                                output = New TiffImage(TiffFrame.CopyFrame(frame))
                            Else
                                ' Add copied frame to destination image
                                output.AddFrame(TiffFrame.CopyFrame(frame))
                            End If
                        Next
                    Next

                    If output IsNot Nothing Then
                        ' save the result
                        output.Save(dataDir & Convert.ToString("ConcatenateTiffImagesHavingSeveralFrames_out.tif"), createOptions)
                    End If
                Finally
                    For Each image1 As TiffImage In images
                        image1.Dispose()
                    Next
                End Try

            Catch ex As Exception
            End Try
        End Sub
    End Class
End Namespace