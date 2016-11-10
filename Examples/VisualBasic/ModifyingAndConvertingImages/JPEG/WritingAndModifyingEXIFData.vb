Imports Aspose.Imaging.Exif
Imports Aspose.Imaging.Exif.Enums
Imports Aspose.Imaging.FileFormats.Jpeg

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.JPEG
    Class WritingAndModifyingEXIFData
        Public Shared Sub Run()
            ' ExStart:WritingAndModifyingEXIFData
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_JPEG()

            ' Load an image using the factory method Load exposed by Image class
            Using image__1 As Image = Image.Load(dataDir & Convert.ToString("aspose-logo.jpg"))
                'Initialize an object of ExifData and fill it will image's EXIF information
                Dim exif As JpegExifData = DirectCast(image__1, JpegImage).ExifData

                ' Set LensMake, WhiteBalance, Flash information Save the image
                exif.LensMake = "Sony"
                exif.WhiteBalance = ExifWhiteBalance.Auto
                exif.Flash = ExifFlash.Fired
                image__1.Save(dataDir & Convert.ToString("aspose-logo_out.jpg"))
            End Using
            ' ExEnd:WritingAndModifyingEXIFData
        End Sub
    End Class
End Namespace