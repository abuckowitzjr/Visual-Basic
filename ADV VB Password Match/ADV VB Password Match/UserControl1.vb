Public Class UserControl1

  
    Private Sub TextBoxs_TextChanged(sender As Object, e As System.EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged
        If TextBox1.Text.Trim.Equals(TextBox2.Text.Trim) Then
            TextBox1.ForeColor = Color.Green
            TextBox2.ForeColor = Color.Green
        Else
            TextBox1.ForeColor = Color.Red
            TextBox2.ForeColor = Color.Red
        End If
    End Sub
End Class
