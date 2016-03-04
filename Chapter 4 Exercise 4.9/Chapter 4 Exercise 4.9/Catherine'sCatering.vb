' Project:      Catherine's Catering
' Programmer:   Arthur Buckowitz
' Date:         May 6, 2012
' Description:  Allows user to input number of guests, and select what mune items the user would like to have, calculate button calculates
'               total cost based on number of guests and items selected, clear button clear fields of main form, summary button displays 
'               message box displaying total events and total dollar amount of all events, user is prompted to clear all fields 
'               and memory of form, exit button closes program.

Public Class frmCatherinesCatering
    Const decPrimeRib As Decimal = 25.95
    Const decChicken As Decimal = 18.95
    Const decPasta As Decimal = 12.95
    Const decOpenBar As Decimal = 25.0
    Const decWine As Decimal = 8.0
    Dim decTotalEvent As Decimal
    Dim decTotalDollarAmount As Decimal


    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        ' Uses user input number of guests to calculate total cost of menu items, and displays the total in textbox.

        Dim decTotalGuests As Decimal
        Dim decAmountDue As Decimal
        decTotalGuests = Decimal.Parse(txtboxNumberOfGuests.Text)
        If rbPrimeRib.Checked = True Then
            decAmountDue = decTotalGuests * decPrimeRib
        ElseIf rbChicken.Checked = True Then
            decAmountDue = decTotalGuests * decChicken
        ElseIf rbPasta.Checked = True Then
            decAmountDue = decTotalGuests * decPasta
        End If
        If cbOpenBar.Checked = True Then
            decAmountDue = decAmountDue + decOpenBar
        End If
        If cbWine.Checked = True Then
            decAmountDue = decAmountDue + decWine
        End If
        txtboxAmountDue.Text = decAmountDue.ToString("C")
        decTotalEvent += 1
        decTotalDollarAmount += decAmountDue
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clears all fields of the main form.

        cbOpenBar.Checked = False
        cbWine.Checked = False
        rbChicken.Checked = False
        rbPrimeRib.Checked = False
        rbPasta.Checked = False
        txtboxNumberOfGuests.Text = ""
        txtboxAmountDue.Text = ""
        txtboxNumberOfGuests.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Exits the program.

        Application.Exit()
    End Sub

    Private Sub btnSummary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSummary.Click
        ' Displays message box containing a summary of all event and total cost of all events, user is prompted to decide
        ' if they wish to clear all fields of the form, if yes selected, all fields and memory will be cleared.

        Dim ReturnDialogResult As DialogResult
        If txtboxAmountDue.Text = "" Then
            MessageBox.Show("No events have been entered, please complete event information.", "Error", MessageBoxButtons.OK)
        Else
            MessageBox.Show("Total Events: " & decTotalEvent.ToString & Environment.NewLine & "Total Dollar Amount: " &
                                   decTotalDollarAmount.ToString, "Summary")
            ReturnDialogResult = MessageBox.Show("Would you like to clear summary information?", "Clear Information", MessageBoxButtons.YesNo)
            If ReturnDialogResult = DialogResult.Yes Then
                decTotalDollarAmount = 0
                decTotalEvent = 0
                cbOpenBar.Checked = False
                cbWine.Checked = False
                rbChicken.Checked = False
                rbPrimeRib.Checked = False
                rbPasta.Checked = False
                txtboxNumberOfGuests.Text = ""
                txtboxAmountDue.Text = ""
                txtboxNumberOfGuests.Focus()
            End If
        End If


    End Sub

    Private Sub txtboxNumberOfGuests_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtboxNumberOfGuests.TextChanged
        ' Validation for user input testing for numeric value, if not numeric, displays message box prompting correct input.

        If Not IsNumeric(txtboxNumberOfGuests.Text) And txtboxNumberOfGuests.Text <> "" Then
            MessageBox.Show("Please enter numeric value for number of guests.", "Input Error", MessageBoxButtons.OK)
            txtboxNumberOfGuests.Text = ""
        End If
    End Sub
End Class
