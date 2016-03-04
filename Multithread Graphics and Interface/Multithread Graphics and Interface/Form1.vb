Imports System.Threading
Public Class Form1
    Dim t1 As Thread
    Dim t2 As Thread

    Private Sub btnCircle_Click(sender As System.Object, e As System.EventArgs) Handles btnCircle.Click
        If Not t1 Is Nothing AndAlso t1.ThreadState = ThreadState.Unstarted Then
            t1.Abort()
        End If
        Dim cl As New DrawCircle(PictureBox1)
        t1 = New Thread(AddressOf cl.draw)
        t1.Start()
    End Sub

    Private Sub btnPolygon_Click(sender As System.Object, e As System.EventArgs) Handles btnPolygon.Click
        If Not t2 Is Nothing AndAlso t2.ThreadState = ThreadState.Unstarted Then
            t2.Abort()
        End If
        Dim pl As New DrawPolygon(PictureBox1)
        t2 = New Thread(AddressOf pl.draw)
        t2.Start()
    End Sub
End Class
