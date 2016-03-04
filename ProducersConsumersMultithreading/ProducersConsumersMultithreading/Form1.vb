Imports System.Threading
Public Class Form1

    Private Sub btnAddHelp_Click(sender As System.Object, e As System.EventArgs) Handles btnAddHelp.Click
        Dim helpdesk1 As New Helpdesk
        Dim thread1 As New Thread(AddressOf helpdesk1.generate)
        thread1.Start()
        UpdateCounts()
    End Sub

    Private Sub UpdateCounts()
        lblHelpdesk.Text = Helpdesk.Count.ToString
    End Sub
End Class
