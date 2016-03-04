Public Class frmJobInfo
    Const DECTAXRATE As Decimal = 0.08
    Const DECHOURLYWAGE As Decimal = 50
   Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        'displays information about jobs using functions to calculate totals, stores information in variables for summary.
        Dim decAmountCharged As Decimal
        If txtJobNumber.Text = "" Then
            MessageBox.Show("Please complete all fields before calculating.", "Input Error", MessageBoxButtons.OK)
        ElseIf txtCustomerName.Text = "" Then
            MessageBox.Show("Please complete all fields before calculating.", "Input Error", MessageBoxButtons.OK)
        ElseIf txtAmountCharged.Text = "" Then
            MessageBox.Show("Please complete all fields before calculating.", "Input Error", MessageBoxButtons.OK)
        ElseIf txtHourOfLabor.Text = "" Then
            MessageBox.Show("Please complete all fields before calculating.", "Input Error", MessageBoxButtons.OK)
        ElseIf txtHourOfLabor.Text = 0 Then
            MessageBox.Show("Work completed cannot consist of 0 hours worked, please enter number of labor hours.", "Input Error", MessageBoxButtons.OK)
        Else
            decAmountCharged = Decimal.Parse(txtAmountCharged.Text)
            txtParts.Text = decAmountCharged.ToString("C")
            txtLabor.Text = CalculateLaborCost(txtHourOfLabor.Text).ToString("C")
            txtSubtotal.Text = (CalculateLaborCost(txtHourOfLabor.Text) + Decimal.Parse(txtAmountCharged.Text)).ToString("C")
            txtSalesTax.Text = CalculateSalesTax(txtAmountCharged.Text).ToString("C")
            txtTotal.Text = CalculateTotal().ToString("C")
            frmPatsAutoRepair.decTotalParts = frmPatsAutoRepair.decTotalParts + txtAmountCharged.Text
            frmPatsAutoRepair.decTotalLabor = frmPatsAutoRepair.decTotalLabor + CalculateLaborCost(txtHourOfLabor.Text)
            frmPatsAutoRepair.decTotalSalesTax = frmPatsAutoRepair.decTotalSalesTax + CalculateSalesTax(txtAmountCharged.Text)
            frmPatsAutoRepair.decTotalTotal = frmPatsAutoRepair.decTotalTotal + CalculateTotal()
        End If
    End Sub
    Private Function CalculateTotal() As Decimal
        'function to calculate total cost for customer.
        Dim decTotalCost As Decimal
        decTotalCost = CalculateSalesTax(txtAmountCharged.Text) + CalculateLaborCost(txtHourOfLabor.Text) + Decimal.Parse(txtAmountCharged.Text)
        Return decTotalCost
    End Function
    Private Function CalculateSalesTax(ByVal num1 As Decimal) As Decimal
        'function to calculate total sales tax for cost of parts.
        Dim decSalesTax As Decimal
        decSalesTax = num1 * DECTAXRATE
        Return decSalesTax
    End Function
    Private Function CalculateLaborCost(ByVal num1 As Integer) As Decimal
        'function to calculate total cost based on labor.
        Dim decLaborCharge As Decimal
        decLaborCharge = num1 * DECHOURLYWAGE
        Return decLaborCharge
    End Function
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'clears all fields of the form for new user input.
        txtParts.Text = ""
        txtLabor.Text = ""
        txtSubtotal.Text = ""
        txtSalesTax.Text = ""
        txtTotal.Text = ""
        txtJobNumber.Text = ""
        txtCustomerName.Text = ""
        txtHourOfLabor.Text = ""
        txtAmountCharged.Text = ""
        txtJobNumber.Focus()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        'closes job information form, resets focus to main form.
        Me.Close()
        frmPatsAutoRepair.Focus()
    End Sub

    Private Sub txtJobNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtJobNumber.TextChanged
        'validates user input.
        If Not IsNumeric(txtJobNumber.Text) And txtJobNumber.Text <> "" Then
            MessageBox.Show("Letters may not be entered for Job Number, please correct.", "Input Error", MessageBoxButtons.OK)
            txtJobNumber.Text = ""
        End If
    End Sub

    Private Sub txtCustomerName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCustomerName.TextChanged
        'validate user input.
        If IsNumeric(txtCustomerName.Text) Then
            MessageBox.Show("Numbers may not be entered for Customer Name, please correct.", "Input Error", MessageBoxButtons.OK)
            txtCustomerName.Text = ""
        End If
    End Sub


    Private Sub txtAmountCharged_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmountCharged.TextChanged
        'validates user input.
        If Not IsNumeric(txtAmountCharged.Text) And txtAmountCharged.Text <> "" Then
            MessageBox.Show("Letters may not be entered for Amount Charged For Parts, please correct.", "Input Error", MessageBoxButtons.OK)
            txtAmountCharged.Text = ""
        End If
    End Sub

    Private Sub txtHourOfLabor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHourOfLabor.TextChanged
        'validates user input.
        If Not IsNumeric(txtHourOfLabor.Text) And txtHourOfLabor.Text <> "" Then
            MessageBox.Show("Letters may not be entered for Hours of Labor, please correct.", "Input Error", MessageBoxButtons.OK)
            txtHourOfLabor.Text = ""
        End If
    End Sub
End Class