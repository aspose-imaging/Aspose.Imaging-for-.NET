Imports System.IO
Imports Aspose.Imaging.Brushes
Imports Aspose.Imaging.ImageOptions
Imports Aspose.Imaging.Sources

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'
Namespace Aspose.Imaging.Examples.VisualBasic.DrawingAndFormattingImages
    Class DrawingRectangle
        Public Shared Sub Run()
            ' ExStart:DrawingRectangle
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_DrawingAndFormattingImages() + "SampleRectangle_out.bmp"

            ' Creates an instance of FileStream
            Using stream As New FileStream(dataDir, FileMode.Create)
                ' Create an instance of BmpOptions and set its various properties
                Dim saveOptions As New BmpOptions()
                saveOptions.BitsPerPixel = 32

                ' Set the Source for BmpOptions
                saveOptions.Source = New StreamSource(stream)

                ' Create an instance of Image
                Using image__1 As Image = Image.Create(saveOptions, 100, 100)
                    ' Create and initialize an instance of Graphics class
                    Dim graphic As New Graphics(image__1)

                    ' Clear Graphics surface
                    graphic.Clear(Color.Yellow)

                    ' Draw a rectangle shape by specifying the Pen object having red color and a rectangle structure
                    graphic.DrawRectangle(New Pen(Color.Red), New Rectangle(30, 10, 40, 80))

                    ' Draw a rectangle shape by specifying the Pen object having solid brush with blue color and a rectangle structure
                    graphic.DrawRectangle(New Pen(New SolidBrush(Color.Blue)), New Rectangle(10, 30, 80, 40))

                    ' Save all changes.
                    image__1.Save()
                End Using
            End Using
            ' ExEnd:DrawingRectangle
        End Sub
    End Class
End Namespace