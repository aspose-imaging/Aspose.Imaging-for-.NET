
Imports Aspose.Imaging.CoreExceptions
Imports Aspose.Imaging.FileFormats.Emf
Imports Aspose.Imaging.FileFormats.Tiff.Enums
Imports Aspose.Imaging.ImageOptions

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'


Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.MetaFiles
    Class ExportMetaFileToRasterFormats
        Public Shared Sub Run()
            ' ExStart:ExportMetaFileToRasterFormats
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_MetaFiles()
            Dim outputfile As String = dataDir & Convert.ToString("file_out")
            ' Create EmfRasterizationOption class instance and set properties
            Dim emfRasterizationOptions As New EmfRasterizationOptions()
            emfRasterizationOptions.BackgroundColor = Color.PapayaWhip
            emfRasterizationOptions.PageWidth = 300
            emfRasterizationOptions.PageHeight = 300

            ' Load an existing EMF file as iamge and convert it to EmfImage class object
            Using image__1 = DirectCast(Image.Load(dataDir & Convert.ToString("Picture1.emf")), EmfImage)
                If Not image__1.Header.EmfHeader.Valid Then
                    Throw New ImageLoadException(String.Format("The file {0} is not valid", dataDir & Convert.ToString("Picture1.emf")))
                End If

                ' Convert EMF to BMP
                image__1.Save(outputfile & Convert.ToString(".bmp"), New BmpOptions() With { _
                    .VectorRasterizationOptions = emfRasterizationOptions _
                })

                ' Convert EMF to GIF
                image__1.Save(outputfile & Convert.ToString(".gif"), New GifOptions() With { _
                    .VectorRasterizationOptions = emfRasterizationOptions _
                })

                ' Convert EMF to JPEG
                image__1.Save(outputfile & Convert.ToString(".jpeg"), New JpegOptions() With {
                    .VectorRasterizationOptions = emfRasterizationOptions _
                })

                ' Convert EMF to J2K
                image__1.Save(outputfile & Convert.ToString(".j2k"), New Jpeg2000Options() With { _
                    .VectorRasterizationOptions = emfRasterizationOptions _
                })

                ' Convert EMF to PNG
                image__1.Save(outputfile & Convert.ToString(".png"), New PngOptions() With { _
                    .VectorRasterizationOptions = emfRasterizationOptions _
                })

                ' Convert EMF to PSD
                image__1.Save(outputfile & Convert.ToString(".psd"), New PsdOptions() With { _
                    .VectorRasterizationOptions = emfRasterizationOptions _
                })

                ' Convert EMF to TIFF
                image__1.Save(outputfile & Convert.ToString(".tiff"), New TiffOptions(TiffExpectedFormat.TiffLzwRgb) With { _
                    .VectorRasterizationOptions = emfRasterizationOptions _
                })

                ' Convert EMF to WebP
                image__1.Save(outputfile & Convert.ToString(".webp"), New WebPOptions() With { _
                    .VectorRasterizationOptions = emfRasterizationOptions _
                })
            End Using
        End Sub
        ' ExEnd:ExportMetaFileToRasterFormats
    End Class
End Namespace
