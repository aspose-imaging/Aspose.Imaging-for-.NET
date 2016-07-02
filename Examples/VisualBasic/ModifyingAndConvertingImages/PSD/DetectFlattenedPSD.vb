
Imports Aspose.Imaging.FileFormats.Psd

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'


Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.PSD
    Class DetectFlattenedPSD
        Public Shared Sub Run()
            ' ExStart:DetectFlattenedPSD
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_PSD()

            ' Load a PSD file
            Using image__1 As PsdImage = DirectCast(Image.Load(dataDir & Convert.ToString("samplePsd.psd")), PsdImage)
                ' do processing

                ' Get the true value if PSD is flatten and false in case the PSD is not flatten.
                Console.WriteLine(image__1.IsFlatten)
            End Using
            ' ExEnd:DetectFlattenedPSD
        End Sub
    End Class
End Namespace