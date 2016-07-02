'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'


Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages
    Class ResizeImageWithResizeTypeEnumeration
        Public Shared Sub Run()
            ' To get proper output please apply a valid Aspose.Imaging License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")

            ' ExStart:ResizeImageWithResizeTypeEnumeration
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingAndConvertingImages()

            ' Load an image from disk
            Using image__1 As Image = Image.Load(dataDir & Convert.ToString("aspose-logo.jpg"))
                If Not image__1.IsCached Then
                    image__1.CacheData()
                End If

                ' specifying only width and ResizeType
                Dim newWidth As Integer = image__1.Width / 2
                image__1.ResizeWidthProportionally(newWidth, ResizeType.LanczosResample)

                ' specifying only height and ResizeType
                Dim newHeight As Integer = image__1.Height / 2
                image__1.ResizeHeightProportionally(newHeight, ResizeType.NearestNeighbourResample)
                ' saving result
                image__1.Save(dataDir & Convert.ToString("ResizeImageWithResizeTypeEnumeration_out.png"))
            End Using

            ' ExEnd:ResizeImageWithResizeTypeEnumeration
        End Sub
    End Class
End Namespace
