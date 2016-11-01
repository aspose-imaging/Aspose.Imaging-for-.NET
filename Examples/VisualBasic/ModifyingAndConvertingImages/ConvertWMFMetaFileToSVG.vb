Imports Aspose.Imaging

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages

    Public Class ConvertWMFMetaFileToSVG
        Public Shared Sub Run()
            ' ExStart:ConvertWMFMetaFileToSVG
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingAndConvertingImages()

            ' Create an instance of Image class by loading an existing .
            Using image__1 As Image = Image.Load(dataDir & Convert.ToString("input.wmf"))
                ' Create an instance of EmfRasterizationOptions class.
                Dim options As New ImageOptions.EmfRasterizationOptions()
                options.PageWidth = image__1.Width
                options.PageHeight = image__1.Height

                ' Call save method to convert WMF to SVG format by passing output file name and SvgOptions class instance.
                image__1.Save(dataDir & Convert.ToString("ConvertWMFMetaFileToSVG_out.svg"), New ImageOptions.SvgOptions() With { _
                    .VectorRasterizationOptions = options _
                })
            End Using
            ' ExEnd:ConvertWMFMetaFileToSVG
        End Sub
    End Class
End Namespace
