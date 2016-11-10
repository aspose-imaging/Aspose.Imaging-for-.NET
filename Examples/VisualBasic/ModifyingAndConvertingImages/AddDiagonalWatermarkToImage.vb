Imports Aspose.Imaging.Brushes

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages
    Public Class AddDiagonalWatermarkToImage
        Public Shared Sub Run()
            ' ExStart:AddDiagonalWatermarkToImage
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingAndConvertingImages()

            ' Load an existing JPG image
            Using image__1 As Image = Image.Load(dataDir & Convert.ToString("SampleTiff1.tiff"))
                ' Declare a String object with Watermark Text
                Dim theString As String = "45 Degree Rotated Text"

                ' Create and initialize an instance of Graphics class
                Dim graphics As New Graphics(image__1)

                ' Initialize an object of SizeF to store image Size
                Dim sz As SizeF = graphics.Image.Size

                ' Creates an instance of Font, initialize it with Font Face, Size and Style
                Dim font As New Font("Times New Roman", 20, FontStyle.Bold)

                ' Create an instance of SolidBrush and set its various properties
                Dim brush As New SolidBrush()
                brush.Color = Color.Red
                brush.Opacity = 0

                ' Initialize an object of StringFormat class and set its various properties
                Dim format As New StringFormat()
                format.Alignment = StringAlignment.Center
                format.FormatFlags = StringFormatFlags.MeasureTrailingSpaces

                ' Create an object of Matrix class for transformation
                Dim matrix As New Matrix()

                ' First a translation then a rotation                
                matrix.Translate(sz.Width / 2, sz.Height / 2)
                matrix.Rotate(-45.0F)

                ' Set the Transformation through Matrix
                graphics.Transform = matrix

                ' Draw the string on Image
                graphics.DrawString(theString, font, brush, 0, 0, format)

                ' Save output to disk
                image__1.Save(dataDir & Convert.ToString("AddDiagonalWatermarkToImage_out.jpg"))
            End Using
            ' ExStart:AddDiagonalWatermarkToImage
        End Sub
    End Class
End Namespace