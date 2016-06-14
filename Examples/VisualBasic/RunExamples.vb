Imports System.IO
Imports Aspose.Imaging.Examples.VisualBasic.Export
Imports Aspose.Imaging.Examples.VisualBasic.Files
Imports Aspose.Imaging.Examples.VisualBasic.Images
Imports Aspose.Imaging.Examples.VisualBasic.Shapes


Namespace Aspose.Imaging.Examples.VisualBasic
    Public Class RunExamples
       
        Shared Sub Main()

            Console.WriteLine("Open RunExamples.vb.  " & vbLf & "In Main() method uncomment the example that you want to run.")
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

            ' Stop before exiting
            Console.WriteLine(Constants.vbLf + Constants.vbLf & "Program Finished. Press any key to Continue....")
            Console.ReadKey()

           

        End Sub


        Public Shared Function GetDataDir_Export(path1 As String) As [String]
            Return Path.GetFullPath((Convert.ToString(GetDataDir_Data() & Convert.ToString("Export/")) & path1) + "/")
        End Function

        Public Shared Function GetDataDir_Files() As [String]
            Return Path.GetFullPath(GetDataDir_Data() & Convert.ToString("Files/"))
        End Function

        Public Shared Function GetDataDir_Images(path1 As String) As [String]
            Return Path.GetFullPath((Convert.ToString(GetDataDir_Data() & Convert.ToString("Images/")) & path1) + "/")
        End Function

        Public Shared Function GetDataDir_Shapes(path1 As String) As [String]
            Return Path.GetFullPath((Convert.ToString(GetDataDir_Data() & Convert.ToString("Shapes/")) & path1) + "/")
        End Function


        Public Shared Function GetDataDir_Data() As String
            Dim parent = Directory.GetParent(Directory.GetCurrentDirectory()).Parent
            Dim startDirectory As String = Nothing
            If parent IsNot Nothing Then
                Dim directoryInfo = parent.Parent
                If directoryInfo IsNot Nothing Then
                    startDirectory = directoryInfo.FullName
                End If
            Else
                startDirectory = parent.FullName
            End If
            Return Path.Combine(startDirectory, "Data\")
        End Function

    End Class
End Namespace