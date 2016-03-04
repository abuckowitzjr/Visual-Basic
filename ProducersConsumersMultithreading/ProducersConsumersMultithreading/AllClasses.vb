Imports System.Threading
Public Class AllClasses

End Class

Public Class Helpdesk
    Public Shared data As New Queue(Of Integer)
    Private robj As New Random
    Private Shared _count As Integer = 0

    Public Sub New()
        Helpdesk._count += 1
    End Sub

    Public Shared ReadOnly Property Count As Integer
        Get
            Return Helpdesk._count
        End Get
    End Property

    Protected Overrides Sub finalize()
        If Helpdesk.Count > 0 Then
            Helpdesk._count -= 1
        End If
    End Sub

    Public Sub Generate()
        For i As Integer = 0 To 20
            SyncLock (Helpdesk.data)
                Helpdesk.data.Enqueue(robj.Next(1, 11))
            End SyncLock
            Thread.Sleep(500)
        Next
    End Sub
End Class

Public Class IT
    Dim rw As New ReaderWriterLock



    Public Sub Generate()

    End Sub

End Class
