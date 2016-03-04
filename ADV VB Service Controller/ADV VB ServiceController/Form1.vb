Imports ADV_VB_ServiceController

Public Class Form1
    Private srvsContrl As ServiceProcess.ServiceController

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        srvsContrl = New ServiceProcess.ServiceController("ADV VB DesktopWatcherService")
        lblStatus.Text = srvsContrl.Status.ToString()
    End Sub

    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click
        srvsContrl.Start()
        Dim i As Integer = 1
        While srvsContrl.Status.ToString <> "Running" And i < 5
            srvsContrl.Refresh()
            lblStatus.Text = srvsContrl.Status.ToString()
            Threading.Thread.Sleep(200)
            i = i + 1
        End While
    End Sub

    Private Sub btnPause_Click(sender As System.Object, e As System.EventArgs) Handles btnPause.Click
        srvsContrl.Pause()
        srvsContrl.Refresh()
        lblStatus.Text = srvsContrl.Status.ToString()
    End Sub

    Private Sub btnStop_Click(sender As System.Object, e As System.EventArgs) Handles btnStop.Click
        srvsContrl.Stop()
        srvsContrl.Refresh()
        lblStatus.Text = srvsContrl.Status.ToString()
    End Sub
End Class
