Imports System.IO
Imports VisualBasic.Aspose.Imaging.Examples.Export
Imports VisualBasic.Aspose.Imaging.Examples.Files
Imports VisualBasic.Aspose.Imaging.Examples.Images
Imports VisualBasic.Aspose.Imaging.Examples.Shapes

Namespace Aspose
    Namespace Imaging
        Namespace Examples
            Public Class Utils
                Shared Function GetDataDir(ByRef t As Type) As String
                    Dim c As String = t.FullName
                    c = c.Replace("VisualBasic.Aspose.Imaging.Examples.", "")
                    c = c.Replace(".", Path.DirectorySeparatorChar)
                    Dim p As String = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "..", "Data", c))
                    p += Path.DirectorySeparatorChar
                    Console.WriteLine("Using Data Dir {0}", p)
                    Return p
                End Function
                Shared Sub Main()

                    Console.WriteLine("Open RunExamples.vb. \nIn Main() method uncomment the example that you want to run.")
                    Console.WriteLine("=====================================================")

                    ' Uncomment the one you want to try out

                    ' =====================================================
                    ' Export
                    ' =====================================================
                    ' =====================================================

                    ExportDxfToPdf.Run()
                    'ExportImageToDifferentFormats.Run()
                    'ExportImageToPSD.Run()
                    'ExportPsdLayersToImages.Run()

                    ' =====================================================
                    ' =====================================================
                    ' Files
                    ' =====================================================
                    ' =====================================================

                    'CreatingAnImageBySettingPath.Run()
                    'CreatingImageUsingStream.Run()

                    ' =====================================================
                    ' =====================================================
                    ' Images
                    ' =====================================================
                    ' =====================================================

                    'AddFramesToTIFFImage.Run()
                    'ConcatTIFFImages.Run()
                    'DrawImagesUsingCoreFunctionality.Run()
                    'DrawingUsingGraphicsPath.Run()

                    ' =====================================================
                    ' =====================================================
                    ' Shapes
                    ' =====================================================
                    ' =====================================================

                    'DrawingArc.Run()
                    'DrawingBezier.Run()
                    'DrawingEllipse.Run()
                    'DrawingLines.Run()

                    Console.WriteLine("Press any key to continue...")
                    Console.ReadKey()

                End Sub
            End Class
        End Namespace
    End Namespace
End Namespace
