' Project:      Calorie Calculator
' Programmer:   Arthur Buckowitz
' Date:         May 23, 2012
' Description:  Converts grams input by user into calories, totaling the calories and items entered, 
'               has calculat button to execute calculation, clear button to clear all fields, print button to print the form, 
'               and an exit button to close the program.

Public Class CalorieCounterForm
    Dim decTotalCal As Decimal
    Dim decTotalItems As Decimal

    Private Sub CalculateButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CalculateButton.Click
        ' Calculates total amount of grams into total amount of calories, also calculates total grams entered.

        Try
            Dim decFatCal As Decimal
            Dim decCarbCal As Decimal
            Dim decProteinCal As Decimal
            Dim decFatItem As Decimal
            Dim decCarbItem As Decimal
            Dim decProteinItem As Decimal
            decFatCal = Decimal.Parse(FatGramInputTextBox.Text)
            decFatCal = decFatCal * 9
            FatGramCalLabel.Text = decFatCal.ToString

            decCarbCal = Decimal.Parse(CarbGramInputTextBox.Text)
            decCarbCal = decCarbCal * 4
            CarbGramCalLabel.Text = decCarbCal.ToString

            decProteinCal = Decimal.Parse(ProteinGramInputTextBox.Text)
            decProteinCal = decProteinCal * 4
            ProteinGramCalLabel.Text = decProteinCal.ToString

            decTotalCal = decFatCal + decCarbCal + decProteinCal
            TotalCalLabel.Text = decTotalCal.ToString

            decFatItem = Decimal.Parse(FatGramInputTextBox.Text)
            decCarbItem = Decimal.Parse(CarbGramInputTextBox.Text)
            decProteinItem = Decimal.Parse(ProteinGramInputTextBox.Text)
            decTotalItems = decFatItem + decCarbItem + decProteinItem
            TotalItemsLabel.Text = decTotalItems.ToString
        Catch ex As FormatException
            MessageBox.Show("All fields must have a value, enter 0 for zero gram", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            FatGramCalLabel.Text = ""
            CarbGramCalLabel.Text = ""
            ProteinGramCalLabel.Text = ""
        End Try


    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        ' Clears all fields of the form.

        FatGramCalLabel.Text = ""
        CarbGramCalLabel.Text = ""
        ProteinGramCalLabel.Text = ""
        TotalCalLabel.Text = ""
        FatGramInputTextBox.Text = ""
        CarbGramInputTextBox.Text = ""
        ProteinGramInputTextBox.Text = ""
        TotalItemsLabel.Text = ""
    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        ' Prints the form.

        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        ' Closes the program.

        Me.Close()
    End Sub
End Class
