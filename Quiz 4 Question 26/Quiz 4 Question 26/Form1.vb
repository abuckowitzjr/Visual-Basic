'Project:       Quiz 4 Question 26
'Programmer:    Arthur Buckowitz
'Date:          July 5, 2012
'Description:   Allows the user to add or remove completed courses for students, user may also print a list of the entered completed courses.

Public Class frmPrintListBox

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'exits the program
        Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        'displays the about box item
        AboutBox1.Show()
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        'validates input, if listbox is empty, adds entered course into list, if not empty, calls on the check for course sub.
        Dim Result As DialogResult
        If txtEnteredCourse.Text = "" Then
            MessageBox.Show("Please enter course you wish to add", "Input Error", MessageBoxButtons.OK)
        Else
            Result = MessageBox.Show("Is the following course you wish to add correct:" & Environment.NewLine & txtEnteredCourse.Text,
                            "Confirm Course Entry", MessageBoxButtons.YesNo)
            If Result = Windows.Forms.DialogResult.Yes Then
                If lstboxCourses.Items.Count = 0 Then
                    lstboxCourses.Items.Add(txtEnteredCourse.Text)
                Else
                    CheckForCourse(sender, e)
                End If
            End If
        End If
        txtEnteredCourse.Text = ""
        txtEnteredCourse.Focus()
    End Sub
    Private Sub CheckForCourse(sender As System.Object, e As System.EventArgs)
        'checks the entered course for existence within the listbox, if present, displays message box, if not, adds new course to list.
        Dim blnCheck As Boolean = False
        Dim strStoredCourse As String
        Try
            For i As Integer = 0 To lstboxCourses.Items.Count - 1
                strStoredCourse = lstboxCourses.Items(i).ToString
                If txtEnteredCourse.Text.ToUpper = strStoredCourse.ToUpper Then
                    blnCheck = True
                    Exit For
                End If
            Next
            If blnCheck = True Then
                MessageBox.Show("The course entered already exist in the list.", "Input Error", MessageBoxButtons.OK)
            Else
                lstboxCourses.Items.Add(txtEnteredCourse.Text)
                txtEnteredCourse.Text = ""
                txtEnteredCourse.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click
        'removes the selected course from the list
        Try
            If lstboxCourses.Items.Count > 0 Then
                lstboxCourses.Items.RemoveAt(lstboxCourses.SelectedIndex)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PrintCompletedCoursesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintCompletedCoursesToolStripMenuItem.Click
        'displays the print preview dialog box
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'designates information to print document 1 for printing.
        Dim PrintFont As New Font("Arial", 12)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim HorizontalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
        For i As Integer = 0 To lstboxCourses.Items.Count - 1
            e.Graphics.DrawString(lstboxCourses.Items(i).ToString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle,
                                  VerticalPrintLocationSingle)
            VerticalPrintLocationSingle += LineHeightSingle
        Next
    End Sub
End Class
