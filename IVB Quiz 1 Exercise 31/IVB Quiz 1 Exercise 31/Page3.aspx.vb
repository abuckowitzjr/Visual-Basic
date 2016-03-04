Public Class Page3
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Displays user input in labels
        Try
            lblFirstName.Text = txtFirstName.Text
            lblLastName.Text = txtLastName.Text
            lblDateOfBirth.Text = txtDateOfBirth.Text
        Catch ex As Exception
            MsgBox("Error")
        End Try

    End Sub
End Class