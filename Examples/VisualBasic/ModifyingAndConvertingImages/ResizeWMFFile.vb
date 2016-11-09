Imports Aspose.Imaging.ImageOptions

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages
    Public Class ResizeWMFFile
        Public Shared Sub Run()
            ' ExStart:ResizeWMFFile
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingAndConvertingImages()

            ' Load an existing WMF image
            Using image__1 As Image = Image.Load(dataDir & Convert.ToString("input.wmf"))
                ' Call the resize method of Image class and width,height values
                image__1.Resize(100, 100)

                ' Calculate new PNG image height
                Dim k As Double = (image__1.Width * 1.0) / image__1.Height

                ' Create an instance of EmfRasterizationOptions class and set different properties
                Dim emfRasterization As New EmfRasterizationOptions() With { _
                    .BackgroundColor = Color.WhiteSmoke, _
                    .PageWidth = 100, _
                    .PageHeight = CInt(Math.Round(100 / k)), _
                    .BorderX = 5, _
                    .BorderY = 10 _
                }

                ' Create an instance of PngOptions class and provide rasterization option
                Dim imageOptions As ImageOptionsBase = New PngOptions()
                imageOptions.VectorRasterizationOptions = emfRasterization

                ' Call the save method, provide output path and PngOptions to convert the WMF file to PNG and save the output
                ' ExStart:ResizeWMFFile
                image__1.Save(dataDir & Convert.ToString("CreateEMFMetaFileImage_out.png"), imageOptions)
            End Using
        End Sub
    End Class
End Namespace