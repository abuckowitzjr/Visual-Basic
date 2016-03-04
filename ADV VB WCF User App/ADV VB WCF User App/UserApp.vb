Public Class UserApp

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim a As New SerRef1.MathClient

        MsgBox(a.add(Integer.Parse(txtOne.Text), Integer.Parse(txtTwo.Text)))

    End Sub

    Private Sub btnSubtract_Click(sender As System.Object, e As System.EventArgs) Handles btnSubtract.Click
        Dim a As New SerRef1.MathClient

        MsgBox(a.subtract(Integer.Parse(txtOne.Text), Integer.Parse(txtTwo.Text)))
    End Sub
End Class
