Imports System.Collections.Generic
Imports Aspose.Imaging.FileFormats.Emf
Imports Aspose.Imaging.ImageOptions

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.MetaFiles
    Class SpecifyFontFolder
        Public Shared Sub Run()
            ' ExStart:SpecifyFontFolder
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_MetaFiles()

            ' Create an instance of Rasterization options
            Dim emfRasterizationOptions As New EmfRasterizationOptions()
            emfRasterizationOptions.BackgroundColor = Color.WhiteSmoke

            ' Create an instance of PNG options
            Dim pngOptions As New PngOptions()
            pngOptions.VectorRasterizationOptions = emfRasterizationOptions

            ' Load an existing EMF image
            Using image__1 As EmfImage = DirectCast(Image.Load(dataDir & Convert.ToString("Picture1.emf")), EmfImage)
                image__1.CacheData()

                ' Set height and width, Reset font settings
                pngOptions.VectorRasterizationOptions.PageWidth = 300
                pngOptions.VectorRasterizationOptions.PageHeight = 350
                FontSettings.Reset()
                image__1.Save(dataDir & Convert.ToString("Picture1_default_fonts_out.png"), pngOptions)

                'Initialize font list
                Dim fonts As New List(Of String)(FontSettings.GetDefaultFontsFolders())

                ' Add new font path to font list and Assign list of font folders to font settings and Save the EMF file to PNG image with new font
                fonts.Add(dataDir & Convert.ToString("arialAndTimesAndCourierRegular.xml"))
                FontSettings.SetFontsFolders(fonts.ToArray(), True)
                image__1.Save(dataDir & Convert.ToString("Picture1_with_my_fonts_out.png"), pngOptions)
            End Using
        End Sub
        ' ExEnd:SpecifyFontFolder
    End Class
End Namespace