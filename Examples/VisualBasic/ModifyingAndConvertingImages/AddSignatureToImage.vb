Imports Aspose.Imaging.ImageOptions

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages
    Public Class AddSignatureToImage
        Public Shared Sub Run()
            ' ExStart:AddSignatureToImage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingAndConvertingImages()

            ' Create an instance of Image and load the primary image
            Using canvas As Image = Image.Load(dataDir & Convert.ToString("SampleTiff.tiff"))
                ' Create another instance of Image and load the secondary image containing the signature graphics
                Using signature As Image = Image.Load(dataDir & Convert.ToString("signature.gif"))
                    ' Create an instance of Graphics class and initialize it using the object of the primary image
                    Dim graphics As New Graphics(canvas)

                    ' Call the DrawImage method while passing the instance of secondary image and appropriate location. The following snippet tries to draw the secondary image at the right bottom of the primary image
                    graphics.DrawImage(signature, New Point(canvas.Height - signature.Height, canvas.Width - signature.Width))
                    canvas.Save(dataDir & Convert.ToString("AddSignatureToImage_out.png"), New PngOptions())
                End Using
            End Using
            ' ExStart:AddSignatureToImage
        End Sub
    End Class
End Namespace