Public Class frmTitle

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        frmFinalExam.strTitle = txtTitle.Text
        Me.Close()
    End Sub
End Class