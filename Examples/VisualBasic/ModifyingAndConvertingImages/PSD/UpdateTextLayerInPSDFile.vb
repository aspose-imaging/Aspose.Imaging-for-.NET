Imports System.Diagnostics
Imports Aspose.Imaging.FileFormats.Psd
Imports Aspose.Imaging.FileFormats.Psd.Layers
Imports Aspose.Imaging.ImageOptions

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.PSD
    Class UpdateTextLayerInPSDFile
        Public Shared Sub Run()
            ' ExStart:UpdateTextLayerInPSDFile
            Try
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_PSD()

                ' Load a PSD file as an image and caste it into PsdImage
                Using image__1 As PsdImage = DirectCast(Image.Load(dataDir & Convert.ToString("samplePsd.psd")), PsdImage)
                    Dim psdImage As PsdImage = image__1

                    Dim textLayer1 As TextLayer = TryCast(psdImage.Layers(1), TextLayer)
                    Dim textLayer2 As TextLayer = TryCast(psdImage.Layers(2), TextLayer)

                    Debug.Assert(textLayer2 IsNot Nothing, "textLayer2 != null")
                    textLayer2.UpdateText("test update", New Point(100, 100), 72.0F, Color.Purple)

                    psdImage.Save(dataDir & Convert.ToString("UpdateTextLayerInPSDFile_out.psd"), New PsdOptions() With { _
                        .CompressionMethod = CompressionMethod.RLE _
                    })
               
                End Using
            Catch ex As Exception
                Console.WriteLine(ex.Message + vbLf & "This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")
            End Try
            ' ExEnd:UpdateTextLayerInPSDFile
        End Sub
    End Class
End Namespace