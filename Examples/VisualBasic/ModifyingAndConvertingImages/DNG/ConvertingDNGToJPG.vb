

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.DNG

    Public Class ConvertingDNGToJPG

        Public Shared Sub Run()

            ' To get proper output please apply a valid Aspose.Imaging License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx."

            ' ExStart: SyncRootProperty

            'Declare variables to store file paths for input and output images.
            Dim sourceFiles As String = "Path_to_source_folder\Source\HDR - 3c.dng"
            Dim destPath As String = "Path_to_results_folder\Results\result.jpg"

            ' Create an instance of Image class and load an exiting DNG file.
            ' Convert the image to DngImage object.
            Using image1 As Aspose.Imaging.FileFormats.Dng.DngImage = DirectCast(Image.Load(sourceFiles), Aspose.Imaging.FileFormats.Dng.DngImage)

                ' Create an instance of JpegOptions class.
                ' convert and save to disk in Jpeg file format.
                image1.Save(destPath, New Aspose.Imaging.ImageOptions.JpegOptions())
            End Using

            ' ExEnd: SyncRootProperty


        End Sub

    End Class

End Namespace




