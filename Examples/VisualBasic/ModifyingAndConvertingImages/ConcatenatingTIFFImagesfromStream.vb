Imports System.IO
Imports Aspose.Imaging.FileFormats.Tiff

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages
    Public Class ConcatenatingTIFFImagesfromStream
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingAndConvertingImages()

            ' Create instances of FileStream and initialize with Tiff images
            Dim fileStream As New FileStream(dataDir & Convert.ToString("TestDemo.tif"), FileMode.Open)
            Dim fileStream1 As New FileStream(dataDir & Convert.ToString("sample.tif"), FileMode.Open)

            ' Create an instance of TiffImage and load the destination image from filestream
            Using image As TiffImage = DirectCast(Imaging.Image.Load(fileStream), TiffImage)
                ' Create an instance of TiffImage and load the source image from filestream
                Using image1 As TiffImage = DirectCast(Imaging.Image.Load(fileStream1), TiffImage)
                    ' Create an instance of TIffFrame and copy active frame of source image and  Add copied frame to destination image
                    Dim frame As TiffFrame = TiffFrame.CopyFrame(image1.ActiveFrame)
                    image.AddFrame(frame)
                End Using
                ' Save the image with changes and Close the FileStreams
                image.Save(dataDir & Convert.ToString("ConcatenatingTIFFImagesfromStream_out.tif"))
                fileStream.Close()
                fileStream1.Close()
            End Using
        End Sub
    End Class
End Namespace
