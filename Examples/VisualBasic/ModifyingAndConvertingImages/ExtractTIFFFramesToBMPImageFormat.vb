Imports Aspose.Imaging.FileFormats.Bmp
Imports Aspose.Imaging.FileFormats.Tiff
Imports Aspose.Imaging.ImageOptions
Imports Aspose.Imaging.Sources

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages
    Class ExtractTIFFFramesToBMPImageFormat
        Public Shared Sub Run()
            ' ExStart:ExtractTIFFFramesToBMPImageFormat
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingAndConvertingImages()

            Using multiImage As TiffImage = DirectCast(Image.Load(dataDir & Convert.ToString("SampleTiff1.tiff")), TiffImage)
                ' Create an instance of int to keep track of frames in TiffImage
                Dim frameCounter As Integer = 0

                ' Iterate over the TiffFrames in TiffImage
                For Each tiffFrame As TiffFrame In multiImage.Frames
                    multiImage.ActiveFrame = tiffFrame

                    ' Load Pixels of TiffFrame into an array of Colors
                    Dim pixels As Color() = multiImage.LoadPixels(tiffFrame.Bounds)

                    ' Create an instance of bmpCreateOptions
                    Dim bmpCreateOptions As New BmpOptions()
                    bmpCreateOptions.BitsPerPixel = 24

                    ' Set the Source of bmpCreateOptions as FileCreateSource by specifying the location where output will be saved
                    bmpCreateOptions.Source = New FileCreateSource(String.Format("{0}\ConcatExtractTIFFFramesToBMP_out{1}.bmp", dataDir, frameCounter), False)

                    ' Create a new bmpImage
                    Using bmpImage As BmpImage = DirectCast(Image.Create(bmpCreateOptions, tiffFrame.Width, tiffFrame.Height), BmpImage)
                        ' Save the bmpImage with pixels from TiffFrame
                        bmpImage.SavePixels(tiffFrame.Bounds, pixels)
                        bmpImage.Save()
                    End Using
                    frameCounter += 1
                Next
            End Using
            ' ExEnd:ExtractTIFFFramesToBMPImageFormat
        End Sub
    End Class
End Namespace