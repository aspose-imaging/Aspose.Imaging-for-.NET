Imports Aspose.Imaging.FileFormats.Png
Imports Aspose.Imaging.ImageOptions

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.PNG
    Class SettingResolution
        Public Shared Sub Run()
            ' ExStart:SettingResolution
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
            Using png As New PngImage(width, height)
                ' Save the previously loaded pixels on to the new PngImage
                png.SavePixels(New Rectangle(0, 0, width, height), pixels)
                ' Create an instance of PngOptions
                Dim options As New PngOptions()
                ' Set the horizontal & vertical resolutions for the resultant PNG image
                options.ResolutionSettings = New ResolutionSetting(72, 96)
                ' Save the result on disc while passing instance on PngOptions class
                png.Save(dataDir & Convert.ToString("SettingResolution_output.png"), options)
            End Using
            ' ExEnd:SettingResolution
        End Sub
    End Class
End Namespace