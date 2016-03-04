Imports System.Threading
Public Class Form1

    'Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
    '     BackgroundWorker1.RunWorkerAsync()
    ' End Sub

    ' Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
    '     BackgroundWorker2.RunWorkerAsync()
    ' End Sub

    ' Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
    '     For i As Integer = 1 To 50000
    '         If i Mod 150 = 0 Then
    '             BackgroundWorker1.ReportProgress(i \ 500)
    '         End If
    '         Application.DoEvents()
    '     Next

    ' End Sub

    ' Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
    '     Label1.Text = "Task 1: " & e.ProgressPercentage
    '     Me.Refresh()
    ' End Sub

    ' Private Sub BackgroundWorker2_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
    '     For i As Integer = 1 To 50000
    '         If i Mod 150 = 0 Then
    '             BackgroundWorker2.ReportProgress(i \ 500)
    '         End If
    '         Application.DoEvents()
    '     Next

    ' End Sub

    ' Private Sub BackgroundWorker2_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker2.ProgressChanged
    '     Label2.Text = "Task 2: " & e.ProgressPercentage
    '     Me.Refresh()
    ' End Sub

    ' Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
    '     Label1.Text = "Task 1: Completed"
    '     Me.Refresh()
    ' End Sub

    ' Private Sub BackgroundWorker2_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
    '     Label2.Text = "Task 2: Completed"
    '     Me.Refresh()
    ' End Sub

    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'Form2.Show()
        'Form3.Show()
    End Sub
End Class
