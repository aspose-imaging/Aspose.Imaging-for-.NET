Imports Aspose.Imaging.ImageFilters.FilterOptions
Imports Aspose.Imaging
Imports Aspose.Imaging.FileFormats.Svg
Imports Aspose.Imaging.ImageOptions

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'


Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages
    Class ConvertingSVGToRasterImages
        Public Shared Sub Run()
            ' To get proper output please apply a valid Aspose.Imaging License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            ' ExStart:ApplyingMotionWienerFilter
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingAndConvertingImages()

            ' Load the image
            Using image__1 As SvgImage = DirectCast(Image.Load(dataDir & Convert.ToString("aspose_logo.Svg")), SvgImage)
                ' create an instance of PNG options
                Dim pngOptions As New PngOptions()

                'Save the results to disk
                image__1.Save(dataDir & Convert.ToString("ConvertingSVGToRasterImages_out.png"), pngOptions)
            End Using
            ' ExEnd:ApplyingMotionWienerFilter
        End Sub
    End Class
End Namespace
