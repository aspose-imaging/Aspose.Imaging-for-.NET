Imports Aspose.Imaging.FileFormats.Png

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.PNG
    Class SpecifyTransparency
        Public Shared Sub Run()
            ' ExStart:SpecifyTransparency
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_PNG()

            'Initialize variables to hold width & height values
            Dim width As Integer = 0
            Dim height As Integer = 0

            'Initialize an array of type Color to hold the pixel data
            Dim pixels As Color() = Nothing

            ' Create an instance of RasterImage and load a BMP image
            Using raster As RasterImage = DirectCast(Image.Load(dataDir & Convert.ToString("aspose_logo.png")), RasterImage)

                ' Store the width & height in variables for later use
                width = raster.Width
                height = raster.Height

                ' Load the pixels of RasterImage into the array of type Color
                pixels = raster.LoadPixels(New Rectangle(0, 0, width, height))
            End Using

            ' Create & initialize an instance of PngImage while specifying size and PngColorType
            Using png As New PngImage(width, height, PngColorType.TruecolorWithAlpha)
                ' Save the previously loaded pixels on to the new PngImage
                png.SavePixels(New Rectangle(0, 0, width, height), pixels)

                ' Set TransparentColor property to specify which color to be rendered as transparent
                png.TransparentColor = Color.Black
                png.HasTransparentColor = True

                ' Save the result on disc
                png.Save(dataDir & Convert.ToString("SpecifyTransparencyforPNGImages_out.jpg"))
            End Using
            ' ExEnd:SpecifyTransparency
        End Sub
    End Class
End Namespace