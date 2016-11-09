Imports Aspose.Imaging.ImageFilters.FilterOptions

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages
    Class BlurAnImage
        Public Shared Sub Run()
            ' To get proper output please apply a valid Aspose.Imaging License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")
            ' ExStart:BlurAnImage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingAndConvertingImages()

            ' Load the image
            Using image__1 As Image = Image.Load(dataDir & Convert.ToString("asposelogo.gif"))
                ' Convert the image into RasterImage.
                Dim rasterImage As RasterImage = DirectCast(image__1, RasterImage)

                ' Pass Bounds[rectangle] of image and GaussianBlurFilterOptions instance to Filter method.
                rasterImage.Filter(rasterImage.Bounds, New GaussianBlurFilterOptions(5, 5))

                ' Save the results to output path.
                rasterImage.Save(dataDir + "BlurAnImage_out.gif")
            End Using
            ' ExEnd:BlurAnImage
        End Sub
    End Class
End Namespace
