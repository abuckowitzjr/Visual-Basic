Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        For i As Integer = 1 To 5000
            Label1.Text = i.ToString
            Application.DoEvents()
            Threading.Thread.Sleep(10)
        Next
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        For i As Integer = 1 To 5000
            Label2.Text = i.ToString
            Application.DoEvents()
            Threading.Thread.Sleep(10)
        Next
    End Sub
End Class
