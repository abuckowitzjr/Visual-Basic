Public Class frmHeight

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        frmFinalExam.Height = Integer.Parse(txtHeight.Text)
        Me.Close()
    End Sub
End Class