'Project:       Bucko's Yachts
'Programmer:    Arthur Buckowitz
'Date:          June 23, 2012
'Description:   Form for calculating and displaying the cost of charters based on input, type of yacht, size of yacht and length of time used.

Public Class frmBuckosYachts
    Const SIZE22 As Decimal = CDec(95.0)
    Const SIZE24 As Decimal = CDec(137.0)
    Const SIZE30 As Decimal = CDec(160.0)
    Const SIZE32 As Decimal = CDec(192.0)
    Const SIZE36 As Decimal = CDec(250.0)
    Const SIZE38 As Decimal = CDec(400.0)
    Const SIZE45 As Decimal = CDec(550.0)
    Dim decCostTotal As Decimal
    Dim intNumberOfCharters As Integer
    Dim intTotalHours As Integer
    Dim intAverageHours As Integer
    Private Function AverageHoursChartered(num1 As Integer, num2 As Integer) As Integer
        'Calculate the average amount of hours chartered for all charters.
        Dim Average As Integer
        Average = CInt(num1 / num2)
        Return Average
    End Function
    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        'displays information about program in a messagebox.
        MessageBox.Show("Bucko's Yachts" & Environment.NewLine & "Version 1.0" & Environment.NewLine &
                        "Programmed By: Arthur Buckowitz", "About", MessageBoxButtons.OK)
    End Sub
    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        'uses various functions to calculate totals and averages, displays information in cooresponding textboxes, validates that all
        'fields have input before calculating.
        If txtResponParty.Text = "" Then
            MessageBox.Show("Please enter the name of Responsible Party.", "Input Error", MessageBoxButtons.OK)
            txtResponParty.Focus()
        ElseIf txtHours.Text = "" Then
            MessageBox.Show("Please enter Hours Chartered.", "Input Error", MessageBoxButtons.OK)
            txtHours.Focus()
        ElseIf comboboxYachtType.Text = "" Then
            MessageBox.Show("Please select or enter the Type of Yacht.", "Input Error", MessageBoxButtons.OK)
            comboboxYachtType.Focus()
        ElseIf comboboxSize.Text = "" Then
            MessageBox.Show("Please select the Yacht Size.", "Input Error", MessageBoxButtons.OK)
            comboboxSize.Focus()
        Else
            txtHours.Text = Math.Floor(CDbl(txtHours.Text)).ToString
            intNumberOfCharters += 1
            intTotalHours = intTotalHours + Integer.Parse(txtHours.Text)
            intAverageHours = AverageHoursChartered(intTotalHours, intNumberOfCharters)
            YachtTypeCheck()
            CalculateTotal(CInt(txtHours.Text))
            decCostTotal += CalculateTotal(CInt(txtHours.Text))
            txtCost.Text = (CalculateTotal(CInt(txtHours.Text)).ToString("C"))
        End If
    End Sub
    Private Function CalculateTotal(num1 As Integer) As Decimal
        'function to calculate the total revenue for all charters.
        Dim Total As Decimal
        Dim Size As Decimal
        If CDbl(comboboxSize.Text) = 22 Then
            Size = SIZE22
        ElseIf CDbl(comboboxSize.Text) = 24 Then
            Size = SIZE24
        ElseIf CDbl(comboboxSize.Text) = 30 Then
            Size = SIZE30
        ElseIf CDbl(comboboxSize.Text) = 32 Then
            Size = SIZE32
        ElseIf CDbl(comboboxSize.Text) = 36 Then
            Size = SIZE36
        ElseIf CDbl(comboboxSize.Text) = 38 Then
            Size = SIZE38
        ElseIf CDbl(comboboxSize.Text) = 45 Then
            Size = SIZE45
        End If
        Total = CDec(Size * CDbl(Integer.Parse(txtHours.Text)))
        Return Total
    End Function
    Private Sub YachtTypeCheck()
        'validates user input on yacht type entered, if in combo box, disregards, if not in combo box, adds new type.
        Dim YachtTypeEntered As String
        Dim YachtTypeList As String
        Dim blnItemFound As Boolean = False
        Dim intItemIndex As Integer = 0
        YachtTypeEntered = comboboxYachtType.Text.ToUpper
        Do Until blnItemFound Or intItemIndex = comboboxYachtType.Items.Count
            YachtTypeList = CStr(comboboxYachtType.Items(intItemIndex)).ToUpper
            If YachtTypeEntered = YachtTypeList Then
                blnItemFound = True
            Else
                intItemIndex += 1
            End If
        Loop
        If blnItemFound = False Then
            comboboxYachtType.Items.Add(StrConv(comboboxYachtType.Text, vbProperCase))
        End If
    End Sub
    Private Sub ClearForm(sender As System.Object, e As System.EventArgs)
        'clears all fields of the form and sets focus.
        txtResponParty.Text = ""
        txtHours.Text = ""
        comboboxSize.Text = ""
        comboboxYachtType.Text = ""
        txtResponParty.Focus()
    End Sub
    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        'calls the Clearform sub for clear button click.
        ClearForm(sender, e)
    End Sub
    Private Sub NextCharterToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NextCharterToolStripMenuItem.Click
        'calls the clearform sub for clear for next charter menu click.
        ClearForm(sender, e)
    End Sub
    Private Sub PrintSummaryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintSummaryToolStripMenuItem.Click
        'displays print preview for summary.
        PrintPreviewDialog1.Document = PrintDocument2
        PrintPreviewDialog1.ShowDialog()
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'designates information to print document 1 for yacht types.
        Dim PrintFont As New Font("Arial", 12)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim HorizontalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
        Dim PrintLineString As String
        e.Graphics.DrawString("Arthur Buckowitz", PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle * 3
        e.Graphics.DrawString("Yacht Types:", PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle
        For intListIndex As Integer = 0 To comboboxYachtType.Items.Count - 1
            PrintLineString = comboboxYachtType.Items(intListIndex).ToString()
            VerticalPrintLocationSingle += LineHeightSingle
            e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        Next
    End Sub
    Private Sub PrintYachtTypesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintYachtTypesToolStripMenuItem.Click
        'displays print preview for yacht types.
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub
    Private Sub PrintDocument2_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
        'designates information to print document 2 for summary.
        Dim PrintFont As New Font("Arial", 12)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim HorizontalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
        e.Graphics.DrawString("Arthur Buckowitz", PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle * 3
        e.Graphics.DrawString("Number of Charters: " & intNumberOfCharters.ToString, PrintFont, Brushes.Black,
                              HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle
        e.Graphics.DrawString("Total Revenue: " & decCostTotal.ToString("C"), PrintFont, Brushes.Black,
                              HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle
        e.Graphics.DrawString("Average Hours Chartered: " & intAverageHours.ToString, PrintFont, Brushes.Black,
                              HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
    End Sub
    Private Sub txtResponParty_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtResponParty.TextChanged
        'validates user input for responsible party.
        If IsNumeric(txtResponParty.Text) Then
            MessageBox.Show("Numbers cannot be entered for Responsible Party.", "Input Error", MessageBoxButtons.OK)
            txtResponParty.Text = ""
        End If
    End Sub
    Private Sub txtHours_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHours.TextChanged
        'validates user input for hours chartered.
        If Not IsNumeric(txtHours.Text) And txtHours.Text <> "" Then
            MessageBox.Show("Letters cannot be entered for Hours Chartered.", "Input Error", MessageBoxButtons.OK)
            txtHours.Text = ""
        End If
    End Sub
    Private Sub comboboxSize_TextChanged(sender As Object, e As System.EventArgs) Handles comboboxSize.TextChanged
        'validates user input for entered yacht size.
        If Not IsNumeric(comboboxSize.Text) And comboboxSize.Text <> "" Then
            MessageBox.Show("Letters cannot be entered for Size.", "Input Error", MessageBoxButtons.OK)
            comboboxSize.Text = ""
        End If
    End Sub
    Private Sub comboboxYachtType_TextChanged(sender As Object, e As System.EventArgs) Handles comboboxYachtType.TextChanged
        'validates user input for entered yacht type.
        If IsNumeric(comboboxYachtType.Text) Then
            MessageBox.Show("Numbers cannot be entered for Yacht Type.", "Input Error", MessageBoxButtons.OK)
            comboboxYachtType.Text = ""
        End If
    End Sub
    Private Sub DisplayCountOfYachtTypesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DisplayCountOfYachtTypesToolStripMenuItem.Click
        'Counts number of items in yacht type combo box and displays in messagebox.
        Dim intItemCount As Integer = 0
        Do Until intItemCount = comboboxYachtType.Items.Count
            intItemCount += 1
        Loop
        MessageBox.Show("Total yacht types: " & intItemCount, "Total Yachts", MessageBoxButtons.OK)
    End Sub
    Private Sub AddYachtTypeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddYachtTypeToolStripMenuItem.Click
        'validates if user input is in combobox yacht type, if not adds input to list.
        YachtTypeCheck()
    End Sub
    Private Sub RemoveYachtTypeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RemoveYachtTypeToolStripMenuItem.Click
        'calls the sub for item removal from yacht list.
        CheckForRemoval()
    End Sub
    Private Sub CheckForRemoval()
        'Checks for input in combobox yacht types, if in list, removes when button pressed, if not, displays messagebox informing
        'item not in list.
        Dim YachtTypeEntered As String
        Dim YachtTypeList As String
        Dim blnItemFound As Boolean = False
        Dim intItemIndex As Integer = 0
        YachtTypeEntered = StrConv(comboboxYachtType.Text, vbProperCase)
        Do Until blnItemFound Or intItemIndex = comboboxYachtType.Items.Count
            YachtTypeList = CStr(comboboxYachtType.Items(intItemIndex))
            If YachtTypeEntered = YachtTypeList Then
                comboboxYachtType.Items.RemoveAt(intItemIndex)
                comboboxYachtType.Text = ""
                comboboxYachtType.Focus()
                blnItemFound = True
                Exit Do
            Else
                intItemIndex += 1
            End If
        Loop
        If blnItemFound = False Then
            MessageBox.Show("Bagel type entered is not in the list, enter different bagel type", "Input Error", MessageBoxButtons.OK)
            comboboxYachtType.Text = ""
            comboboxYachtType.Focus()
        End If
    End Sub
End Class
