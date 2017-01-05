
Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.MetaFiles

    Public Class ConvertingEMFToWMF

        Public Shared Sub Run()

            ' To get proper output please apply a valid Aspose.Imaging License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx."

            ' ExStart: SyncRootProperty

            ' List of existing EMF images. 
            Dim path As String = ""
            Dim files As String() = New String() {"TestEmfRotatedText.emf", "TestEmfPlusFigures.emf", "TestEmfBezier.emf"}

            ' Loop for each file name.
            For Each file As String In files

                ' Input file name & path.
                Dim filePath As String = System.IO.Path.Combine(path, file)

                ' Load the EMF image as image and convert it to MetaImage object.
                Using image1 As Aspose.Imaging.FileFormats.Emf.MetaImage = DirectCast(Image.Load(filePath), Aspose.Imaging.FileFormats.Emf.MetaImage)
                    ' Convert the EMF image to WMF image by creating and passing WMF image options class object.
                    image1.Save(filePath & Convert.ToString("_out.wmf"), New Aspose.Imaging.ImageOptions.WmfOptions())
                End Using
            Next

            ' ExEnd: SyncRootProperty


        End Sub

    End Class

End Namespace
