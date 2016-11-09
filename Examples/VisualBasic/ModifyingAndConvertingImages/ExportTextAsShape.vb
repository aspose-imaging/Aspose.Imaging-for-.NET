Imports Aspose.Imaging.ImageOptions

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages
    Public Class ExportTextAsShape
        Public Shared Sub Run()
            ' ExStart:ExportTextAsShape
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingAndConvertingImages()
            Using image__1 As Image = Image.Load(dataDir & Convert.ToString("Picture1.emf"))
                Dim emfRasterizationOptions As New EmfRasterizationOptions()
                emfRasterizationOptions.BackgroundColor = Color.White
                emfRasterizationOptions.PageWidth = image__1.Width
                emfRasterizationOptions.PageHeight = image__1.Height

                image__1.Save(dataDir & Convert.ToString("TextAsShapes_out.svg"), New SvgOptions() With { _
                    .VectorRasterizationOptions = emfRasterizationOptions, _
                    .TextAsShapes = True _
                })

                image__1.Save(dataDir & Convert.ToString("TextAsShapesFalse_out.svg"), New SvgOptions() With { _
                    .VectorRasterizationOptions = emfRasterizationOptions, _
                    .TextAsShapes = False _
                })
            End Using
            ' ExStart:ExportTextAsShape
        End Sub
    End Class
End Namespace