Imports Aspose.Imaging.Exif
Imports Aspose.Imaging.FileFormats.Jpeg

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.JPEG
    Class ReadJpegEXIFTags
        Public Shared Sub Run()
            ' ExStart:ReadJpegEXIFTags
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_JPEG()

            Using image__1 As JpegImage = DirectCast(Image.Load(dataDir & Convert.ToString("aspose-logo.jpg")), JpegImage)
                Dim exifData As JpegExifData = image__1.ExifData
                Console.WriteLine("Camera Owner Name: " & exifData.CameraOwnerName)
                Console.WriteLine("Aperture Value: " & DirectCast(exifData.ApertureValue, Object))
                Console.WriteLine("Orientation: " & exifData.Orientation)
                Console.WriteLine("Focal Length: " & DirectCast(exifData.FocalLength, Object))
                Console.WriteLine("Compression: " & exifData.Compression)
            End Using
        End Sub
        ' ExEnd:ReadJpegEXIFTags
    End Class
End Namespace