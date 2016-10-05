Imports Aspose.Imaging.ImageOptions

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages
    Public Class ConvertEMFToWMF
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingAndConvertingImages()

            ' Load an existing EMF file as Image.
            Using image__1 As Image = Image.Load(dataDir & Convert.ToString("Picture1.emf"))
                ' Call the Save method of Image class & Pass instance of WmfOptions class to Save method.
                image__1.Save(dataDir & Convert.ToString("ConvertEMFToWMF_out.wmf"), New WmfOptions())
            End Using
        End Sub
    End Class
End Namespace
