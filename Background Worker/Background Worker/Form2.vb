Imports System.Threading

Public Class Form2



    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        BackgroundWorker1.RunWorkerAsync()
    End Sub


    Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        For i As Integer = 1 To 200000
            If i Mod 1000 = 0 Then
                BackgroundWorker1.ReportProgress(i)
            End If
            Application.DoEvents()
        Next

    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
        Me.Refresh()
    End Sub

   Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        ProgressBar1.Value = 200000
        Me.Refresh()
    End Sub

    Private Sub Form2_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        ProgressBar1.Maximum = 200000
        ProgressBar1.Minimum = 0
    End Sub
End Class
