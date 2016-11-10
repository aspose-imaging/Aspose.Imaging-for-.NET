Imports Aspose.Imaging.FileFormats.Tiff

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages
    Class AlignHorizontalAndVeticalResolutionsOfImage
        Public Shared Sub Run()
            ' To get proper output please apply a valid Aspose.Imaging License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")
            ' ExStart:AlignHorizontalAndVeticalResolutionsOfImage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingAndConvertingImages()

            ' Load an image and convert the image instance to TiffImage
            Using image__1 As TiffImage = DirectCast(Image.Load(dataDir & Convert.ToString("SampleTiff1.tiff")), TiffImage)
                ' Call the align resolution method
                image__1.AlignResolutions()

                ' Save the results to output path.
                image__1.Save(dataDir & Convert.ToString("AlignHorizontalAndVeticalResolutionsOfImage_out.tiff"))

                Dim framesCount As Integer = image__1.Frames.Length
                For i As Integer = 0 To framesCount - 1
                    Dim frame As TiffFrame = image__1.Frames(i)
                    ' All resolutions after aligment must be equal

                    Dim verticalResolution = frame.VerticalResolution
                    Dim horizontalResolution = frame.HorizontalResolution

                    Console.WriteLine("Horizontal and vertical resolutions are equal:" & verticalResolution & ":" & horizontalResolution)
                Next
            End Using
            ' ExEnd:AlignHorizontalAndVeticalResolutionsOfImage
        End Sub
    End Class
End Namespace