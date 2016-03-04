Public Class Form1
    Dim maxTextHeight As Integer = -1

    Private Sub VScrollBar1_ValueChanged(sender As Object, e As System.EventArgs) Handles VScrollBar1.ValueChanged
        PictureBox1.Refresh()

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Refresh()
    End Sub

    Private Sub PictureBox1_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles PictureBox1.Paint
        Dim lineHeight As Integer = 20
        Dim x As Integer
        Dim y As Integer
        For i As Integer = 65 To 65 + 25
            For j As Integer = 0 To 40
                x = j * 20
                y = (0 - Convert.ToInt32((VScrollBar1.Value / VScrollBar1.Maximum) * (maxTextHeight - PictureBox1.Height)) + (lineHeight * (i - 65)))
                e.Graphics.DrawString(ChrW(i), New Font("Arial", 12), Brushes.Black, New Point(x, y))
            Next
        Next
        If maxTextHeight = -1 Then
            maxTextHeight = y + lineHeight + 60
        End If
    End Sub
End Class
