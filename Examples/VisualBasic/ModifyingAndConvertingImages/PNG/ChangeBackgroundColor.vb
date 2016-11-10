Imports Aspose.Imaging.ImageOptions

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.PNG
    Class ChangeBackgroundColor
        Public Shared Sub Run()
            ' ExStart:ChangeBackgroundColor
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_PNG()

            ' Create an instance of Image class and load a PNG image
            Using img As Image = Image.Load(dataDir & Convert.ToString("aspose_logo.png"))
                ' Create an instance of RasterImage and get the pixels array by calling method LoadArgb32Pixels.
                Dim rasterImg As RasterImage = TryCast(img, RasterImage)
                If rasterImg IsNot Nothing Then
                    Dim pixels As Integer() = rasterImg.LoadArgb32Pixels(img.Bounds)
                    If pixels IsNot Nothing Then
                        ' Iterate through the pixel array and Check the pixel information that if it is a transparent color pixel and Change the pixel color to white
                        For i As Integer = 0 To pixels.Length - 1
                            ' Check the pixel information that if it is a transparent color pixel
                            If pixels(i) = rasterImg.TransparentColor.ToArgb() Then
                                pixels(i) = Color.White.ToArgb()
                            End If
                        Next
                        ' Replace the pixel array into the image.
                        rasterImg.SaveArgb32Pixels(img.Bounds, pixels)
                    End If
                End If

                ' Save the updated image to disk.
                If rasterImg IsNot Nothing Then
                    rasterImg.Save(dataDir & Convert.ToString("ChangeBackgroundColor_out.jpg"))
                End If
            End Using

            ' ExEnd:ChangeBackgroundColor
        End Sub
    End Class
End Namespace