Public Class Page2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strFirstName As String
        Dim strLastName As String
        strFirstName = txtFirstName.Text
        strLastName = txtLastName.Text
        lblFullName.Text = strFirstName & " " & strLastName
        HiddenField1.Value = strFirstName
    End Sub

    Protected Sub btnRandom_Click(sender As Object, e As EventArgs) Handles btnRandom.Click
        Randomize()
    End Sub
End Class