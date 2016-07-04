Imports System.IO
Imports Aspose.Imaging.FileFormats.Tiff

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages
    Public Class ConcatenatingTIFFImagesfromStream
        Public Shared Sub Run()
            ' To get proper output please apply a valid Aspose.Imaging License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingAndConvertingImages()

            ' Create instances of FileStream and initialize with Tiff images
            Dim fileStream As New FileStream(dataDir & Convert.ToString("TestDemo.tif"), FileMode.Open)
            Dim fileStream1 As New FileStream(dataDir & Convert.ToString("sample.tif"), FileMode.Open)

            ' Create an instance of TiffImage and load the destination image from filestream
            Using image As TiffImage = DirectCast(Imaging.Image.Load(fileStream), TiffImage)
                ' Create an instance of TiffImage and load the source image from filestream
                Using image1 As TiffImage = DirectCast(Imaging.Image.Load(fileStream1), TiffImage)
                    ' Create an instance of TIffFrame and copy active frame of source image
                    Dim frame As TiffFrame = TiffFrame.CopyFrame(image1.ActiveFrame)

                    ' Add copied frame to destination image
                    image.AddFrame(frame)
                End Using
                ' Save the image with changes
                image.Save(dataDir & Convert.ToString("ConcatenatingTIFFImagesfromStream_out.tif"))
                ' Close the FileStreams
                fileStream.Close()
                fileStream1.Close()
            End Using
        End Sub
    End Class
End Namespace
