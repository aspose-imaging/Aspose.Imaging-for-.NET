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
    Public Class DrawImagesUsingCoreFunctionality
        Public Shared Sub Run()
            ' ExStart:DrawImagesUsingCoreFunctionality
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_DrawingAndFormattingImages()

            ' Create an instance of BmpOptions and set its various properties
            Dim ImageOptions As New BmpOptions()
            ImageOptions.BitsPerPixel = 24

            ' Create an instance of FileCreateSource and assign it to Source property
            ImageOptions.Source = New FileCreateSource(dataDir & Convert.ToString("DrawImagesUsingCoreFunctionality_out.bmp"), False)

            ' Create an instance of RasterImage and Get the pixels of the image by specifying the area as image boundary
            Using rasterImage As RasterImage = DirectCast(Image.Create(ImageOptions, 500, 500), RasterImage)
                Dim pixels As Color() = rasterImage.LoadPixels(rasterImage.Bounds)
                For index As Integer = 0 To pixels.Length - 1
                    ' Set the indexed pixel color to yellow
                    pixels(index) = Color.Yellow
                Next

                ' Apply the pixel changes to the image and Save all changes.
                rasterImage.SavePixels(rasterImage.Bounds, pixels)
                rasterImage.Save()
            End Using
            ' ExStart:DrawImagesUsingCoreFunctionality
        End Sub
    End Class
End Namespace