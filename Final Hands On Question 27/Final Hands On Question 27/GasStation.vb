'Project:       Final Hands On Question 27
'Programmer:    Arthur Buckowitz
'Date:          July 6, 2012
'Description:   Allows the user to select the type gas gas being purchased, enter amount of gallons requested, and clicking
'               the pump button will store the information in an array to be displayed in a summary.


Public Class frmGasStation
    Const DECREGULARCOST As Decimal = 2.57D
    Const DECPLUSCOST As Decimal = 2.69D
    Const DECPREMIUMCOST As Decimal = 2.83D
    Dim Summary(2, 2) As Decimal
    Private Sub txtNumberOfGallons_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNumberOfGallons.TextChanged
        'validates user input to enable the pump button.
        Try
            If Not IsNumeric(txtNumberOfGallons.Text) And txtNumberOfGallons.Text <> "" Then
                MessageBox.Show("Only numbers may be entered for Number of Gallons.", "Input Error", MessageBoxButtons.OK)
                txtNumberOfGallons.Text = ""
                txtNumberOfGallons.Focus()
            Else
                If Integer.Parse(txtNumberOfGallons.Text) > 0 Then
                    btnPump.Enabled = True
                Else
                    btnPump.Enabled = False
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        'timer continually checks the user input textbox for empty string, if present, pump button is disabled.
        If txtNumberOfGallons.Text = "" Then
            btnPump.Enabled = False
        End If
    End Sub

    Private Sub btnPump_Click(sender As System.Object, e As System.EventArgs) Handles btnPump.Click
        'upon button click, rb's are checked to ensure correct storage location, stores information to correct array location.
        Try
            If rbRegular.Checked = True Then
                Summary(0, 0) = Summary(0, 0) + 1
                Summary(0, 1) = Summary(0, 1) + Decimal.Parse(txtNumberOfGallons.Text)
                Summary(0, 2) = Summary(0, 2) + TotalCharge(Decimal.Parse(txtNumberOfGallons.Text))
            ElseIf rbPlus.Checked = True Then
                Summary(1, 0) = Summary(1, 0) + 1
                Summary(1, 1) = Summary(1, 1) + Decimal.Parse(txtNumberOfGallons.Text)
                Summary(1, 2) = Summary(1, 2) + TotalCharge(Decimal.Parse(txtNumberOfGallons.Text))
            ElseIf rbPremium.Checked = True Then
                Summary(2, 0) = Summary(2, 0) + 1
                Summary(2, 1) = Summary(2, 1) + Decimal.Parse(txtNumberOfGallons.Text)
                Summary(2, 2) = Summary(2, 2) + TotalCharge(Decimal.Parse(txtNumberOfGallons.Text))
            End If
            txtNumberOfGallons.Text = ""
            txtNumberOfGallons.Focus()
        Catch ex As Exception
        End Try
    End Sub
    Private Function TotalCharge(num1 As Decimal) As Decimal
        'function to calculate the total cost for the amount of gallons sold based on type of gas selected.
        Dim Total As Decimal
        Try
            If rbRegular.Checked = True Then
                Total = DECREGULARCOST * num1
            ElseIf rbPlus.Checked = True Then
                Total = DECPLUSCOST * num1
            ElseIf rbPremium.Checked = True Then
                Total = DECPREMIUMCOST * num1
            End If
        Catch ex As Exception
        End Try
        Return Total
    End Function

    Private Sub lstboxGasTypes_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstboxGasTypes.SelectedIndexChanged
        'determines what item is selected out of the summary listbox and displays the correct information in labels in the summary section.
        Try
            If lstboxGasTypes.SelectedItem Is "Regular" Then
                lblType.Text = "Type: Regular"
                lblTotalSales.Text = "Count: " & Summary(0, 0).ToString
                lblTotalGallons.Text = "Gallons: " & Summary(0, 1).ToString
                lblTotalCost.Text = "Amount: " & Summary(0, 2).ToString("C")
            ElseIf lstboxGasTypes.SelectedItem Is "Plus" Then
                lblType.Text = "Type: Plus"
                lblTotalSales.Text = "Count: " & Summary(1, 0).ToString
                lblTotalGallons.Text = "Gallons: " & Summary(1, 1).ToString
                lblTotalCost.Text = "Amount: " & Summary(1, 2).ToString("C")
            ElseIf lstboxGasTypes.SelectedItem Is "Premium" Then
                lblType.Text = "Type: Premium"
                lblTotalSales.Text = "Count: " & Summary(2, 0).ToString
                lblTotalGallons.Text = "Gallons: " & Summary(2, 1).ToString
                lblTotalCost.Text = "Amount: " & Summary(2, 2).ToString("C")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        'clears the four labels located in the summary section.
        lblType.Text = ""
        lblTotalSales.Text = ""
        lblTotalGallons.Text = ""
        lblTotalCost.Text = ""
    End Sub
End Class
