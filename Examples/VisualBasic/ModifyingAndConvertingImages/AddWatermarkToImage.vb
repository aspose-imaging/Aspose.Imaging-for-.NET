Imports Aspose.Imaging.ImageOptions

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages
    Public Class AddWatermarkToImage
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingAndConvertingImages()

            ' Create an instance of Image and load an existing image
            Using image As Image = image.Load(dataDir & "WaterMark.bmp")
                ' Create and initialize an instance of Graphics class
                Dim graphics As New Graphics(image)

                ' Creates an instance of Font
                Dim font As New Font("Times New Roman", 16, FontStyle.Bold)

                ' Create an instance of SolidBrush and set its various properties
                Dim brush As New Brushes.SolidBrush()
                brush.Color = Color.Black
                brush.Opacity = 100

                ' Draw a String using the SolidBrush object and Font, at specific Point
                graphics.DrawString("Aspose.Imaging for .Net", font, brush, New PointF(image.Width \ 2, image.Height \ 2))

                ' Save the image with changes.
                image.Save(dataDir & "AddWatermarkToImage_out.bmp")

                ' Display Status.
                System.Console.WriteLine("Watermark added successfully.")
            End Using
        End Sub
    End Class
End Namespace