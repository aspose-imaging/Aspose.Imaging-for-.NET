Imports System.IO
Imports Aspose.Imaging.FileFormats.Psd
Imports Aspose.Imaging.ImageOptions
Imports Aspose.Imaging.Sources

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.PSD
    Class MergePSDlayers
        Public Shared Sub Run()
            ' ExStart:MergePSDlayers
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_PSD()
            Dim sourceFileName As String = dataDir & Convert.ToString("PsdImage.psd")

            ' Load an existing PSD file as image
            Using image__1 As Image = Image.Load(sourceFileName)
                ' Convert the loaded image to PSDImage
                Dim psdImage = DirectCast(image__1, PsdImage)

                ' Create a JPG file stream
                Using stream As Stream = File.Create(sourceFileName.Replace("psd", "jpg"))
                    ' Create JPEG option class object
                    Dim jpgOptions = New JpegOptions()

                    ' Set the source property to jpg file stream.
                    jpgOptions.Source = New StreamSource(stream)

                    ' Call the Save the method of PSDImage class to merge the layers and save it as jpg image.
                    psdImage.Save(stream, jpgOptions)
                End Using
            End Using
            ' ExEnd:MergePSDlayers
        End Sub
    End Class
End Namespace