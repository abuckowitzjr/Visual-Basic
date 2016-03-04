Public Class Form1

    Private Sub txtName_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles txtName.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            With txtName
                .SelectAll()
                .DoDragDrop(.SelectedText, DragDropEffects.Move)
            End With
        End If
    End Sub

    Private Sub lstboxTeamA_DragDrop(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles lstboxTeamA.DragDrop
        lstboxTeamA.Items.Add(e.Data.GetData(DataFormats.Text).ToString())
        txtName.Clear()
    End Sub

    Private Sub lstboxTeamA_DragEnter(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles lstboxTeamA.DragEnter
        e.Effect = DragDropEffects.Move
    End Sub

    Private Sub lstboxTeamB_DragDrop(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles lstboxTeamB.DragDrop
        lstboxTeamB.Items.Add(e.Data.GetData(DataFormats.Text).ToString())
        txtName.Clear()
    End Sub

    Private Sub lstboxTeamB_DragEnter(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles lstboxTeamB.DragEnter
        e.Effect = DragDropEffects.Move
    End Sub

    Private Sub txtName_MouseEnter(sender As Object, e As System.EventArgs) Handles txtName.MouseEnter
        With txtName
            If .Text <> "" Then
                .SelectAll()
                .Cursor = Cursors.Arrow
            Else
                .Cursor = Cursors.IBeam
            End If
        End With
    End Sub
End Class
