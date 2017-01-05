Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages

    Public Class SyncRootProperty

        Public Shared Sub Run()
            
            ' To get proper output please apply a valid Aspose.Imaging License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx."

            ' ExStart: SyncRootProperty

            ' Create an instance of Memory stream class.
            Using memoryStream As New System.IO.MemoryStream()
                ' Create an instance of Stream container class and assign memory stream object.
                Using streamContainer As New StreamContainer(memoryStream)
                    ' check if the access to the stream source is synchronized.
                    ' do work
                    ' now access to source MemoryStream is synchronized
                    SyncLock streamContainer.SyncRoot
                    End SyncLock
                End Using
            End Using

            ' ExEnd: SyncRootProperty


        End Sub

    End Class

End Namespace
