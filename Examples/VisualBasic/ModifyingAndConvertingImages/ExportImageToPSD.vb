Imports Aspose.Imaging.FileFormats.Psd
Imports Aspose.Imaging.ImageOptions

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages
    Public Class ExportImageToPSD
        Public Shared Sub Run()
            ' To get proper output please apply a valid Aspose.Imaging License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")

            ' ExStart:ExportImageToPSD
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingAndConvertingImages()

            ' Load an existing image
            Using image__1 As Image = Image.Load(dataDir & Convert.ToString("sample.bmp"))
                ' Create an instance of PsdOptions and set it’s various properties
                Dim psdOptions As New PsdOptions()
                psdOptions.ColorMode = ColorModes.Rgb
                psdOptions.CompressionMethod = CompressionMethod.Raw
                psdOptions.Version = 4

                ' Save image to disk in PSD format
                image__1.Save(dataDir & Convert.ToString("ExportImageToPSD_output.psd"), psdOptions)

                ' Display Status.
                Console.WriteLine("Export to PSD performed successfully.")
            End Using
            ' ExEnd:ExportImageToPSD
        End Sub
    End Class
End Namespace