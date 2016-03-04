'Project:       Student Info
'Programmer:    Arthur Buckowitz
'Date:          June 20, 2012
'Description:   Allows user to input student information into form, print button print all entered info on page, 
'               accept button clears all fields and resets focus to name textbox.


Public Class StudentInfo
    Private Sub AddHighSchoolToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddHighSchoolToolStripMenuItem.Click
        'Adds the entered high school name in the high school combo box to the list of available schools.
        comboboxHighschool.Items.Add(StrConv(comboboxHighschool.Text, vbProperCase))
    End Sub
    Private Sub btnAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccept.Click
        'Clears all fields of the form for new student information.
        txtName.Text = ""
        txtUnitsCompleted.Text = ""
        txtName.Focus()
        rbFreshman.Checked = False
        rbJunior.Checked = False
        rbSenior.Checked = False
        rbSophomore.Checked = False
        chkboxDeansList.Checked = False
        comboboxHighschool.Text = ""
        lstboxMajors.ClearSelected()
    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'Exits the program.
        Application.Exit()
    End Sub
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        'Displays information about the program in a messagebox.
        MessageBox.Show("Student Info" & Environment.NewLine & "Version 1.0" & Environment.NewLine & "Programmed By: Arthur Buckowitz", "About", MessageBoxButtons.OK)
    End Sub
    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        'Validates that user input was entered, if so, displays print preview, verifies deans list if not selected via messagebox.
        Dim intDeansListResult As Integer
        HighSchoolCheck(sender, e)
        PrintPreviewDialog1.Document = PrintDocument1
        If txtName.Text = "" Then
            MessageBox.Show("Please enter student name.", "Input Error", MessageBoxButtons.OK)
        ElseIf txtUnitsCompleted.Text = "" Then
            MessageBox.Show("Please enter units completed.", "Input Error", MessageBoxButtons.OK)
        ElseIf rbFreshman.Checked = False And rbSophomore.Checked = False And rbJunior.Checked = False And rbSenior.Checked = False Then
            MessageBox.Show("Please select current grade level. Check Dean's List if applicable.", "Input Error", MessageBoxButtons.OK)
        ElseIf comboboxHighschool.Text = "" Then
            MessageBox.Show("Please select High School attended.", "Input Error", MessageBoxButtons.OK)
        ElseIf lstboxMajors.Text = "" Then
            MessageBox.Show("Please select Major.", "Input Error", MessageBoxButtons.OK)
        ElseIf chkboxDeansList.Checked = False Then
            intDeansListResult = MessageBox.Show("Is the student on the Dean's List", "Dean's List", MessageBoxButtons.YesNo)
            If intDeansListResult = vbYes Then
                chkboxDeansList.Checked = True
                PrintPreviewDialog1.ShowDialog()
            Else
                PrintPreviewDialog1.ShowDialog()
            End If
        Else
            PrintPreviewDialog1.ShowDialog()
        End If
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'Designates form information to print document to send to printer based on user input.
        Dim PrintFont As New Font("Arial", 12)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim HorizontalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
        e.Graphics.DrawString("Arthur Buckowitz", PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle * 3
        e.Graphics.DrawString("Student Name: " & txtName.Text, PrintFont, Brushes.Black, HorizontalPrintLocationSingle,
                              VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle
        e.Graphics.DrawString("Units Completed: " & txtUnitsCompleted.Text, PrintFont, Brushes.Black, HorizontalPrintLocationSingle,
                              VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle
        If rbFreshman.Checked = True Then
            e.Graphics.DrawString("Grade Level: Freshman", PrintFont, Brushes.Black, HorizontalPrintLocationSingle,
                                  VerticalPrintLocationSingle)
        ElseIf rbSophomore.Checked = True Then
            e.Graphics.DrawString("Grade Level: Sophomore", PrintFont, Brushes.Black, HorizontalPrintLocationSingle,
                                  VerticalPrintLocationSingle)
        ElseIf rbJunior.Checked = True Then
            e.Graphics.DrawString("Grade Level: Junior", PrintFont, Brushes.Black, HorizontalPrintLocationSingle,
                                  VerticalPrintLocationSingle)
        ElseIf rbSenior.Checked = True Then
            e.Graphics.DrawString("Grade Level: Senior", PrintFont, Brushes.Black, HorizontalPrintLocationSingle,
                                  VerticalPrintLocationSingle)
        End If
        If chkboxDeansList.Checked = True Then
            e.Graphics.DrawString("(Dean's List)", PrintFont, Brushes.Black, 320, VerticalPrintLocationSingle)
        End If
        VerticalPrintLocationSingle += LineHeightSingle
        e.Graphics.DrawString("High School: " & comboboxHighschool.Text, PrintFont, Brushes.Black, HorizontalPrintLocationSingle,
                              VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle
        e.Graphics.DrawString("Major: " & lstboxMajors.Text, PrintFont, Brushes.Black, HorizontalPrintLocationSingle,
                              VerticalPrintLocationSingle)
    End Sub
    Private Sub txtName_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtName.TextChanged
        'validates user input for student name.
        If IsNumeric(txtName.Text) Then
            MessageBox.Show("Numbers cannot be entered for Student Name.", "Input Error", MessageBoxButtons.OK)
            txtName.Text = ""
        End If
    End Sub
    Private Sub txtUnitsCompleted_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtUnitsCompleted.TextChanged
        'validate user input for units completed.
        If Not IsNumeric(txtUnitsCompleted.Text) And txtUnitsCompleted.Text <> "" Then
            MessageBox.Show("Letters may not be entered for Units Completed.", "Input Error", MessageBoxButtons.OK)
            txtUnitsCompleted.Text = ""
        End If
    End Sub
    Private Sub comboboxHighschool_TextChanged(sender As Object, e As System.EventArgs) Handles comboboxHighschool.TextChanged
        'validate user entered high school name.
        If IsNumeric(comboboxHighschool.Text) Then
            MessageBox.Show("Numbers may not be entered for name of High School.", "Input Error", MessageBoxButtons.OK)
            comboboxHighschool.Text = ""
        End If
    End Sub

    Private Sub PrintSchoolsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintSchoolsToolStripMenuItem.Click
        'sets document for print preview to print document 2 and shows print preview.
        HighSchoolCheck(sender, e)
        PrintPreviewDialog1.Document = PrintDocument2
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument2_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
        'designates information to print document 2 for printing.
        Dim PrintFont As New Font("Arial", 12)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim HorizontalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
        Dim PrintLineString As String
        e.Graphics.DrawString("Arthur Buckowitz", PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle * 3
        e.Graphics.DrawString("High Schools:", PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle
        For intListIndex As Integer = 0 To comboboxHighschool.Items.Count - 1
            PrintLineString = comboboxHighschool.Items(intListIndex).ToString()
            VerticalPrintLocationSingle += LineHeightSingle
            e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        Next
    End Sub
    Private Sub HighSchoolCheck(sender As System.Object, e As System.EventArgs)
        'validates user input on high school entered, if in combo box, disregards, if not in combo box, adds new school.
        Dim HighSchoolEntered As String
        Dim HighSchoolList As String
        Dim blnItemFound As Boolean = False
        Dim intItemIndex As Integer = 0
        HighSchoolEntered = comboboxHighschool.Text.ToUpper
        Do Until blnItemFound Or intItemIndex = comboboxHighschool.Items.Count
            HighSchoolList = CStr(comboboxHighschool.Items(intItemIndex)).ToUpper
            If HighSchoolEntered = HighSchoolList Then
                blnItemFound = True
            Else
                intItemIndex += 1
            End If
        Loop
        If blnItemFound = False Then
            comboboxHighschool.Items.Add(StrConv(comboboxHighschool.Text, vbProperCase))
        End If
    End Sub
End Class
