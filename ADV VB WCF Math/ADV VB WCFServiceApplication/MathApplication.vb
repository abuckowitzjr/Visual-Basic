Imports System.ServiceModel
Imports System.ServiceModel.Description

Public Class MathApplication
    Private svchost As ServiceHost
    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        lblStatus.Text = "Stopped"
        svchost = New ServiceHost(GetType(ADV_VB_WCF_Math.MyMath))
    End Sub

    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click
        Try
            Dim netbind As New NetTcpBinding()
            svchost.AddServiceEndpoint(GetType(ADV_VB_WCF_Math.IMath), netbind, "net.tcp://localhost:2255/myMath")
            Dim smb As New ServiceMetadataBehavior
            smb.HttpGetEnabled = True
            smb.HttpGetUrl = New Uri("http://localhost:8080/myMath")
            svchost.Description.Behaviors.Add(smb)
            svchost.Open()
            lblStatus.Text = "Started"
        Catch ex As Exception
            lblStatus.Text = "Error" & vbCrLf & ex.Message
        End Try
    End Sub

    Private Sub btnStop_Click(sender As System.Object, e As System.EventArgs) Handles btnStop.Click
        Try
            svchost.Close()
        Catch ex As Exception
        End Try
        lblStatus.Text = "Stopped"
    End Sub
End Class
