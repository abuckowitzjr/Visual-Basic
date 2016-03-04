Public Class PickVBProject
    Dim rnd As New Random
    Dim count(1) As Integer
    Dim i As Integer
    Private Sub btnGO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGO.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim num As Integer
        If i >= 10000 Then
            Timer1.Enabled = False
            Exit Sub
        End If
        num = Convert.ToInt32(Math.Floor(rnd.Next(2)))
        count(num) += 1
        lblMoonPatrol.Text = count(0).ToString
        lblPong.Text = count(1).ToString
        i += 1
    End Sub
End Class
