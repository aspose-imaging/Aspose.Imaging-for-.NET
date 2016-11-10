Imports System.Reflection
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
    Class ReadAndModifyJpegEXIFTags
        Public Shared Sub Run()
            ' ExStart:ReadAndModifyJpegEXIFTags
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_JPEG()

            ' Load an image using the factory method Load exposed by Image class
            Using image__1 As Image = Image.Load(dataDir & Convert.ToString("aspose-logo.jpg"))
                ' Initialize an object of ExifData and fill it will image's EXIF information and Check if image has any EXIF entries defined
                Dim exif As ExifData = DirectCast(image__1, JpegImage).ExifData
                ' Check if image has any EXIF entries defined
                If exif IsNot Nothing Then
                    ' In order to get all EXIF tags, first get the Type of EXIF object, Get all properties of EXIF object into an array and Iterate over the EXIF properties
                    Dim type As Type = exif.[GetType]()
                    Dim properties As PropertyInfo() = type.GetProperties()
                    For Each [property] As PropertyInfo In properties
                        ' Display property name and its value
                        Console.WriteLine([property].Name + ":")
                        Console.WriteLine([property].GetValue(exif, Nothing))
                    Next
                End If
            End Using
            ' ExEnd:ReadAndModifyJpegEXIFTags
        End Sub
    End Class
End Namespace