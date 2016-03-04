' Project:      Rental Charge Calculator
' Programmer:   Arthur Buckowitz
' Date:         May 30, 2012
' Description:  A calculator for generating total charge on rental, calculates total miles based on user 
'               input odometer readings, multiplied by charge per mile, calculates charge for days of usage, 
'               displays total charge to the customer, clear button to clear form, print button to print the form, 
'               and an exit button to close program.

Public Class RentalChargeCalculatorForm
    Const decPerDayCharge As Decimal = 15
    Const decPerMileCharge As Decimal = 0.12
    Dim decTotalMileCharge As Decimal
    Dim decTotalDayCharge As Decimal
    Dim decTotalMiles As Decimal
    Dim decTotalCharge As Decimal

    Private Sub CalculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateButton.Click
        ' Performs calculation for total cost to the customer, as well as total miles driven. 
        ' Total miles driven calculated from entered odometer readings, total cost calculated from total 
        ' days of usage and total miles driven, totals are displayed in cooresponding text boxes.

        Try
            Dim decBeginOdo As Decimal
            Dim decEndOdo As Decimal
            Dim decTotalDays As Decimal


            decBeginOdo = Decimal.Parse(BeginningOdoMaskedTextBox.Text)
            decEndOdo = Decimal.Parse(EndingOdoMaskedTextBox.Text)
            decTotalMiles = decEndOdo - decBeginOdo
            TotalMilesTextBox.Text = decTotalMiles.ToString("N")

            decTotalDays = Decimal.Parse(TotalDaysMaskedTextBox.Text)

            decTotalMileCharge = decTotalMiles * decPerMileCharge
            decTotalDayCharge = decTotalDays * decPerDayCharge
            decTotalCharge = decTotalMileCharge + decTotalDayCharge
            TotalCostTextBox.Text = decTotalCharge.ToString("C")
        Catch ex As FormatException
            MessageBox.Show("All fields must have a value, enter 0 for none.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        If TotalMilesTextBox.Text < 0 Then
            MessageBox.Show("Ending Odometer Reading cannot be less than Beginning Odometer Reading, please revise.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TotalMilesTextBox.Text = ""
            TotalCostTextBox.Text = ""
        End If



    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        ' Clears all fields of the form.

        CustomerNameTextBox.Text = ""
        AddressTextBox.Text = ""
        CityTextBox.Text = ""
        StateTextBox.Text = ""
        ZIPMaskedTextBox.Text = ""
        BeginningOdoMaskedTextBox.Text = ""
        EndingOdoMaskedTextBox.Text = ""
        TotalDaysMaskedTextBox.Text = ""
        TotalMilesTextBox.Text = ""
        TotalCostTextBox.Text = ""
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        ' Closes the program.

        Me.Close()
    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        ' Prints the form.

        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub
End Class
