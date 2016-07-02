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
    Class SavingRasterImageToTIFFWithCompression
        Public Shared Sub Run()
            ' To get proper output please apply a valid Aspose.Imaging License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")

            ' ExStart:SavingRasterImageToTIFFWithCompression
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingAndConvertingImages()

            ' Create an instance of TiffOptions and set its various properties
            Dim options As New TiffOptions(TiffExpectedFormat.[Default])
            options.BitsPerSample = New UShort() {8, 8, 8}
            options.Photometric = TiffPhotometrics.Rgb
            options.Xresolution = New TiffRational(72)
            options.Yresolution = New TiffRational(72)
            options.ResolutionUnit = TiffResolutionUnits.Inch
            options.PlanarConfiguration = TiffPlanarConfigs.Contiguous

            ' Set the Compression to AdobeDeflate
            options.Compression = TiffCompressions.AdobeDeflate
            ' Or Deflate
            ' Options.Compression = TiffCompressions.Deflate

            ' Load an existing image in an instance of RasterImage
            Using image__1 As RasterImage = DirectCast(Image.Load(dataDir & Convert.ToString("SampleTiff1.tiff")), RasterImage)
                ' Create a new TiffImage from the RasterImage
                Using tiffImage As New TiffImage(New TiffFrame(image__1))
                    ' Save the resultant image while passing the instance of TiffOptions
                    tiffImage.Save(dataDir & Convert.ToString("SavingRasterImage_out.tiff"), options)
                End Using
            End Using
            ' ExEnd:SavingRasterImageToTIFFWithCompression
        End Sub
    End Class
End Namespace