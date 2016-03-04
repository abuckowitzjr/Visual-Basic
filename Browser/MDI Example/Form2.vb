Public Class Form2

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            If LCase(Microsoft.VisualBasic.Left(ToolStripTextBox1.Text, 7)) <> "http://" Then
                ToolStripTextBox1.Text = "http://" & ToolStripTextBox1.Text
            End If
            WebBrowser1.Url = New Uri(ToolStripTextBox1.Text)
            Dim myParentForm As Browser = DirectCast(Me.MdiParent, Browser)
            myParentForm.lbHistory.Items.Add(ToolStripTextBox1.Text)
            Me.Text = ToolStripTextBox1.Text
            ToolStripTextBox1.Text = ""
        Catch ex As Exception
            MsgBox("Bad URL entered")
        End Try
    End Sub

    Private Sub ToolStripTextBox1_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox1.KeyUp
        If e.KeyCode = Keys.Enter Then
            ToolStripButton1_Click(sender, e)
        End If
    End Sub
End Class