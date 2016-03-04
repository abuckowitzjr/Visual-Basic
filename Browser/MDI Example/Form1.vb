Public Class Browser

    Private Sub NewWindowToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NewWindowToolStripMenuItem.Click
        'Create child form, assigned it a parent, and show the form.
        Dim childForm As New Form2
        childForm.MdiParent = Me
        childForm.Text = "Enter a URL"
        childForm.Show()
    End Sub

    Private Sub TileHorizontallyToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TileHorizontallyToolStripMenuItem.Click
        'sets child forms in tile horizontal format.
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub TileVerticallyToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TileVerticallyToolStripMenuItem.Click
        'sets child forms in tile vertical format.
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CascadeToolStripMenuItem.Click
        'sets child forms in cascade format.
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub


    Private Sub CloseAllToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CloseAllToolStripMenuItem.Click
        'Loop through each MDI child and call the close method
        For Each tmpform As Form In Me.MdiChildren
            tmpform.Close()
        Next tmpform
    End Sub

    Private Sub MinimizeAllToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MinimizeAllToolStripMenuItem.Click
        For Each tmpform As Form In Me.MdiChildren
            tmpform.WindowState = FormWindowState.Minimized
        Next tmpform
    End Sub

    Private Sub lbHistory_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lbHistory.SelectedIndexChanged
        Dim tmpform As Form2 = CType(Me.ActiveMdiChild, Form2)
        If Not tmpform Is Nothing Then
            tmpform.WebBrowser1.Url = New Uri(lbHistory.Text)
            tmpform.Text = lbHistory.Text
        End If
    End Sub
End Class
