' Project:      Sales Commission Calculator
' Programmer:   Arthur Buckowitz
' Date:         June 7, 2012
' Description:  Calculates user input to figure amount of commission earned, returning total amount earned plus commission.


Public Class SalesCalculator
    Dim Summary() As Totals
    Dim ResultDialogColor As Color
    Dim ResultDialogFont As Font

    Private Sub PayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PayToolStripMenuItem.Click
        ' Calculates total amount earned and displays in textbox, uses commission function to determine if commision was earned.
        Dim strName As String = txtboxName.Text
        Dim decSales As Decimal = Decimal.Parse(txtboxSales.Text)
        Dim Employee As New SalesCommission(strName, decSales)
        If Summary Is Nothing Then
            ReDim Summary(0)
        End If
        Summary(0).TotalCommission = SalesCommission.CommissionTotal
        Summary(0).TotalEarned = SalesCommission.EarnedTotal
        Summary(0).TotalSales = SalesCommission.SalesTotal
        Display()

       
    End Sub

    Private Structure Totals
        Dim TotalEarned As Decimal
        Dim TotalCommission As Decimal
        Dim TotalSales As Decimal
    End Structure

    Private Sub Display()
        txtboxCommission.Text = SalesCommission.Commission
        txtboxTotalPay.Text = SalesCommission.Pay
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        ' Clears all fields of the form and places focus back in name textbox.

        txtboxName.Text = ""
        txtboxSales.Text = ""
        txtboxTotalPay.Text = ""
        txtboxCommission.Text = ""
        txtboxName.Focus()
    End Sub

    Private Sub txtboxName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtboxName.TextChanged
        ' Validates user input in name textbox.

        If IsNumeric(txtboxName.Text) Then
            MessageBox.Show("Numbers cannot be entered for name, please revise.", "Input Error", MessageBoxButtons.OK)
            txtboxName.Text = ""
        End If
    End Sub

    Private Sub txtboxSales_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtboxSales.TextChanged
        ' Validates user input in sales textbox.

        If Not IsNumeric(txtboxSales.Text) And txtboxSales.Text <> "" Then
            MessageBox.Show("Sales field cannot contain letters, please revise.", "Input Error", MessageBoxButtons.OK)
            txtboxSales.Text = ""
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        ' Exits the program.

        Application.Exit()
    End Sub

    Private Sub SummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SummaryToolStripMenuItem.Click
        ' Displays summary of total sales, commission, and earnings for all workers in messagebox.
        If Summary Is Nothing Then
            MessageBox.Show("Information must entered for at least one salesperson to display summary.", "Input Error", MessageBoxButtons.OK)
        Else
            MessageBox.Show("Total Sales: " & SalesCommission.SalesTotal.ToString("C") & Environment.NewLine &
                                    "Total Commission: " & SalesCommission.CommissionTotal.ToString("C") & Environment.NewLine &
                                    "Total Pay: " & SalesCommission.EarnedTotal.ToString("C"), "Summary", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        ' Changes the font of the total amount earned textbox.

        FontDialog1.ShowDialog()
        ResultDialogFont = FontDialog1.Font
        txtboxTotalPay.Font = ResultDialogFont
    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        ' Changes the forecolor of the total amount earned textbox.

        ColorDialog1.ShowDialog()
        ResultDialogColor = ColorDialog1.Color
        txtboxTotalPay.ForeColor = ResultDialogColor
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        ' Displays information about the program and the programmer.

        MessageBox.Show("Sales Calculator v2.5" & Environment.NewLine & "Programmed By: Arthur Buckowitz")
    End Sub



End Class
