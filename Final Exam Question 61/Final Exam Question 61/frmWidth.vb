Public Class frmWidth

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        frmFinalExam.Width = Integer.Parse(txtWidth.Text)
        Me.Close()
    End Sub
End Class