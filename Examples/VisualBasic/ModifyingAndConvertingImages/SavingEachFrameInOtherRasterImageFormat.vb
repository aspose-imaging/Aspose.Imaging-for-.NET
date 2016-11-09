Imports Aspose.Imaging.FileFormats.Tiff
Imports Aspose.Imaging.ImageOptions

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages
    Class SavingEachFrameInOtherRasterImageFormat
        Public Shared Sub Run()
            ' To get proper output please apply a valid Aspose.Imaging License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")

            ' ExStart:SavingEachFrameInOtherRasterImageFormat
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingAndConvertingImages()

            ' Create an instance of TiffImage and load the file from disc
            Using multiImage = DirectCast(TiffImage.Load(dataDir & Convert.ToString("SampleTiff1.tiff")), TiffImage)
                'Initialize a variable to keep track of the frames in the image
                Dim i As Integer = 0
                ' Iterate over the tiff frame collection
                For Each tiffFrame In multiImage.Frames
                    ' Save the frame directly on disc in PNG format
                    tiffFrame.Save((dataDir & System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)) + "_out.png", New PngOptions())
                Next
            End Using
            ' ExEnd:SavingEachFrameInOtherRasterImageFormat
        End Sub
    End Class
End Namespace