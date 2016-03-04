'Project:       Quiz 3 Question 24
'Programmer:    Arthur Buckowitz
'Date:          August 27, 2012
'Description:   When start is clicked, program generates sequencial numbers from 0 to 9, progressbar displays progress,
'               clicking cancel stops generating numbers and stops the progress bar.

Imports System.Threading
Public Class Form1
    Private Delegate Sub pro()
    Private Delegate Sub upd(ByVal number As Integer)
    Dim t1 As New Thread(AddressOf Task1)
    Dim number As Integer = 9
    Dim CheckCancel As Boolean = False

    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click
        'begins the number generation and background worker for progress
        Try
            t1.Start()
            BackgroundWorker1.RunWorkerAsync()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        'stops the number generation and background worker for progress
        Try
            t1.Abort()
            CheckCancel = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Task1()
        'generates sequential numbers from 0 to 9, has sleep to simulate 1 second intervals
        Try
            For i As Integer = 0 To number
                If InvokeRequired Then
                    Invoke(New upd(AddressOf UpdateListbox), i)
                End If
                Thread.Sleep(1000)
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub UpdateListbox(ByVal number As Integer)
        'adds generated numbers to the listbox
        lstbxNumbers.Items.Add(number.ToString)
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        'generates information to track progress for progressbar
        Try
            For i As Integer = 0 To number
                If CheckCancel = True Then
                    e.Cancel = True
                Else
                    BackgroundWorker1.ReportProgress(i * 10 + 10)
                    Thread.Sleep(1000)
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        'sets the progress for the progressbar
        Me.ProgressBar1.Value = e.ProgressPercentage
    End Sub
End Class
