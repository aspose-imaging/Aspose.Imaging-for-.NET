Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages

    Public Class ExportImagesInMultiThreadedEnvironment

        Public Shared Sub Run()

            ' To get proper output please apply a valid Aspose.Imaging License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx."

            ' ExStart: ExportImagesInMultiThreadedEnvironment

            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingAndConvertingImages()

            Dim imageDataPath As String = ""

            Try
                ' Path & name of existing image.
                imageDataPath = dataDir & Convert.ToString("sample.bmp")

                ' Create the stream of the existing image file.   
                Using fileStream As System.IO.FileStream = System.IO.File.Create(imageDataPath)

                    ' Create an instance of BMP image option class.
                    Using bmpOptions As New Aspose.Imaging.ImageOptions.BmpOptions()
                        bmpOptions.BitsPerPixel = 32

                        ' Set the source property of the imaging option class object.

                        ' DO PROCESSING. 
                        ' Following is the sample processing on the image. Un-comment to use it.
                        'using (RasterImage image = (RasterImage)Image.Create(bmpOptions, 10, 10))
                        '{
                        '    Color[] pixels = new Color[4];
                        '    for (int i = 0; i < 4; ++i)
                        '    {
                        '        pixels[i] = Color.FromArgb(40, 30, 20, 10);
                        '    }
                        '    image.SavePixels(new Rectangle(0, 0, 2, 2), pixels);
                        '    image.Save();
                        '}
                        bmpOptions.Source = New Aspose.Imaging.Sources.StreamSource(fileStream)
                    End Using
                End Using
            Finally
                ' Delete the file. This statement is in the final block because in any case this statement should execute to make it sure that resource is properly disposed off.
                System.IO.File.Delete(imageDataPath)
            End Try


            ' ExEnd: ExportImagesInMultiThreadedEnvironment



        End Sub


    End Class

End Namespace
