
Imports Aspose.Imaging.FileFormats.Psd
Imports Aspose.Imaging.FileFormats.Psd.Layers
Imports Aspose.Imaging.ImageOptions

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'


Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.PSD
    Class ImportImageToPSDLayer
        Public Shared Sub Run()
            ' ExStart:ImportImageToPSDLayer
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_PSD()

            ' Load a PSD file as an image and caste it into PsdImage
            Using image__1 As PsdImage = DirectCast(Image.Load(dataDir & Convert.ToString("samplePsd.psd")), PsdImage)
                ' Extract a layer from PSDImage
                Dim layer As Layer = image__1.Layers(1)

                ' Load the image that is needed to be imported into the PSD file.
                Using drawImage As RasterImage = DirectCast(Image.Load(dataDir & Convert.ToString("aspose_logo.png")), RasterImage)
                    ' Call DrawImage method of the Layer class and pass the image instance.
                    layer.DrawImage(New Point(10, 10), drawImage)
                End Using

                ' Save the results to output path.
                image__1.Save(dataDir & Convert.ToString("ImportImageToPSDLayer_out.psd"), New PsdOptions())
            End Using
            ' ExEnd:ImportImageToPSDLayer
        End Sub
    End Class
End Namespace
