Public Class MultiForm
    Friend strName As String
    Friend decScore As Decimal
    Friend Const PI As Decimal = 3.14159D
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub Form2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Form2ToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub Form3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Form3ToolStripMenuItem.Click
        Form3.Show()
    End Sub
End Class
