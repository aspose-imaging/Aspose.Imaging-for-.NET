Imports Aspose.Imaging.FileFormats.Bmp

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'


Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages
    Class Bradleythreshold
        Public Shared Sub Run()
            ' To get proper output please apply a valid Aspose.Imaging License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")
            ' ExStart:Bradleythreshold
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingAndConvertingImages() + "sample.bmp"

            ' Load an existing image.
            Using objimage = DirectCast(Image.Load(dataDir), BmpImage)
                ' Define threshold value
                Dim threshold As Double = 0.15

                ' Call BinarizeBradley method and pass the threshold value as parameter
                objimage.BinarizeBradley(threshold)

                ' Save the output image
                objimage.Save(dataDir & Convert.ToString("binarized_out.png"))
            End Using
            ' ExEnd:Bradleythreshold
        End Sub
    End Class
End Namespace
