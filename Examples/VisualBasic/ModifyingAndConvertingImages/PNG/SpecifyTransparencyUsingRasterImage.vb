'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'


Imports Aspose.Imaging.FileFormats.Png
Imports Aspose.Imaging.ImageOptions

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.PNG
    Class SpecifyTransparencyUsingRasterImage
        Public Shared Sub Run()
            ' ExStart:SpecifyTransparencyforPNGImagesUsingRasterImage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_PNG()

            'Initialize variables to hold width & height values
            Dim width As Integer = 0
            Dim height As Integer = 0


            ' Create an instance of RasterImage and load a BMP image
            Using image__1 As RasterImage = DirectCast(Image.Load(dataDir & Convert.ToString("aspose_logo.png")), RasterImage)
                ' Store the width & height in variables for later use
                width = image__1.Width
                height = image__1.Height

                ' Set the background color for the image
                image__1.BackgroundColor = Color.White

                ' Set the transparent color for the image
                image__1.TransparentColor = Color.Black

                ' Set the HasTransparentColor & HasBackgroundColor properties to true
                image__1.HasTransparentColor = True
                image__1.HasBackgroundColor = True

                ' Save the image on disc in PNG format
                image__1.Save(dataDir & Convert.ToString("SpecifyTransparencyforPNGImagesUsingRasterImage_out.jpg"), New PngOptions())
            End Using
            ' ExEnd:SpecifyTransparencyforPNGImages
        End Sub
    End Class
End Namespace
