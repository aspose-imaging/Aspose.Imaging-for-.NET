Imports System.IO
Imports Aspose.Imaging.ImageOptions
Imports Aspose.Imaging.Sources

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages
    Class ControllCacheReallocation
        Public Shared Sub Run()
            ' ExStart:ControllCacheReallocation
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Cache()

            ' By default the cache folder is set to the local temp directory.  You can specify a different cache folder from the default this way:
            Cache.CacheFolder = dataDir

            ' Auto mode is flexible and efficient
            Cache.CacheType = CacheType.Auto

            ' The default cache max value is 0, which means that there is no upper limit
            Cache.MaxDiskSpaceForCache = 1073741824
            ' 1 gigabyte
            Cache.MaxMemoryForCache = 1073741824
            ' 1 gigabyte
            ' We do not recommend that you change the following property because it may greatly affect performance
            Cache.ExactReallocateOnly = False

            ' At any time you can check how many bytes are currently allocated for the cache in memory or on disk
            ' By examining the following properties
            Dim l1 As Long = Cache.AllocatedDiskBytesCount
            Dim l2 As Long = Cache.AllocatedMemoryBytesCount

            Dim options As New GifOptions()
            options.Palette = New ColorPalette(CType({Color.Red, Color.Blue, Color.Black, Color.White}, Color()))
            options.Source = New StreamSource(New MemoryStream(), True)
            Using image__1 As RasterImage = DirectCast(Image.Create(options, 100, 100), RasterImage)
                Dim pixels As Color() = New Color(9999) {}
                For i As Integer = 0 To pixels.Length - 1
                    pixels(i) = Color.White
                Next

                image__1.SavePixels(image__1.Bounds, pixels)

                ' After executing the code above 40000 bytes are allocated to memory.
                Dim diskBytes As Long = Cache.AllocatedDiskBytesCount
                Dim memoryBytes As Long = Cache.AllocatedMemoryBytesCount
            End Using

            ' The allocation properties may be used to check whether all Aspose.Imaging objects were properly disposed. If you've forgotten to call dispose on an object the cache values will not be 0.
            l1 = Cache.AllocatedDiskBytesCount
            l2 = Cache.AllocatedMemoryBytesCount

            ' ExEnd:ControllCacheReallocation
        End Sub
    End Class
End Namespace