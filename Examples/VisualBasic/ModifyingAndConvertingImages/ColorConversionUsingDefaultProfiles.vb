Imports System.IO
Imports Aspose.Imaging.FileFormats.Jpeg
Imports Aspose.Imaging.Sources

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages
    Public Class ColorConversionUsingDefaultProfiles
        Public Shared Sub Run()
            ' ExStart:ColorConversionUsingDefaultProfiles
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingAndConvertingImages()

            ' Load an existing JPG image
            Using image__1 As JpegImage = DirectCast(Image.Load(dataDir & Convert.ToString("aspose-logo_tn.jpg")), JpegImage)
                Dim rgbprofile As New StreamSource(File.OpenRead(dataDir & Convert.ToString("rgb.icc")))
                Dim cmykprofile As New StreamSource(File.OpenRead(dataDir & Convert.ToString("cmyk.icc")))
                image__1.DestinationRgbColorProfile = rgbprofile
                image__1.DestinationCmykColorProfile = cmykprofile
                image__1.Save(dataDir & Convert.ToString("ColorConversionUsingDefaultProfiles_out.icc"))
            End Using
            ' ExStart:ColorConversionUsingDefaultProfiles
        End Sub
    End Class
End Namespace