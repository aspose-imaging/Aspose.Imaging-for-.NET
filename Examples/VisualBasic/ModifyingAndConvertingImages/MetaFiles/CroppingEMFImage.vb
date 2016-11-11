Imports System.IO
Imports Aspose.Imaging.FileFormats.Emf
Imports Aspose.Imaging.ImageOptions

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages.MetaFiles
    Class CroppingEMFImage
        Public Shared Sub Run()
            ' ExStart:CroppingEMFImage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_MetaFiles()

            ' Create an instance of Rasterization options
            Dim emfRasterizationOptions As New EmfRasterizationOptions()
            emfRasterizationOptions.BackgroundColor = Color.WhiteSmoke

            ' Create an instance of PNG options
            Dim pdfOptions As New PdfOptions()
            pdfOptions.VectorRasterizationOptions = emfRasterizationOptions

            ' Load an existing image into an instance of EMF class
            Using image__1 As EmfImage = DirectCast(Image.Load(dataDir & Convert.ToString("Picture1.emf")), EmfImage)
                Using outputStream As New FileStream(dataDir & Convert.ToString("CroppingEMFImage_out.pdf"), FileMode.Create)
                    ' Based on the shift values, apply the cropping on image and Crop method will shift the image bounds toward the center of image
                    image__1.Crop(30, 40, 50, 60)

                    ' Set height and width and Save the results to disk
                    pdfOptions.VectorRasterizationOptions.PageWidth = image__1.Width
                    pdfOptions.VectorRasterizationOptions.PageHeight = image__1.Height
                    image__1.Save(outputStream, pdfOptions)
                End Using
            End Using
            ' ExEnd:CroppingEMFImage
        End Sub
    End Class
End Namespace