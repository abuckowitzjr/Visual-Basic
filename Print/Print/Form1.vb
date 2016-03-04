Public Class Form1

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim strMessage As String
        Dim numOFLines As Integer
        Dim lineHeight As Integer = 15
        Dim HorizontalMargin As Integer = 50
        Static pageNum As Integer = 1
        strMessage = txtMessage.Text
        numOFLines = Integer.Parse(txtNumberOfLines.Text)

        For i As Integer = 0 To numOFLines - 1
            If e.MarginBounds.Top + i * lineHeight >= e.MarginBounds.Bottom Then
                Exit For
            End If
            e.Graphics.DrawString(strMessage, txtMessage.Font, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Right)
        Next
        e.Graphics.FillEllipse(Brushes.Aqua, 100, 100, 300, 300)
        pageNum += 1
        If pageNum <= 4 Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
        End If
    End Sub
End Class
