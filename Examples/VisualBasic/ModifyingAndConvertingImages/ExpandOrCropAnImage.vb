Imports Aspose.Imaging.ImageOptions

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'


Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages
    Class ExpandOrCropAnImage
        Public Shared Sub Run()
            ' To get proper output please apply a valid Aspose.Imaging License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")

            ' ExStart:ExpandOrCropAnImage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingAndConvertingImages()

            ' Load an image in an instance of Image
            Using rasterImage As RasterImage = DirectCast(Image.Load(dataDir & "aspose-logo.jpg"), RasterImage)
                ' setting for image data to be cashed
                rasterImage.CacheData()

                ' Create an instance of Rectangle class and define X,Y and Width, height of the rectangle.
                Dim destRect As New Rectangle() With
                    {.X = -200, .Y = -200, .Width = 300, .Height = 300}

                ' Save output image by passing output file name, image options and rectangle object.
                rasterImage.Save(dataDir & "Grayscaling_out.jpg", New JpegOptions(), destRect)
            End Using
            ' ExEnd:ExpandOrCropAnImage
        End Sub
    End Class
End Namespace
