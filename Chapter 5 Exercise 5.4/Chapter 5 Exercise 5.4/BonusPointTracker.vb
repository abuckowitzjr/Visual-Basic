' Project:      Bonus Point Tracker
' Programmer:   Arthur Buckowitz
' Date:         June 7, 2012
' Description:  Calculate the amount of bonus points earned based on user input of total books read, summary displays
'               average books read for all readers entered.

Public Class frmBPTracker
    Const int10Points As Integer = 10
    Const int15Points As Integer = 15
    Const int20Points As Integer = 20
    Dim intTotalBooksRead As Integer
    Dim intTotalReaders As Integer
    Dim ResultDialogColor As Color
    Dim ResultDialogFont As Font

    Private Sub PointsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PointsToolStripMenuItem.Click
        ' Retrieves information from PointsEarned function and displays bonus points in textbox.

        If txtboxName.Text = "" Or txtboxBooksRead.Text = "" Then
            MessageBox.Show("Please enter name and books read to display earned points.", "Input Error", MessageBoxButtons.OK)
        Else
            txtboxBooksRead.Text = Math.Floor(Decimal.Parse(txtboxBooksRead.Text))
            txtboxBonusPoints.Text = PointsEarned(Integer.Parse(txtboxBooksRead.Text))
            intTotalReaders += 1
            intTotalBooksRead = intTotalBooksRead + txtboxBooksRead.Text
        End If
    End Sub
    Private Function PointsEarned(ByVal num1 As Integer) As Integer
        ' Calculates amount of points earned based on how many books were read, returns total.

        Dim int1To3Books As Integer
        Dim int4To6Books As Integer
        Dim int7PlusBooks As Integer
        Dim intPointOutput

        If num1 <= 3 And Not 0 Then
            int1To3Books = num1 * int10Points
        End If
        If num1 >= 4 And num1 <= 6 Then
            int4To6Books = (num1 - 3) * int15Points + 30
        End If
        If num1 >= 7 Then
            int7PlusBooks = (num1 - 6) * int20Points + 75
        End If
        intPointOutput = int1To3Books + int4To6Books + int7PlusBooks
        Return intPointOutput.ToString

    End Function

    Private Sub SummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SummaryToolStripMenuItem.Click
        ' Retrieves AvgBooksRead function and displays in messagebox.

        If intTotalBooksRead = 0 Then
            MessageBox.Show("Summary cannot be displayed without first entering amount of books read.", "Input Error", MessageBoxButtons.OK)
        Else
            MessageBox.Show("Average Amount of Books Read: " & AvgBooksRead(), "Summary", MessageBoxButtons.OK)
        End If

    End Sub
    Private Function AvgBooksRead() As Integer
        ' Calculates average amount of books read for all readers and return total.

        Dim intAverage As Integer
        intAverage = intTotalBooksRead / intTotalReaders
        Return intAverage.ToString
    End Function

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        ' Clears fields of the form and places focus on name textbox.

        txtboxName.Text = ""
        txtboxBooksRead.Text = ""
        txtboxBonusPoints.Text = ""
        txtboxName.Focus()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        ' Exits the program

        Application.Exit()
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        ' Changes the font of the bonus points textbox.

        FontDialog1.ShowDialog()
        ResultDialogFont = FontDialog1.Font
        txtboxBonusPoints.Font = ResultDialogFont
    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        ' Changes the color of the bonus points textbox forecolor.

        ColorDialog1.ShowDialog()
        ResultDialogColor = ColorDialog1.Color
        txtboxBonusPoints.ForeColor = ResultDialogColor
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        ' Displays information about the program and programmer.

        MessageBox.Show("Bonus Point Tracker v1.3" & Environment.NewLine & "Programmer: Arthur Buckowitz", "About", MessageBoxButtons.OK)
    End Sub

    Private Sub txtboxName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtboxName.TextChanged
        ' Validates user input in name textbox.

        If IsNumeric(txtboxName.Text) Then
            MessageBox.Show("Numbers cannot be entered for name, please revise.", "Input Error", MessageBoxButtons.OK)
            txtboxName.Text = ""
        End If
    End Sub

    Private Sub txtboxBooksRead_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtboxBooksRead.TextChanged
        ' Validates user input in the books read textbox.

        If Not IsNumeric(txtboxBooksRead.Text) And txtboxBooksRead.Text <> "" Then
            MessageBox.Show("Letters and symbols may not be entered for " & Environment.NewLine & "amount of books read, please revise.", "Input Error", MessageBoxButtons.OK)
            txtboxBooksRead.Text = ""
        End If
    End Sub
End Class
