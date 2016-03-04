' Project:      Quotations
' Programmer:   Arthur Buckowitz
' Date:         June 8, 2012
' Description:  The display message button displays the correct message based on what author is selected in radio buttons.

Public Class frmQuotations


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Display message button displays message in label depending on which radio button is selected.

        Try
            If rbErnestHemingway.Checked = True Then
                lblMessage.Text = "I know only that what is moral is what you feel good" & Environment.NewLine &
                    "after and what is immoral is what you feel bad after."
            ElseIf rbOscarWilde.Checked = True Then
                lblMessage.Text = "The only thing to do with good advice is to pass it" & Environment.NewLine &
                    "on. It is never of any use to oneself."
            ElseIf rbRobertFrost.Checked = True Then
                lblMessage.Text = "There's nothing I'm afraid of like scared people."
            ElseIf rbWaltWhitman.Checked = True Then
                lblMessage.Text = "The future is no more uncertain than the present."
            End If
        Catch ex As FormatException
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK)
        End Try
    End Sub
End Class
