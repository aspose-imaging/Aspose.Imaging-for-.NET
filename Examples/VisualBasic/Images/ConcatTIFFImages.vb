Imports System.IO

Imports Aspose.Imaging
Imports Aspose.Imaging.FileFormats.Tiff

Namespace Aspose.Imaging.Examples.VisualBasic.Images
    Public Class ConcatTIFFImages
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Images("ConcatTIFFImages")

            'Create a copy of original image to avoid any alteration
            File.Copy(dataDir & "demo.tif", dataDir & "TestDemo.tif", True)

            'Create an instance of TiffImage and load the copied destination image
            Using image As TiffImage = CType(Global.Aspose.Imaging.Image.Load(dataDir & "TestDemo.tif"), TiffImage)
                'Create an instance of TiffImage and load the source image
                Using image1 As TiffImage = CType(Global.Aspose.Imaging.Image.Load(dataDir & "sample.tif"), TiffImage)
                    ' Create an instance of TIffFrame and copy active frame of source image
                    Dim frame As TiffFrame = TiffFrame.CopyFrame(image1.ActiveFrame)

                    ' Add copied frame to destination image
                    image.AddFrame(frame)

                    ' save the image with changes.
                    image.Save()
                End Using
            End Using

            ' Display Status.
            System.Console.WriteLine("Concatenation of TIF files done successfully.")
        End Sub
    End Class
End Namespace