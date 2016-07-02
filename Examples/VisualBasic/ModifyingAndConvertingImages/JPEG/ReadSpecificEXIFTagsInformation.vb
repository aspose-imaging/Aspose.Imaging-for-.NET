
Imports System.Reflection
Imports Aspose.Imaging.Exif
Imports Aspose.Imaging.FileFormats.Jpeg

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'


Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.JPEG
    Class ReadSpecificEXIFTagsInformation
        Public Shared Sub Run()
            ' ExStart:ReadSpecificEXIFTagsInformation
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_JPEG()

            ' Load an image using the factory method Load exposed by Image class
            Using image__1 As Image = Image.Load(dataDir & Convert.ToString("aspose-logo.jpg"))
                'Initialize an object of ExifData and fill it will image' S EXIF information
                Dim exif As ExifData = DirectCast(image__1, JpegImage).ExifData
                ' Check if image has any EXIF entries defined
                If exif IsNot Nothing Then
                    ' Display a few EXIF entries
                    Console.WriteLine("Exif WhiteBalance: " & exif.WhiteBalance)
                    Console.WriteLine("Exif PixelXDimension: " & exif.PixelXDimension)
                    Console.WriteLine("Exif PixelYDimension: " & exif.PixelYDimension)
                    Console.WriteLine("Exif ISOSpeed: " & exif.ISOSpeed)
                    Console.WriteLine("Exif FocalLength: " & DirectCast(exif.FocalLength, Object))
                End If
            End Using
            ' ExEnd:ReadSpecificEXIFTagsInformation
        End Sub
    End Class
End Namespace
