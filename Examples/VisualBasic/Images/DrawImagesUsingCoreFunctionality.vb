Imports System.IO

Imports Aspose.Imaging

Namespace Aspose.Imaging.Examples.VisualBasic.Images
    Public Class DrawImagesUsingCoreFunctionality
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Images("DrawImagesUsingCoreFunctionality")

            'Create an instance of BmpOptions and set its various properties
            Dim ImageOptions As New ImageOptions.BmpOptions()
            ImageOptions.BitsPerPixel = 24

            'Create an instance of FileCreateSource and assign it to Source property
            ImageOptions.Source = New Sources.FileCreateSource(dataDir & "sample.bmp", False)

            'Create an instance of RasterImage
            Using rasterImage As RasterImage = CType(Image.Create(ImageOptions, 500, 500), RasterImage)
                'Get the pixels of the image by specifying the area as image boundary
                Dim pixels() As Color = rasterImage.LoadPixels(rasterImage.Bounds)

                For index As Integer = 0 To pixels.Length - 1
                    'Set the indexed pixel color to yellow
                    pixels(index) = Color.Yellow
                Next index

                'Apply the pixel changes to the image
                rasterImage.SavePixels(rasterImage.Bounds, pixels)

                ' Save all changes.
                rasterImage.Save()
            End Using
        End Sub
    End Class
End Namespace