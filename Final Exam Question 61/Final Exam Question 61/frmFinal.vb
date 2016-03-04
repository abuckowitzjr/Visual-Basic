Public Class frmFinalExam
    Dim strData As String
    Dim strFilename As String
    Dim clrBackgroundColor As Color
    Dim clrForeColor As Color
    Friend intHeight As Integer
    Friend intWidth As Integer
    Friend strTitle As String
    Dim lblInfo As New Label

    Private Sub SaveFileAsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaveFileAsToolStripMenuItem.Click
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            strFilename = SaveFileDialog1.FileName
            strData = "Background Color" & "|" & (BackColor.ToArgb).ToString & Environment.NewLine & "Font Color" & "|" & (ForeColor.ToArgb).ToString &
                Environment.NewLine & "Window Height" & "|" & Height.ToString & Environment.NewLine & "Window Width" & "|" & Width.ToString &
                Environment.NewLine & "Title" & "|" & strTitle
            My.Computer.FileSystem.WriteAllText(strFilename, strData, False)
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub BackgroundColorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BackgroundColorToolStripMenuItem.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            Me.BackColor = ColorDialog1.Color
            clrBackgroundColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub FontColorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FontColorToolStripMenuItem.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            Me.ForeColor = ColorDialog1.Color
            clrForeColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub HeightToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HeightToolStripMenuItem.Click
        frmHeight.ShowDialog()
    End Sub

    Private Sub WidthToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles WidthToolStripMenuItem.Click
        frmWidth.ShowDialog()
    End Sub

    Private Sub WindowTitleToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles WindowTitleToolStripMenuItem.Click
        frmTitle.ShowDialog()
    End Sub

    Private Sub HelpToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles HelpToolStripMenuItem1.Click
        MessageBox.Show("No help at this time. Good Luck!", "MenuFontsGraphics")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("This program is for Intermediate VB Final Exam", "MenuFontsGraphics")
    End Sub

    Private Sub frmFinalExam_Load(sender As Object, e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub DisplayInfo()

    End Sub

    Private Sub frmFinalExam_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim surface As Graphics = Me.CreateGraphics
        Dim p As New Pen(Brushes.DarkSeaGreen, 10)
        surface.DrawLine(p, 0, 32, Me.Width, 32)
        surface.DrawLine(p, 3, 32, 3, Me.Height)
        surface.DrawLine(p, Me.Width - 14, 32, Me.Width - 14, Me.Height)
    End Sub
End Class
