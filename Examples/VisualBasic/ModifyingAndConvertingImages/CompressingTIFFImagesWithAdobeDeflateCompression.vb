Imports System.IO
Imports Aspose.Imaging.FileFormats.Tiff
Imports Aspose.Imaging.FileFormats.Tiff.Enums
Imports Aspose.Imaging.ImageOptions
Imports Aspose.Imaging.Sources

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'


Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages
    Class CompressingTIFFImagesWithAdobeDeflateCompression
        Public Shared Sub Run()
            ' To get proper output please apply a valid Aspose.Imaging License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")
            ' ExStart:CompressingTIFFImagesWithAdobeDeflateCompression
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingAndConvertingImages()

            ' Load an image through file path location or stream
            Dim image__1 As Image = Image.Load(dataDir & Convert.ToString("SampleTiff1.tiff"))

            ' Create an instance of TiffOptions for the resultant image
            Dim outputSettings As New TiffOptions(TiffExpectedFormat.[Default])

            ' Set BitsPerSample, Photometric mode & Compression mode
            outputSettings.BitsPerSample = New UShort() {4}
            outputSettings.Compression = TiffCompressions.AdobeDeflate
            outputSettings.Photometric = TiffPhotometrics.Palette

            ' set graycale palette
            outputSettings.Palette = ColorPaletteHelper.Create4BitGrayscale(False)
            ' ExEnd:CompressingTIFFImagesWithAdobeDeflateCompression
        End Sub
    End Class
End Namespace