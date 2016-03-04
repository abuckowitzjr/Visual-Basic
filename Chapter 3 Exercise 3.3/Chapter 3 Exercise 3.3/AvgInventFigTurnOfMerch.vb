' Project:      Average Inventory Figure/Turnover of Merchandise
' Programmer:   Arthur Buckowitz
' Date:         May 30, 2012
' Description:  Performs calculations and displays results to the user, the average inventory is calculated 
'               from user input beginning inventory and ending inventory, turnover calculated from average inventory and 
'               entered cost of goods sold, has clear button to clear all fields of the form, a print button to print the 
'               form, and an exit button to close the program.

Public Class AvgInventFigTurnOfMerch
    Dim decAvgInv As Decimal
    Dim decTurnover As Decimal


    Private Sub CalculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateButton.Click
        ' Calculates average inventory figure and turnover based on user input data.

        Try
            Dim decBegInv As Decimal
            Dim decEndInv As Decimal
            Dim decCost As Decimal

            decBegInv = Decimal.Parse(BeginningInvTextBox.Text)
            decEndInv = Decimal.Parse(EndingInvTextBox.Text)
            decCost = Decimal.Parse(CostOfGoodsSoldTextBox.Text)

            decAvgInv = (decBegInv + decEndInv) / 2
            decTurnover = decCost / decAvgInv

            AverageInvTextBox.Text = decAvgInv.ToString("C")
            decTurnover = Decimal.Round(decTurnover, 1)
            TurnoverTextBox.Text = decTurnover.ToString

        Catch ex As Exception
            MessageBox.Show("The sum of Beginning Inventory and Ending Inventory cannot equal 0, please revise.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        ' Prints the form.

        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        'Closes the program.

        Me.Close()
    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        ' Clears all fields of the form.

        BeginningInvTextBox.Text = ""
        EndingInvTextBox.Text = ""
        CostOfGoodsSoldTextBox.Text = ""
        AverageInvTextBox.Text = ""
        TurnoverTextBox.Text = ""
    End Sub
End Class
