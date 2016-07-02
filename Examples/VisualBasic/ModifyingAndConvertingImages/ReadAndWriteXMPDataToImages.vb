Imports System.IO
Imports Aspose.Imaging.FileFormats.Tiff
Imports Aspose.Imaging.FileFormats.Tiff.Enums
Imports Aspose.Imaging.ImageOptions
Imports Aspose.Imaging.Xmp
Imports Aspose.Imaging.Xmp.Schemas.DublinCore
Imports Aspose.Imaging.Xmp.Schemas.Photoshop

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'


Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages
    Class ReadAndWriteXMPDataToImages
        Public Shared Sub Run()
            ' To get proper output please apply a valid Aspose.Imaging License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")

            ' ExStart:ReadAndWriteXMPDataToImages
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingAndConvertingImages()

            ' Specify the size of image by defining a Rectangle 
            Dim rect As New Rectangle(0, 0, 100, 200)

            Dim tiffOptions As New TiffOptions(TiffExpectedFormat.TiffJpegRgb)
            tiffOptions.Photometric = TiffPhotometrics.MinIsBlack
            tiffOptions.BitsPerSample = New UShort() {8}


            ' create the brand new image just for sample purposes
            Using image__1 = New TiffImage(New TiffFrame(tiffOptions, rect.Width, rect.Height))
                ' create an instance of XMP-Header
                Dim xmpHeader As New XmpHeaderPi(Guid.NewGuid().ToString())

                ' create an instance of Xmp-TrailerPi 
                Dim xmpTrailer As New XmpTrailerPi(True)

                ' create an instance of XMPmeta class to set different attributes
                Dim xmpMeta As New XmpMeta()
                xmpMeta.AddAttribute("Author", "Mr Smith")
                xmpMeta.AddAttribute("Description", "The fake metadata value")

                ' create an instance of XmpPacketWrapper that contains all metadata
                Dim xmpData As New XmpPacketWrapper(xmpHeader, xmpTrailer, xmpMeta)

                ' create an instacne of Photoshop package and set photoshop attributes
                Dim photoshopPackage As New PhotoshopPackage()
                photoshopPackage.SetCity("London")
                photoshopPackage.SetCountry("England")
                photoshopPackage.SetColorMode(ColorMode.Rgb)
                photoshopPackage.SetCreatedDate(DateTime.UtcNow)

                ' add photoshop package into XMP metadata
                xmpData.AddPackage(photoshopPackage)

                ' create an instacne of DublinCore package and set dublinCore attributes
                Dim dublinCorePackage As New DublinCorePackage()
                dublinCorePackage.SetAuthor("Charles Bukowski")
                dublinCorePackage.SetTitle("Confessions of a Man Insane Enough to Live With the Beasts")
                dublinCorePackage.AddValue("dc:movie", "Barfly")

                ' add dublinCore Package into XMP metadata
                xmpData.AddPackage(dublinCorePackage)

                Using ms = New MemoryStream()
                    ' update XMP metadata into image
                    image__1.XmpData = xmpData

                    ' Save image on the disk or in memory stream
                    image__1.Save(ms)

                    ms.Seek(0, System.IO.SeekOrigin.Begin)

                    ' Load the image from moemory stream or from disk to read/get the metadata
                    Using img = DirectCast(Image.Load(ms), TiffImage)
                        ' getting the XMP metadata
                        Dim imgXmpData As XmpPacketWrapper = img.XmpData
                        ' use package data ...
                        For Each package As XmpPackage In imgXmpData.Packages
                        Next
                    End Using
                End Using
            End Using
        End Sub
        ' ExEnd:ReadAndWriteXMPDataToImages
    End Class
End Namespace
