Imports Aspose.Imaging

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
' If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages
    Class DitheringRasterImages
        Public Shared Sub Run()
            ' To get proper output please apply a valid Aspose.Imaging License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")

            ' ExStart:DitheringRasterImages
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingAndConvertingImages()

            ' Create an instance of JpegImage and load an image as of JpegImage
            Using image__1 = DirectCast(Image.Load(dataDir & Convert.ToString("aspose-logo.jpg")), FileFormats.Jpeg.JpegImage)
                ' Peform Floyd Steinberg dithering on the current image
                image__1.Dither(DitheringMethod.ThresholdDithering, 4)
                ' Save the resultant image
                image__1.Save(dataDir & Convert.ToString("SampleImage_out.bmp"))
            End Using
            ' ExEnd:DitheringRasterImages
        End Sub
    End Class
End Namespace
