'Project:       Bradley's Bagels
'Programmer:    Arthur Buckowitz
'Date:          June 24, 2012
'Description:   Allows user to add or remove bagel types to the list, clear the list of items in the bagel types combobox, print the list
'               off bagels, and display total count of items.

Public Class frmBradleysBagels
    Private Sub btnAddBagelType_Click(sender As System.Object, e As System.EventArgs) Handles btnAddBagelType.Click
        'adds user input in bagel type textbox to bagel type list.
        If comboboxBagelTypes.Text = "" Then
            MessageBox.Show("No bagel type entered, please enter bagel type to add to the list", "Input Error", MessageBoxButtons.OK)
            comboboxBagelTypes.Focus()
        Else
            comboboxBagelTypes.Items.Add(StrConv(comboboxBagelTypes.Text, vbProperCase))
            comboboxBagelTypes.Text = ""
            comboboxBagelTypes.Focus()
        End If
    End Sub
    Private Sub comboboxBagelTypes_TextChanged(sender As Object, e As System.EventArgs) Handles comboboxBagelTypes.TextChanged
        'validates user input for combobox bagel types.
        If IsNumeric(comboboxBagelTypes.Text) Then
            MessageBox.Show("Numbers cannot be entered for bagel type.", "Input Error", MessageBoxButtons.OK)
            comboboxBagelTypes.Text = ""
            comboboxBagelTypes.Focus()
        End If
    End Sub
    Private Sub btnRemoveBagelType_Click(sender As System.Object, e As System.EventArgs) Handles btnRemoveBagelType.Click
        'call check for removal sub for removing items from list.
        If comboboxBagelTypes.Text = "" Then
            MessageBox.Show("No bagel type entered, please enter bagel type to remove from the list", "Input Error", MessageBoxButtons.OK)
            comboboxBagelTypes.Focus()
        Else
            CheckForRemoval()
        End If
    End Sub
    Private Sub CheckForRemoval()
        'checks bagel list for input item and if found removes, if not, displays message box informing item not in list.
        Dim BagelTypeEntered As String
        Dim BagelTypeList As String
        Dim blnItemFound As Boolean = False
        Dim intItemIndex As Integer = 0
        BagelTypeEntered = StrConv(comboboxBagelTypes.Text, vbProperCase)
        Do Until blnItemFound Or intItemIndex = comboboxBagelTypes.Items.Count
            BagelTypeList = CStr(comboboxBagelTypes.Items(intItemIndex))
            If BagelTypeEntered = BagelTypeList Then
                comboboxBagelTypes.Items.RemoveAt(intItemIndex)
                comboboxBagelTypes.Text = ""
                comboboxBagelTypes.Focus()
                blnItemFound = True
                Exit Do
            Else
                intItemIndex += 1
            End If
        Loop
        If blnItemFound = False Then
            MessageBox.Show("Bagel type entered is not in the list, enter different bagel type", "Input Error", MessageBoxButtons.OK)
            comboboxBagelTypes.Text = ""
            comboboxBagelTypes.Focus()
        End If
    End Sub
    Private Sub btnClearBagelList_Click(sender As System.Object, e As System.EventArgs) Handles btnClearBagelList.Click
        'clears all items in the bagel list.
        comboboxBagelTypes.Items.Clear()
    End Sub
    Private Sub btnDisplayBagelTypeCount_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplayBagelTypeCount.Click
        'reads the number of items in the bagel type list and displays in messagebox.
        Dim intItemCount As Integer = 0
        Do Until intItemCount = comboboxBagelTypes.Items.Count
            intItemCount += 1
        Loop
        MessageBox.Show("Total bagel types: " & intItemCount, "Total Bagels", MessageBoxButtons.OK)
    End Sub
    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        'exits the program.
        Application.Exit()
    End Sub

    Private Sub btnPrintBagelList_Click(sender As System.Object, e As System.EventArgs) Handles btnPrintBagelList.Click
        'displays print preview for print document 1.
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'designates information for printing on print document 1.
        Dim PrintFont As New Font("Arial", 12)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim HorizontalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
        Dim PrintLineString As String
        e.Graphics.DrawString("Bagel Types:", PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle
        For intItemCount = 0 To comboboxBagelTypes.Items.Count - 1
            PrintLineString = comboboxBagelTypes.Items(intItemCount).ToString()
            e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
            VerticalPrintLocationSingle += LineHeightSingle
        Next
    End Sub
End Class


