
Imports System.IO
Imports Aspose.Imaging.FileFormats.Tiff
Imports Aspose.Imaging.FileFormats.Tiff.Enums
Imports Aspose.Imaging.ImageOptions
Imports Aspose.Imaging.Sources

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages
    Class AddFramesToTIFFImageWithDifferentSettings
        Public Shared Sub Run()
            ' To get proper output please apply a valid Aspose.Imaging License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")

            ' ExStart:AddFramesToTIFFImageWithDifferentSettings
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingAndConvertingImages()

            Dim outputSettings As New TiffOptions(TiffExpectedFormat.TiffCcittFax4)
            outputSettings.Source = New StreamSource(New MemoryStream())
            Const newWidth As Integer = 500
            Const newHeight As Integer = 500
            Using tiffImage As TiffImage = DirectCast(Image.Create(outputSettings, newWidth, newHeight), TiffImage)
                Dim index As Integer = 0
                For Each file In Directory.GetFiles(dataDir, "*.tif")
                    Using rasterImage As RasterImage = DirectCast(Image.Load(file), RasterImage)
                        rasterImage.Resize(newWidth, newHeight, ResizeType.NearestNeighbourResample)
                        Dim frame As TiffFrame = tiffImage.ActiveFrame
                        If index > 0 Then
                            ' Ensure options are cloned for each frame

                            'If there is a TIFF image loaded you need to enumerate the frames and perform the following
                            ' frame = TiffFrame.CreateFrameFrom(sourceFrame, outputSettings)
                            frame = New TiffFrame(New TiffOptions(outputSettings), newWidth, newHeight)
                        End If

                        frame.SavePixels(frame.Bounds, rasterImage.LoadPixels(rasterImage.Bounds))
                        If index > 0 Then
                            tiffImage.AddFrame(frame)
                        End If
                        index += 1
                    End Using
                Next
                tiffImage.Save(dataDir & Convert.ToString("AddFramesToTIFFImageWithDifferentSettings_out.tiff"))
            End Using
            ' ExEnd:AddFramesToTIFFImageWithDifferentSettings
        End Sub
    End Class
End Namespace
