
Imports Aspose.Imaging.FileFormats.Psd
Imports Aspose.Imaging.ImageOptions
Imports Aspose.Imaging.Sources

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'


Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.PSD
    Class CreateIndexedPSDFiles
        Public Shared Sub Run()
            ' ExStart:CreateIndexedPSDFiles
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_PSD()

            ' Create an instance of PsdOptions and set it' S properties
            Dim createOptions = New PsdOptions()
            ' Set source
            createOptions.Source = New FileCreateSource(dataDir & Convert.ToString("Newsample_out.psd"), False)
            ' Set ColorMode to Indexed
            createOptions.ColorMode = ColorModes.Indexed
            ' Set PSD file version
            createOptions.Version = 5
            ' Create a new color patelle having RGB colors
            Dim palette As Color() = {Color.Red, Color.Green, Color.Blue}
            ' Set Palette property to newly created palette
            createOptions.Palette = New PsdColorPalette(palette)
            ' Set compression method
            createOptions.CompressionMethod = CompressionMethod.RLE

            ' Create a new PSD with PsdOptions created previously
            Using psd = PsdImage.Create(createOptions, 500, 500)
                ' Draw some graphics over the newly created PSD
                Dim graphics = New Graphics(psd)
                graphics.Clear(Color.White)
                graphics.DrawEllipse(New Pen(Color.Red, 6), New Rectangle(0, 0, 400, 400))
                psd.Save(dataDir & Convert.ToString("CreateIndexedPSDFiles_out.psd"))
            End Using
            ' ExEnd:CreateIndexedPSDFiles
        End Sub
    End Class
End Namespace

