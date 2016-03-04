Public Class Form1

   
    Private Sub pbTarget_DragDrop(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles pbTarget.DragDrop
        pbTarget.Image = pbSource.Image
        pbSource.Image = Nothing
    End Sub

   
    Private Sub DragDropForm1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        pbTarget.AllowDrop = True
    End Sub

    Private Sub pbSource_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles pbSource.MouseMove
        Try
            pbSource.DoDragDrop(pbSource.Image, DragDropEffects.Move)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub pbTarget_DragEnter(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles pbTarget.DragEnter
        e.Effect = DragDropEffects.Move
    End Sub

    Private Sub btnResetImage_Click(sender As Object, e As System.EventArgs) Handles btnResetImage.Click
        pbSource.Image = pbTarget.Image
        pbTarget.Image = Nothing
    End Sub
End Class
