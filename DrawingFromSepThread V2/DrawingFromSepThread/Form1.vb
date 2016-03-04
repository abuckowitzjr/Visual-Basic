Imports System.Threading
Public Class Form1
    Dim b As Bitmap
    Dim g As Graphics

    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        b = New Bitmap(pb.Width, pb.Height)
        g = Graphics.FromImage(b)
        bw1.RunWorkerAsync()
    End Sub

    Private Sub pb_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles pb.Paint
        e.Graphics.DrawImage(b, 0, 0)
    End Sub

    Private Sub bw1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw1.DoWork
        Dim r As New Random
        For i As Integer = 1 To 1000
            Dim p As New Pen(Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255)), r.Next(5, 40))
            p.DashStyle = Drawing2D.DashStyle.Dash
            g.DrawEllipse(p, New Rectangle(r.Next(-100, 375), r.Next(-100, 375), r.Next(250, 500), r.Next(250, 500)))
            bw1.ReportProgress(i)
            If bw1.CancellationPending = True Then
                Exit For
            End If
            Thread.Sleep(50)
        Next
    End Sub

    Private Sub bw1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bw1.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
        Me.Refresh()
    End Sub

    Private Sub btnStop_Click(sender As System.Object, e As System.EventArgs) Handles btnStop.Click
        bw1.CancelAsync()
    End Sub
End Class