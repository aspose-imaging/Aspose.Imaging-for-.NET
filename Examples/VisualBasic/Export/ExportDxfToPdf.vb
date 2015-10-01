'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Imaging. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Aspose.Imaging
Imports Aspose.Imaging.ImageOptions
Imports Aspose.Imaging.FileFormats.Cad

Namespace Aspose.Imaging.Examples.Export
    Public Class ExportDxfToPdf
        Shared Sub Main()
            ' The path to the documents directory.
            Dim dataDir As String = Aspose.Imaging.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            Using cadImage As CadImage = TryCast(Image.Load(dataDir + "conic_pyramid.dxf"), CadImage)
                Dim rasterizationOptions As CadRasterizationOptions = New CadRasterizationOptions()
                rasterizationOptions.PageWidth = 500
                rasterizationOptions.PageHeight = 500
                rasterizationOptions.TypeOfEntities = TypeOfEntities.Entities3D

                Dim pdfOptions As PdfOptions = New PdfOptions()
                pdfOptions.VectorRasterizationOptions = rasterizationOptions
                cadImage.Save(dataDir + "output.pdf", pdfOptions)
            End Using

        End Sub
    End Class
End Namespace
