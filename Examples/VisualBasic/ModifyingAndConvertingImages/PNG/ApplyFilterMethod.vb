Imports Aspose.Imaging.FileFormats.Png
Imports Aspose.Imaging.ImageOptions

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.PNG
    Class ApplyFilterMethod
        Public Shared Sub Run()
            ' ExStart:ApplyFilterMethod
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_PNG()

            Using png As PngImage = DirectCast(Image.Load(dataDir & Convert.ToString("aspose_logo.png")), PngImage)

                ' Create an instance of PngOptions,  Set the PNG filter method and Save changes to the disc
                Dim options As New PngOptions()
                options.FilterType = PngFilterType.Paeth
                png.Save(dataDir & Convert.ToString("ApplyFilterMethod_out.jpg"), options)
            End Using
            ' ExEnd:ApplyFilterMethod
        End Sub
    End Class
End Namespace
